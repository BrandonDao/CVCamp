using Emgu.CV;

namespace ComputerVisionTool.Controls.CustomControls
{
    public partial class ImageInput : UserControl
    {
        public Mat? Mat { get; private set; }
        public OperationInfo? OpInfo { get; set; }
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
            // NamedInputComboBox.Items.Add(NamedInput.NoInput);

            areNamedUpdatesDisabaled = true;

            int i = 0;
            foreach (NamedInput namedInput in NameManager.NamedInputsByImage.Values)
            {
                if (namedInput.ImageOutput.OpInfo!.ID >= OpInfo!.ID) continue;

                NamedInputComboBox.Items.Add(namedInput);

                if(namedInput == selectedNamedInput)
                {
                    NamedInputComboBox.SelectedIndex = i;
                }

                i++;
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

            ((Form1)Parent.Parent).UpdateAll();
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
            ((Form1)Parent.Parent).UpdateAll();
        }
    }
}