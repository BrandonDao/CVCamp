using Emgu.CV;
using Emgu.CV.CvEnum;

namespace ComputerVision.Controls
{
    public partial class BlurOp : UserControl
    {
        public struct BorderInfo
        {
            public string Name;

            public BorderType BorderType;

            public BorderInfo(string name, BorderType borderType)
            {
                Name = name;
                BorderType = borderType;
            }

            public override string ToString() => Name;
        }

        Mat inMat;
        readonly Mat outMat;

        public BlurOp()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            BorderTypeComboBox.Items.AddRange(new object[]
            {
                new BorderInfo("Isolated", BorderType.Replicate),
                new BorderInfo("Reflect", BorderType.Reflect),
                new BorderInfo("Wrap", BorderType.Wrap),
                new BorderInfo("Reflect101 (Default)", BorderType.Reflect101),
                new BorderInfo("Transparent", BorderType.Transparent),
                new BorderInfo("Isolated", BorderType.Isolated),
            });

            BorderTypeComboBox.SelectedIndex = 3;
        }

        private void InImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            inMat = CvInvoke.Imread(openFileDialog.FileName);
            InImgBox.Image = inMat;

            UpdateOutput();
        }

        private void KernelXTrackbar_Scroll(object sender, EventArgs e)
            => UpdateOutput();
        private void KernelYTrackbar_Scroll(object sender, EventArgs e)
            => UpdateOutput();

        private void UpdateOutput()
        {
            try
            {
                CvInvoke.Blur(inMat, outMat,
                    new Size(KernelXTrackbar.Value, KernelYTrackbar.Value),
                    new Point(-1, -1),
                    ((BorderInfo)BorderTypeComboBox.SelectedItem).BorderType);
            }
            catch { }

            OutImgBox.Image = outMat;
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

        private void OpTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateOutput();
    }
}
