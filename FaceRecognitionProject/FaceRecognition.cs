using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.Util;
namespace EmguProject
{
    public class FaceRecognition
    {
        EigenFaceRecognizer eigenFace = new EigenFaceRecognizer();
        LBPHFaceRecognizer LBPHFace = new LBPHFaceRecognizer();
        FisherFaceRecognizer fisherFace = new FisherFaceRecognizer();

        public FaceRecognition()
        {
            
            
        }

    }
}
