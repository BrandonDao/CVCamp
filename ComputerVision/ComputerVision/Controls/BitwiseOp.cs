using Emgu.CV;
using Emgu.CV.UI;
using System.Text.RegularExpressions;

namespace ComputerVision
{
    public partial class BitwiseOp : UserControl
    {
        public struct OpInfo
        {
            public string Name;

            public Action<Mat, Mat, Mat> Operation;

            public OpInfo(string name, Action<Mat, Mat, Mat> operation)
            {
                Name = name;
                Operation = operation;
            }

            public override string ToString() => Name;
        }

        Mat aMat, bMat, cMat;
        string aMatName, bMatName;

        public BitwiseOp()
        {
            InitializeComponent();

            aMat = new Mat();
            bMat = new Mat();
            cMat = new Mat();

            aMatName = "";
            bMatName = "";

            OpComboBox.Items.AddRange(new object[]
            {
                new OpInfo("AND", (a, b, c) => CvInvoke.BitwiseAnd(a, b, c)),
                new OpInfo("OR", (a, b, c) => CvInvoke.BitwiseOr(a, b, c)),
                new OpInfo("XOR", (a, b, c) => CvInvoke.BitwiseXor(a, b, c)),
                new OpInfo("NOT", (a, _, c) => CvInvoke.BitwiseNot(a, c)),
            });

            OpComboBox.SelectedIndex = 0;
        }

        private void OpComboBox_SelectedIndexChanged(object sender, EventArgs e)
            => UpdateOutput();

        private void AImgBox_Click(object sender, EventArgs e)
            => HangleImgBoxClick(sender);
        private void BImgBox_Click(object sender, EventArgs e)
            => HangleImgBoxClick(sender);



        private void UpdateOutput()
        {
            var opInfo = (OpInfo)OpComboBox.SelectedItem;

            if (opInfo.Name == "NOT")
            {
                BImgBox.Hide();
            }
            else
            {
                BImgBox.Show();
            }

            try
            {
                opInfo.Operation.Invoke(aMat, bMat, cMat);
                CImgBox.Image = cMat;
            }
            catch { }
        }

        private void HangleImgBoxClick(object sender)
        {
            if (openfileDialog.ShowDialog() == DialogResult.Cancel) return;

            ImageBox imgBox = (ImageBox)sender;
            int tag = (int)imgBox.Tag;

            Mat selectedMat = CvInvoke.Imread(openfileDialog.FileName);
            string matName = Regex.Match(openfileDialog.FileName, @"\\([a-zA-Z0-9-]*).png").Groups[1].Value;

            switch (tag)
            {
                case 0: aMat = selectedMat; aMatName = matName; break;
                case 1: bMat = selectedMat; bMatName = matName; break;

                default: throw new ArgumentException($"unexpected sender tag!");
            }

            imgBox.Image = selectedMat;
            UpdateOutput();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string suggestedFileName;
            string? opName = OpComboBox.SelectedItem.ToString();

            if (opName == "NOT")
            {
                suggestedFileName = @$"NOT{aMatName}.png";
            }
            else
            {
                suggestedFileName = $@"{aMatName}{opName}{bMatName}.png";
            }

            if (AutoNameCheckbox.Checked)
            {
                CvInvoke.Imwrite(Constants.BasePath + suggestedFileName, cMat);
            }
            else
            {
                saveFileDialog.FileName = suggestedFileName;

                if (saveFileDialog.ShowDialog() == DialogResult.Cancel) return;

                try
                {
                    CvInvoke.Imwrite(saveFileDialog.FileName, cMat);
                }
                catch { }
            }
        }
    }
}
