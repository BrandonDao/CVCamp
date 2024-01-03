using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;
using Emgu.CV.Util;

namespace ComputerVision.Controls
{
    public partial class CaptureContours : UserControl
    {
        private Mat inMat, grayInMat, outMat;

        public CaptureContours()
        {
            InitializeComponent();
        }

        private void InImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;

            inMat = CvInvoke.Imread(openFileDialog.FileName);
            outMat = inMat.Clone();

            imgBox.Image = inMat;

            grayInMat = new Mat();
            CvInvoke.CvtColor(inMat, grayInMat, ColorConversion.Bgr2Gray);

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            VectorOfVectorOfPoint contours = new();
            Mat heirarchy = new();
            CvInvoke.FindContours(grayInMat, contours, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            CvInvoke.DrawContours(outMat, contours, -1, new MCvScalar(0, 0, 255), 2);

            OutImgBox.Image = outMat;
        }
    }
}