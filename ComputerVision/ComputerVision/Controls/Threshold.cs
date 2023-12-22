using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public partial class Threshold : UserControl
    {
        struct OpInfo
        {
            public string Name;

            public ThresholdType ThresholdType;

            public OpInfo(string name, ThresholdType thresholdType)
            {
                Name = name;
                ThresholdType = thresholdType;
            }

            public override readonly string ToString() => Name;
        }

        private Mat inMat;
        private readonly Mat outMat;

        public Threshold()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            OpComboBox.Items.AddRange(new object[]
            {
                new OpInfo("Binary", ThresholdType.Binary),
                new OpInfo("Binary Inverse", ThresholdType.BinaryInv),
                new OpInfo("Truncate", ThresholdType.Trunc),
                new OpInfo("To Zero", ThresholdType.ToZero),
                new OpInfo("To Zero Inverse", ThresholdType.ToZeroInv),
                new OpInfo("Mask", ThresholdType.Mask),
            });

            OpComboBox.SelectedIndex = 0;
        }

        private void InImgBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;

            inMat = CvInvoke.Imread(openFileDialog.FileName);

            imgBox.Image = inMat;

            UpdateOutput();
        }

        private void UpdateOutput()
        {
            CvInvoke.Threshold(inMat, outMat, ThresholdTrackbar.Value, ValueTrackbar.Value, ((OpInfo)OpComboBox.SelectedItem).ThresholdType);
            OutImgBox.Image = outMat;
        }

        private void ThresholdTrackbar_Scroll(object sender, EventArgs e)
            => UpdateOutput();

        private void ValueTrackbar_Scroll(object sender, EventArgs e)
            => UpdateOutput();

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
