using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Drawing;
using Emgu.CV.Util;

namespace EmguProject
{
    public partial class Form1 : Form
    {

        VideoCapture videoCapture;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        Image<Gray, byte> grayImage;
        List<int> labels = new List<int>();
        const double threshold = double.PositiveInfinity;
        CascadeClassifier classifier = new CascadeClassifier(@"../../Assets/haarcascade_frontalface_default.xml");
        EigenFaceRecognizer faceRecognizer = new EigenFaceRecognizer(80, threshold);
        //LBPHFaceRecognizer LBPHFaceRecognizer = new LBPHFaceRecognizer()
        Timer timer = new Timer();
        int counter = 0;
        bool isTrained = false;

        /*
         1. Prepoznaj lice, inicijalno ga dodaj u trainingImages
         2. 
             
             
             */




        public Form1()
        {
            InitializeComponent();
            videoCapture = new VideoCapture();
        }
   

        //Slikanje web camerom
        private void BeginWebCam()
        {
            videoCapture = new VideoCapture();
            while (true)
            {   
            Mat mat = videoCapture.QueryFrame().Clone();
            imgBox1.Image = mat.ToImage<Bgr, byte>().Resize(800, 600, Emgu.CV.CvEnum.Inter.Cubic);
            Image<Gray, byte> pic = mat.ToImage<Gray, byte>().Resize(180,240,Emgu.CV.CvEnum.Inter.Cubic);
            imgBox1.Image = pic;

            Rectangle[] rectangles = classifier.DetectMultiScale(pic,1.1,3);

            if (rectangles.Count() > 0)
            {
                trainingImages.Add(pic);
                labels.Add(labels.Count+1);
                Image<Gray, Byte> theClone = pic.Clone();
                foreach (var rect in rectangles)
                {
                    theClone.Draw(rect, new Gray(1), 2);
                }

                string currDirectory = Directory.GetCurrentDirectory();

                int crntLabels = File.ReadAllText(Application.StartupPath + @"/../../Images/Faces.txt").Split(',').Length-1;
                for (int i = 0; i < trainingImages.Count; i++)
                {
                    trainingImages[i].Save(Application.StartupPath + @"/../../Images/face" + (crntLabels+1) + ".bmp");
                    if(crntLabels == 0)
                    {
                        File.AppendAllText(Application.StartupPath + @"/../../Images/Faces.txt",(crntLabels+1).ToString());
                    }
                    else
                    {
                        File.AppendAllText(Application.StartupPath + @"/../../Images/Faces.txt", ',' +((crntLabels+1).ToString()));
                    }
                    ++crntLabels;
                }
          

                imgBox2.Image = theClone;
                ++counter;
                MessageBox.Show("Done", "Info", MessageBoxButtons.OK);
                    videoCapture.Dispose();
                    break;
            }
            }
            
        }

        //Treniranje
        private void btnTrain_Click(object sender, EventArgs e)
        {
            string location = Application.StartupPath + @"/../../Images/";
            if (trainingImages.Count == 0)
            {
                string[] images = Directory.GetFiles(location, "*.bmp", SearchOption.TopDirectoryOnly);
                foreach (var image in images)
                {
                    trainingImages.Add(new Image<Gray, byte>(image));
                }
            }
            if (labels.Count == 0)
            {
                labels= File.ReadAllText(location + "Faces.txt").Split(',').Select(_=>int.Parse(_)).ToList();
            }



            Mat[] mats = new Mat[trainingImages.Count];
            for (int i = 0; i < mats.Count(); i++)
            {
                mats[i] = trainingImages[i].Mat.Clone();
            }
            VectorOfMat vMat = new VectorOfMat(mats);
            VectorOfInt vInt = new VectorOfInt(labels.ToArray());
            faceRecognizer.Train(vMat,vInt);
            faceRecognizer.Write(Application.StartupPath + @"/../../Images/facerecognizer.yml");
            MessageBox.Show("Training done", "Info", MessageBoxButtons.OK);
            isTrained = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            BeginWebCam();
        }


        //Predikcijaš+v  xyttrrtr
        private void btnPredict_Click(object sender, EventArgs e)
        {
            try
            {
                Mat imageMat = null;
                while (true)
                        {
                    imageMat = videoCapture.QueryFrame().Clone();
                    
                    Image<Gray, byte> image = imageMat.ToImage<Gray, byte>().Resize(180,200,Emgu.CV.CvEnum.Inter.Cubic);
                    Rectangle[] rectangles = classifier.DetectMultiScale(image, 1.1, 4);
                    if (rectangles.Count() > 0)
                        break;
                }
                if(imageMat != null)
                {
                    imageMat = imageMat.ToImage<Gray, byte>().Resize(180, 200, Emgu.CV.CvEnum.Inter.Cubic).Mat;
                    faceRecognizer.Read(Application.StartupPath + @"/../../Images/facerecognizer.yml");
                    var res = faceRecognizer.Predict(imageMat);
                    if(res.Distance >threshold)
                    {
                        txtBox_Label.Text = res.Label.ToString();
                        txtBox_distance.Text = res.Distance.ToString();
                        string foundImage = Application.StartupPath + @"/../../Images/face" + res.Label.ToString() + ".bmp";
                        imgBox1.Image= imageMat.ToImage<Gray, byte>();
                        picBox.Image = Image.FromFile(foundImage);
                        MessageBox.Show("Successufully found label", "Success", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Not Found", "INFO", MessageBoxButtons.OK);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "INFO", MessageBoxButtons.OK);
            }

        }
        

        private void function()
        {

            string path = @"C:\Users\User\Desktop\faces94\";
            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            int cnt = 0;
            foreach (var file in files)
            {
                //Image<Gray, byte> image = new Image<Gray, byte>(file);
                //image.Save(Application.StartupPath + @"/../../Images/face" + (cnt+1).ToString()+".bmp");
                if(cnt== files.Length - 1)
                {
                    File.AppendAllText(Application.StartupPath + @"/../../Images/Faces.txt", (cnt + 1).ToString());

                }
                File.AppendAllText(Application.StartupPath + @"/../../Images/Faces.txt", (cnt + 1).ToString()+ ',');
                ++cnt;
            }
        }

        private void btnUploadImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Filter = "Image files | *.jpg;*.jpeg;*.png;";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                int cntImages = File.ReadAllText(Application.StartupPath+@"/../../Images/Faces.txt").Split(',').Length;
                string path = Application.StartupPath + @"/../../Images/";
                for(int i = 0; i< fileDialog.FileNames.Length;i++)
                {
                    Image<Gray, byte> image = new Image<Gray, byte>(fileDialog.FileNames[i]).Resize(180,240,Emgu.CV.CvEnum.Inter.Cubic);
                    image.Save(path+ "face" + (cntImages).ToString() + ".bmp");
                    if(cntImages!=0 || i == fileDialog.FileName.Length-1)
                    {
                        File.AppendAllText(path + "Faces.txt", ','+ (cntImages).ToString());
                    }
                    else
                    {
                        File.AppendAllText(path+"Faces.txt", (cntImages).ToString() + ',');
                    }
                    ++cntImages;
                }

            }
        }

        private void imgBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image files | *.jpg;*.jpeg;*.png";
            if(fileDialog.ShowDialog() == DialogResult.OK)
            {
                imgBox2.Image = new Image<Gray, byte>(fileDialog.FileName);
               
                    faceRecognizer.Read(Application.StartupPath + @"/../../Images/facerecognizer.yml");
                    var res = faceRecognizer.Predict(imgBox2.Image);
                    if(res.Distance < 500)
                    {
                        label1.Text = "Label-> " + res.Label.ToString();
                        txtBox_distance.Text = res.Distance.ToString();
                        string foundImage = Application.StartupPath + @"/../../Images/face" + res.Label.ToString() + ".bmp";
                        picBox.Image = Image.FromFile(foundImage);
                    }
                    else
                    {
                        MessageBox.Show("Not found", "Info", MessageBoxButtons.OK);
                    }
                
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            function();
        }
    }
}
