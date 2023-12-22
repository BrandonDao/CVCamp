using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public partial class InRange : UserControl
    {
        Mat inMat;
        readonly Mat outMat;

        public InRange()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

        }

        private void InImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;
            inMat = CvInvoke.Imread(openFileDialog.FileName);
            //CvInvoke.CvtColor(inMat, inMat, Emgu.CV.CvEnum.ColorConversion.Bgr2Hsv);

            imgBox.Image = inMat;

            UpdateOutput();
        }

        void UpdateOutput()
        {
            try
            {
                CvInvoke.InRange(inMat,
                    (ScalarArray)new MCvScalar(
                        TopLowerTrackbar.Value,
                        MidLowerTrackbar.Value,
                        BottomLowerTrackbar.Value),
                    (ScalarArray)new MCvScalar(
                        TopUpperTrackbar.Value,
                        MidUpperTrackbar.Value,
                        BottomUpperTrackbar.Value),
                    outMat);
            }
            catch { }

            Up1ImgBox.BackColor = Color.FromArgb(TopUpperTrackbar.Value, 0, 0);
            Up2ImgBox.BackColor = Color.FromArgb(0, MidUpperTrackbar.Value, 0);
            Up3ImgBox.BackColor = Color.FromArgb(0, 0, BottomUpperTrackbar.Value);
            Up4ImgBox.BackColor = Color.FromArgb(
                TopUpperTrackbar.Value,
                MidUpperTrackbar.Value,
                BottomUpperTrackbar.Value);

            Low1ImgBox.BackColor = Color.FromArgb(TopLowerTrackbar.Value, 0, 0);
            Low2ImgBox.BackColor = Color.FromArgb(0, MidLowerTrackbar.Value, 0);
            Low3ImgBox.BackColor = Color.FromArgb(0, 0, BottomLowerTrackbar.Value);
            Low4ImgBox.BackColor = Color.FromArgb(
                TopLowerTrackbar.Value,
                MidLowerTrackbar.Value,
                BottomLowerTrackbar.Value);


            OutImgBox.Image = outMat;
        }

        private void TopUpperTrackbar_Scroll(object sender, EventArgs e)
        {
            if (TopUpperTrackbar.Value < TopLowerTrackbar.Value)
            {
                TopLowerTrackbar.Value = TopUpperTrackbar.Value;
            }

            UpdateOutput();
        }
        private void TopLowerTrackbar_Scroll(object sender, EventArgs e)
        {
            if (TopLowerTrackbar.Value > TopUpperTrackbar.Value)
            {
                TopUpperTrackbar.Value = TopLowerTrackbar.Value;
            }

            UpdateOutput();
        }

        private void MidUpperTrackbar_Scroll(object sender, EventArgs e)
        {
            if (MidUpperTrackbar.Value < MidLowerTrackbar.Value)
            {
                MidLowerTrackbar.Value = MidUpperTrackbar.Value;
            }

            UpdateOutput();
        }
        private void MidLowerTrackbar_Scroll(object sender, EventArgs e)
        {
            if (MidLowerTrackbar.Value > MidUpperTrackbar.Value)
            {
                MidUpperTrackbar.Value = MidLowerTrackbar.Value;
            }

            UpdateOutput();
        }

        private void BottomUpperTrackbar_Scroll(object sender, EventArgs e)
        {
            if (BottomUpperTrackbar.Value < BottomLowerTrackbar.Value)
            {
                BottomLowerTrackbar.Value = BottomUpperTrackbar.Value;
            }
            UpdateOutput();
        }
        private void BottomLowerTrackbar_Scroll(object sender, EventArgs e)
        {
            if (BottomLowerTrackbar.Value > BottomUpperTrackbar.Value)
            {
                BottomUpperTrackbar.Value = BottomLowerTrackbar.Value;
            }

            UpdateOutput();
        }

        private void ConvertToHSVButton_Click(object sender, EventArgs e)
        {
            TopUpperTrackbar.Maximum = 179;
            TopLowerTrackbar.Maximum = 179;
            MidUpperTrackbar.Maximum = 100;
            MidLowerTrackbar.Maximum = 100;
            BottomUpperTrackbar.Maximum = 100;
            BottomLowerTrackbar.Maximum = 100;

            label1.Text = "Hue";
            label2.Text = "Saturation";
            label3.Text = "Value";

            UpdateOutput();
        }

        private void ConvertToRGBButton_Click(object sender, EventArgs e)
        {
            TopUpperTrackbar.Maximum = 255;
            TopLowerTrackbar.Maximum = 255;
            MidUpperTrackbar.Maximum = 255;
            MidLowerTrackbar.Maximum = 255;
            BottomUpperTrackbar.Maximum = 255;
            BottomLowerTrackbar.Maximum = 255;

            label1.Text = "Red";
            label2.Text = "Green";
            label3.Text = "Blue";

            UpdateOutput();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "image.png";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                CvInvoke.Imwrite(saveFileDialog.FileName, outMat);
            }
            catch { }
        }
    }
}