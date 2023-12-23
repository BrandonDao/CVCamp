using Emgu.CV;

namespace Pong
{
    public partial class Form1 : Form
    {

        VideoCapture videoCapture;
        Mat currentFrame;
        Mat capturedFrame;
        Mat inRangeMat;

        Mat lowerBound;
        Mat upperBound;

        Mat dilateErodeElement;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            videoCapture = new VideoCapture(0);

            inRangeMat = new Mat();
            dilateErodeElement = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Ellipse, new Size(3, 3), new Point(-1, -1));

            Application.Idle += GetFrame;
        }

        private void GetFrame(object sender, EventArgs e)
        {
            currentFrame = videoCapture.QueryFrame();

            if (isMirroredCheckbox.Checked)
            {
                CvInvoke.Flip(currentFrame, currentFrame, Emgu.CV.CvEnum.FlipType.Horizontal);
            }

            if (currentFrame == null) return;

            CameraImgBox.Image = currentFrame;

            if (capturedFrame == null) return;

            CvInvoke.InRange(currentFrame, lowerBound, upperBound, inRangeMat);
            InRangeImgBox.Image = inRangeMat;

            //CvInvoke.Dilate(inRangeMat, inRangeMat, dilateErodeElement, BorderType)
        }

        private void CaptureButton_Click(object sender, EventArgs e)
        {
            capturedFrame = currentFrame.Clone();
            CaptureImgBox.Image = capturedFrame;

            lowerBound = capturedFrame - VarianceTrackbar.Value;
            upperBound = capturedFrame + VarianceTrackbar.Value;
        }

        private void VarianceTrackbar_Scroll(object sender, EventArgs e)
        {
            if (capturedFrame == null) return;

            lowerBound = capturedFrame - VarianceTrackbar.Value;
            upperBound = capturedFrame + VarianceTrackbar.Value;
        }
    }
}