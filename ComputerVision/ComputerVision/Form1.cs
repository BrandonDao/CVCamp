using ComputerVision;

namespace CVExercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BackingFunctions.LoadDefaultMats();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackingFunctions.UpdateImageBoxes(LHSPictureBox, RHSPictureBox, outputPictureBox);
        }

        private void LHSPictureBox_DoubleClick(object sender, EventArgs e)
            => PictureBoxDoubleClick(sender);
        private void RHSPictureBox_DoubleClick(object sender, EventArgs e)
            => PictureBoxDoubleClick(sender);

        private void PictureBoxDoubleClick(object sender)
        {
            if (ImageSelectionDialog.ShowDialog() == DialogResult.Cancel) return;

            BackingFunctions.HandleImageSelection(sender, ImageSelectionDialog, LHSPictureBox, RHSPictureBox, outputPictureBox);
        }

        private void OperationDropdown_SelectionChangeCommitted(object sender, EventArgs e)
            => BackingFunctions.HandleOperationSelection(OperationDropdown.SelectedIndex, LHSPictureBox, RHSPictureBox, outputPictureBox);

        private void SaveOutputButton_Click(object sender, EventArgs e)
            => BackingFunctions.HandleSaveImage(AutoNameCheckbox.Checked);
    }
}