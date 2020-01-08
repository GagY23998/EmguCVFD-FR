using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu;
using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.Util;

namespace EmguProject
{
    public partial class FormDb : Form
    {
        FaceRecognitionDB recognitionDB = new FaceRecognitionDB();
        VideoCapture video = new VideoCapture();
        CascadeClassifier classifier = new CascadeClassifier(@"../../Assets/haarcascade_frontalface_default.xml");
        List<Image<Gray, byte>> images;
        Timer timer = new Timer();
        int errorcounter = 0;
        int timeLimit = 10;
        int cnter = 0;
        bool done = false;
        public FormDb()
        {
            InitializeComponent();
            images = new List<Image<Gray, byte>>();
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
                if(cnter == 50)
                {
                    timer.Stop();
                    MessageBox.Show("Scanning is done", "Info", MessageBoxButtons.OK);
                }

                Mat takenImage = video.QueryFrame().Clone();
                
                imgBox_BgrFace.Image = takenImage.ToImage<Bgr, byte>().Resize(240,180,Emgu.CV.CvEnum.Inter.Cubic);

                Rectangle[] rectangles = classifier.DetectMultiScale(takenImage, 1.1, 4);

                if (rectangles.Count() > 0)
                {
                    images.Add(takenImage.ToImage<Gray,byte>().Resize(240,180,Emgu.CV.CvEnum.Inter.Cubic));
                    ++cnter;
                    txtBox_Counter.Text = cnter.ToString();
                }
            
         }

        private void btnScan_Click(object sender, EventArgs e)
        {
            images.Clear();
            cnter = 0;
            timer.Start();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBox_FirstName.Text) ||
                string.IsNullOrEmpty(txtBox_LastName.Text))
            {
                MessageBox.Show("Add first and last name", "Info", MessageBoxButtons.OK);
                return;
            }
           
            if(images.Count == 0)
            {
                MessageBox.Show("Do scanning first", "Info", MessageBoxButtons.OK);
                return;
            }

            bool result = recognitionDB.AddImagesToDb(images.ToArray(), txtBox_FirstName.Text, txtBox_LastName.Text);

            if (!result)
            {
                MessageBox.Show("User is not found", "Info", MessageBoxButtons.OK);
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtBox_FirstName.Text) || string.IsNullOrEmpty(txtBox_LastName.Text))
            {
                MessageBox.Show("Fields are empty", "Info", MessageBoxButtons.OK);
                return;
            }
            recognitionDB.AddUser(txtBox_FirstName.Text, txtBox_LastName.Text);

        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            Mat mat = null;

            while (true)
            {
                mat = video.QueryFrame().Clone();
                Rectangle[] rectangles = classifier.DetectMultiScale(mat, 1.1, 4);

                if (rectangles.Count() > 0)
                    break;
            }
            string result = recognitionDB.Predict(mat.ToImage<Gray, byte>().Resize(240, 180, Emgu.CV.CvEnum.Inter.Cubic));
            if (string.IsNullOrEmpty(result))
            {
                MessageBox.Show("Not found", "Info", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("The person is : " + result, "Info", MessageBoxButtons.OK);
            }
        }
        private void btnTrain_Click(object sender, EventArgs e)
        {
            recognitionDB.TrainImages();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Logs frm = new frm_Logs()
            {
                AutoScroll = false,
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                WindowState = FormWindowState.Maximized
            };
            this.Controls.Add(frm);
            frm.Show();
        }
    }
}
