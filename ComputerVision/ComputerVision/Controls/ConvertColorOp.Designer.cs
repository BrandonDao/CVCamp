namespace ComputerVision.Controls
{
    partial class ConvertColorOp
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
            InImgBox = new Emgu.CV.UI.ImageBox();
            OutImgBox = new Emgu.CV.UI.ImageBox();
            ConversionComboBox = new ComboBox();
            SaveButton = new Button();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            SuspendLayout();
            // 
            // InImgBox
            // 
            InImgBox.BorderStyle = BorderStyle.FixedSingle;
            InImgBox.Location = new Point(3, 3);
            InImgBox.Name = "InImgBox";
            InImgBox.Size = new Size(150, 150);
            InImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InImgBox.TabIndex = 2;
            InImgBox.TabStop = false;
            InImgBox.Click += InImgBox_Click;
            // 
            // OutImgBox
            // 
            OutImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutImgBox.Location = new Point(159, 3);
            OutImgBox.Name = "OutImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // ConversionComboBox
            // 
            ConversionComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ConversionComboBox.FormattingEnabled = true;
            ConversionComboBox.Location = new Point(15, 159);
            ConversionComboBox.Name = "ConversionComboBox";
            ConversionComboBox.Size = new Size(121, 23);
            ConversionComboBox.TabIndex = 4;
            ConversionComboBox.SelectedIndexChanged += ConversionComboBox_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(197, 159);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // ConvertColorOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(ConversionComboBox);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "ConvertColorOp";
            Size = new Size(313, 188);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private ComboBox ConversionComboBox;
        private Button SaveButton;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
    }
}
