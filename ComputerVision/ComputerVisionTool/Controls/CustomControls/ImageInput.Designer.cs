namespace ComputerVisionTool.Controls.CustomControls
{
    partial class ImageInput
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ImageBox = new Emgu.CV.UI.ImageBox();
            NamedInputComboBox = new ComboBox();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.FixedSingle;
            ImageBox.Location = new Point(3, 32);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(150, 150);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 2;
            ImageBox.TabStop = false;
            ImageBox.Click += ImageBox_Click;
            // 
            // NamedInputComboBox
            // 
            NamedInputComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            NamedInputComboBox.FormattingEnabled = true;
            NamedInputComboBox.Location = new Point(3, 3);
            NamedInputComboBox.Name = "NamedInputComboBox";
            NamedInputComboBox.Size = new Size(150, 23);
            NamedInputComboBox.TabIndex = 3;
            NamedInputComboBox.SelectedIndexChanged += NamedInputComboBox_SelectedIndexChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // ImageInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NamedInputComboBox);
            Controls.Add(ImageBox);
            Name = "ImageInput";
            Size = new Size(156, 184);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox ImageBox;
        private ComboBox NamedInputComboBox;
        private OpenFileDialog openFileDialog;
    }
}