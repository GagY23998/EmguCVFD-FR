using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using Emgu;
using Emgu.CV;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Windows.Forms;
using System.IO;
using Emgu.CV.Util;
using Microsoft.EntityFrameworkCore;

namespace EmguProject
{
    public class FaceRecognitionDB
    {
        const double threshold = double.PositiveInfinity;
        EigenFaceRecognizer faceRecognizer = new EigenFaceRecognizer(80,threshold);
        AppDbContext _context;
        public static bool isTrained = false;
        public FaceRecognitionDB()
        {
            _context = new AppDbContext();
        }

        /*
         Functions:
         1. Add Images
         2. Save to Database
         3. Train
         4.Predict
         */
        public bool AddImagesToDb(Image<Gray,byte>[]images,string FirstName,string LastName)
        {
            if (!images.All(_ => _.Size.Width == 240 && _.Size.Height == 180)) return false;
            var user = _context.Users.FirstOrDefault(_ => _.FirstName == FirstName && _.LastName == LastName);
            if (user == null) return false;

            string path =  Application.StartupPath + @"/../../Images/" + user.FirstName +"-" + user.LastName+"/";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            int totalLabels = 0;
            if (_context.Labels.Count() != 0)
            {
             totalLabels = _context.Labels.Max(_ => _.LabelNumber);
            }


            foreach (var image in images)
            {
                string imagePath = path + string.Concat(user.FirstName, "-", user.LastName, "-", "image", "-", (totalLabels + 1).ToString(),".jpg");
                DAL.Models.Label label = new DAL.Models.Label { LabelNumber = totalLabels + 1, UserId = user.Id };
                _context.Labels.Add(label);
                _context.SaveChanges();
                image.Save(imagePath);
                ++totalLabels;
            }
            
            _context.Update(user);
            _context.SaveChanges();

            return true;

        }

        public string Predict(Image<Gray, byte> image)
        {
            
                faceRecognizer.Read(Application.StartupPath + @"/../../Images/faceRecognizer.yml");
                var res =faceRecognizer.Predict(image);
                DAL.Models.Label label = null;
                //if(res.Distance > threshold)
                if(res.Distance<5000)
                {
                   label = _context.Labels.FirstOrDefault(_=>_.LabelNumber == res.Label);
                    var user = _context.Users.FirstOrDefault(_ => _.Id == label.UserId);
                   return user.FirstName + " " + user.LastName;
                }

            return string.Empty;
        }

        public void  TrainImages()
        { 

            string path = Application.StartupPath + @"/../../Images/";

            string[] files = Directory.GetFiles(path, "*.jpg", SearchOption.AllDirectories);
            //   int[] labelsDb = _context.Labels.Select(_ => _.LabelNumber).ToArray();
            List<int> labelsDb = new List<int>();
            Mat[] matImages = new Mat[files.Length];



            for (int i = 0; i < files.Length; i++)
            {
                matImages[i] = new Image<Gray, byte>(files[i]).Mat;
                string[] strings = files[i].Split('-');
                string number = strings[strings.Length - 1].Split('.')[0];
                labelsDb.Add(int.Parse(number));
            }

           
            VectorOfMat images = new VectorOfMat(matImages);
            VectorOfInt labels = new VectorOfInt(labelsDb.ToArray());
            faceRecognizer.Train(images, labels);
            faceRecognizer.Write(Application.StartupPath +@"/../../Images/faceRecognizer.yml");
            isTrained = true;
           
        }
        
        public bool AddUser(string firstName, string lastName)
        {
            if (_context.Users.Any(_ => _.FirstName == firstName && _.LastName == lastName)) return false;

            _context.Users.Add(new DAL.Models.User
            {
                FirstName = firstName,
                LastName = lastName,
            });
            _context.SaveChanges();
            return true;
        }


    }
}
