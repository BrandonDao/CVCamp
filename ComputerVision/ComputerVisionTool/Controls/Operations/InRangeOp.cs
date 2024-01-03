using ComputerVisionTool;
using ComputerVisionTool.Controls.Operations;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace ComputerVision.Controls
{
    public partial class InRangeOp : UserControl, IOperation
    {
        public CVToolsForm ContainerForm { get; set; }

        private ScalarArray? lowerBound;
        private ScalarArray? upperBound;

        public InRangeOp(Control parent, Point location, CVToolsForm containerForm)
        {
            Parent = parent;
            Location = location;
            ContainerForm = containerForm;

            InitializeComponent();

            upperBound = new ScalarArray(0);
            UpdateLowerBound();
            UpdateUpperBound();
        }

        public void UpdateAll()
        {
            InputImg.UpdateNamedInputs();
            UpdateOutput();
        }

        private void UpdateLowerBound()
        {
            var newBound = new MCvScalar(TLTrackbar.Value, MLTrackbar.Value, BLTrackbar.Value);
            Mat previewMat = new(100, 100, DepthType.Cv8U, channels: 3);
            
            if(HSVFormatCheckbox.Checked)
            {
                previewMat.SetTo(new MCvScalar(TLTrackbar.Value, 255, 255));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                TLImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(TLTrackbar.Value, MLTrackbar.Value, 255));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                MLImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, 0, BLTrackbar.Value));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                BLImgBox.Image = previewMat;

                previewMat.SetTo(newBound);
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                LOutputImgBox.Image = previewMat;
            }
            else
            {
                previewMat.SetTo(new MCvScalar(TLTrackbar.Value, 0, 0));
                TLImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, MLTrackbar.Value, 0));
                MLImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, 0, BLTrackbar.Value));
                BLImgBox.Image = previewMat;

                previewMat.SetTo(newBound);
                LOutputImgBox.Image = previewMat;
            }

            lowerBound = (ScalarArray)newBound;
            UpdateOutput();
        }

        private void UpdateUpperBound()
        {
            var newBound = new MCvScalar(TRTrackbar.Value, MRTrackbar.Value, BRTrackbar.Value);
            Mat previewMat = new(100, 100, DepthType.Cv8U, channels: 3);

            if (HSVFormatCheckbox.Checked)
            {
                previewMat.SetTo(new MCvScalar(TRTrackbar.Value, 255, 255));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                TRImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(TRTrackbar.Value, MRTrackbar.Value, 255));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                MRImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, 0, BRTrackbar.Value));
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                BRImgBox.Image = previewMat;

                previewMat.SetTo(newBound);
                CvInvoke.CvtColor(previewMat, previewMat, ColorConversion.Hsv2Bgr);
                ROutputImgBox.Image = previewMat;
            }
            else
            {
                previewMat.SetTo(new MCvScalar(TRTrackbar.Value, 0, 0));
                TRImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, MRTrackbar.Value, 0));
                MRImgBox.Image = previewMat;

                previewMat.SetTo(new MCvScalar(0, 0, BRTrackbar.Value));
                BRImgBox.Image = previewMat;

                previewMat.SetTo(newBound);
                ROutputImgBox.Image = previewMat;
            }

            upperBound = (ScalarArray)newBound;
            UpdateOutput();
        }

        private void UpdateOutput()
        {
            try
            {
                CvInvoke.InRange(InputImg.Mat, lowerBound, upperBound, OutputImg.Mat);
            }
            catch { }

            OutputImg.UpdateImage();
        }

        private void TLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();
        private void MLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();
        private void BLTrackbar_Scroll(object sender, EventArgs e) => UpdateLowerBound();

        private void TRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();
        private void MRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();
        private void BRTrackbar_Scroll(object sender, EventArgs e) => UpdateUpperBound();

        private void HSVFormatCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            TLTrackbar.Maximum = HSVFormatCheckbox.Checked ? 179 : 255;
            TRTrackbar.Maximum = HSVFormatCheckbox.Checked ? 179 : 255;

            UpdateLowerBound();
            UpdateUpperBound();
        }
    }
}