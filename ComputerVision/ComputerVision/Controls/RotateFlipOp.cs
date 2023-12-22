using Emgu.CV;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public struct OpInfo
    {
        public string Name;

        public Action<Mat, Mat> Operation;

        public OpInfo(string name, Action<Mat, Mat> operation)
        {
            Name = name;
            Operation = operation;
        }

        public override readonly string ToString() => Name;
    }

    public partial class RotateFlipOp : UserControl
    {
        private Mat inMat;
        private readonly Mat outMat;

        public RotateFlipOp()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            OpComboBox.Items.AddRange(new object[]
            {
                new OpInfo("Rotate 90 ⟳ C", (a, c) => CvInvoke.Rotate(a, c, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise)),
                new OpInfo("Rotate 90 ⟲ CC", (a, c) => CvInvoke.Rotate(a, c, Emgu.CV.CvEnum.RotateFlags.Rotate90CounterClockwise)),
                new OpInfo("Rotate 180", (a, c) => CvInvoke.Rotate(a, c, Emgu.CV.CvEnum.RotateFlags.Rotate180)),
                new OpInfo("Flip Horizontally", (a, c) => CvInvoke.Flip(a, c, Emgu.CV.CvEnum.FlipType.Horizontal)),
                new OpInfo("Flip Vertically", (a, c) => CvInvoke.Flip(a, c, Emgu.CV.CvEnum.FlipType.Vertical)),
                new OpInfo("Flip Both", (a, c) => CvInvoke.Flip(a, c, Emgu.CV.CvEnum.FlipType.Both)),
            });

            OpComboBox.SelectedIndex = 0;
        }

        private void UpdateOutput()
        {
            var opInfo = (OpInfo)OpComboBox.SelectedItem;

            try
            {
                opInfo.Operation.Invoke(inMat, outMat);
                OutImgBox.Image = outMat;
            }
            catch { }
        }

        private void InImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;
            inMat = CvInvoke.Imread(openFileDialog.FileName);

            imgBox.Image = inMat;

            UpdateOutput();
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
