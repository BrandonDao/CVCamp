using ComputerVisionTool.Controls.Operations;
using Emgu.CV;

namespace ComputerVisionTool.Controls.CustomControls
{
    public partial class ImageInput : UserControl
    {
        public Mat? Mat { get; private set; }

        private bool areNamedUpdatesDisabaled;

        public ImageInput()
        {
            InitializeComponent();

            Mat = new Mat();
        }

        public void UpdateNamedInputs()
        {
            if (areNamedUpdatesDisabaled) return;

            var selectedNamedInput = (NamedInput)NamedInputComboBox.SelectedItem;
            NamedInputComboBox.Items.Clear();

            areNamedUpdatesDisabaled = true;

            int currIndex = 0;
            foreach (NamedInput namedInput in NameManager.NamedInputsByImage.Values)
            {
                if (((IOperation)namedInput.ImageOutput.Parent).OpInfo!.ID >= ((IOperation)Parent).OpInfo!.ID) continue;

                NamedInputComboBox.Items.Add(namedInput);

                if (namedInput == selectedNamedInput)
                {
                    NamedInputComboBox.SelectedIndex = currIndex;
                }

                currIndex++;
            }
            areNamedUpdatesDisabaled = false;

            UpdateImage();
        }

        private void ImageBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel) return;

            NamedInputComboBox.SelectedIndex = -1;
            Mat = CvInvoke.Imread(openFileDialog.FileName);

            ImageBox.Image = Mat;

            ((IOperation)Parent).ContainerForm.UpdateAll();
        }

        private void UpdateImage()
        {
            if (NamedInputComboBox.SelectedItem == null) return;

            Mat = ((NamedInput)NamedInputComboBox.SelectedItem).ImageOutput.Mat;
            ImageBox.Image = Mat;
        }

        private void NamedInputComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNamedInputs();
            ((IOperation)Parent).ContainerForm.UpdateAll();
        }
    }
}