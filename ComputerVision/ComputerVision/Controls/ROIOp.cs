using Emgu.CV;
using Emgu.CV.UI;
using System.Text.RegularExpressions;

namespace ComputerVision.Controls
{
    public partial class ROIOp : UserControl
    {
        Mat inMat, outMat;
        string inMatName;

        public ROIOp()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            inMatName = "";
        }

        private void AImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;

            inMat = CvInvoke.Imread(openFileDialog.FileName);
            inMatName = Regex.Match(openFileDialog.FileName, @"\\([a-zA-Z0-9-]*).png").Groups[1].Value;

            imgBox.Image = inMat;

            XTextBox.Text = "0";
            YTextBox.Text = "0";
            WidthTextBox.Text = inMat.Width.ToString();
            HeightTextBox.Text = inMat.Height.ToString();

            XTrackbar.Maximum = inMat.Width;
            XTrackbar.Value = 0;
            YTrackbar.Maximum = inMat.Height;
            YTrackbar.Value = 0;
            WidthTrackbar.Maximum = inMat.Width;
            WidthTrackbar.Value = inMat.Width;
            HeightTrackbar.Maximum = inMat.Height;
            HeightTrackbar.Value = inMat.Height;

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            outMat = new Mat(inMat, new Rectangle(XTrackbar.Value, YTrackbar.Value, WidthTrackbar.Value, HeightTrackbar.Value));

            OutImgBox.Image = outMat;
        }

        private void XTrackbar_Scroll(object sender, EventArgs e)
        {
            if (XTrackbar.Value + WidthTrackbar.Value > inMat.Width)
            {
                XTrackbar.Value = inMat.Width - WidthTrackbar.Value;
                return;
            }
            XTextBox.Text = XTrackbar.Value.ToString();
            UpdateOutput();
        }

        private void YTrackbar_Scroll(object sender, EventArgs e)
        {
            if (YTrackbar.Value + HeightTrackbar.Value > inMat.Height)
            {
                YTrackbar.Value = inMat.Height - HeightTrackbar.Value;
                return;
            }
            YTextBox.Text = YTrackbar.Value.ToString();
            UpdateOutput();
        }

        private void WidthTrackbar_Scroll(object sender, EventArgs e)
        {
            if (WidthTrackbar.Value + XTrackbar.Value > inMat.Width)
            {
                WidthTrackbar.Value = inMat.Width - XTrackbar.Value;
                return;
            }
            WidthTextBox.Text = WidthTrackbar.Value.ToString();
            UpdateOutput();
        }

        private void HeightTrackbar_Scroll(object sender, EventArgs e)
        {
            if (HeightTrackbar.Value + YTrackbar.Value > inMat.Height)
            {
                HeightTrackbar.Value = inMat.Height - YTrackbar.Value;
                return;
            }
            HeightTextBox.Text = HeightTrackbar.Value.ToString();
            UpdateOutput();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = inMatName + "ROI.png";

            if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

            try
            {
                CvInvoke.Imwrite(saveFileDialog.FileName, outMat);
            }
            catch { }
        }
    }
}