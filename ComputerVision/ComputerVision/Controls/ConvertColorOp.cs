using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;

namespace ComputerVision.Controls
{
    public partial class ConvertColorOp : UserControl
    {
        public struct ConversionInfo
        {
            public string Name;

            public ColorConversion ConversionType;

            public ConversionInfo(string name, ColorConversion conversionType)
            {
                Name = name;
                ConversionType = conversionType;
            }

            public override readonly string ToString() => Name;
        }

        Mat inMat;
        readonly Mat outMat;

        public ConvertColorOp()
        {
            InitializeComponent();

            inMat = new Mat();
            outMat = new Mat();

            ConversionComboBox.Items.AddRange(new object[]
            {
                new ConversionInfo("BGR -> HSV", ColorConversion.Bgr2Hsv),
                new ConversionInfo("BGR -> Grayscale", ColorConversion.Bgr2Gray),
                new ConversionInfo("HSV -> BGR", ColorConversion.Hsv2Bgr),
            });

            ConversionComboBox.SelectedIndex = 0;
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
            try
            {
                CvInvoke.CvtColor(inMat, outMat, ((ConversionInfo)ConversionComboBox.SelectedItem).ConversionType);
                OutImgBox.Image = outMat;
            }
            catch { }
        }

        private void ConversionComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
