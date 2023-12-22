using Emgu.CV;
using Emgu.CV.Reg;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public partial class CopyToOp : UserControl
    {
        private Mat aMat, bMat, maskMat, outMat;

        public CopyToOp()
        {
            InitializeComponent();

            aMat = new Mat();
            bMat = new Mat();
            outMat = new Mat();
        }

        private void AImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            aMat = CvInvoke.Imread(openFileDialog.FileName);

            AImgBox.Image = aMat;

            UpdateOutput();
        }
        private void BImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            bMat = CvInvoke.Imread(openFileDialog.FileName);

            BImgBox.Image = bMat;

            UpdateOutput();
        }

        private void MaskImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            maskMat = CvInvoke.Imread(openFileDialog.FileName);

            MaskImgBox.Image = maskMat;

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            outMat = bMat.Clone();

            if (MaskCheckbox.Checked)
            {
                aMat.CopyTo(outMat, maskMat);
            }
            else
            {
                aMat.CopyTo(outMat);
            }
            OutputImgBox.Image = outMat;
        }

        private void MaskCheckbox_CheckedChanged(object sender, EventArgs e)
            => UpdateOutput();

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
