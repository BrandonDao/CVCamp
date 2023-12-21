namespace ComputerVision.Controls
{
    partial class RotateFlipOp
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
            label1 = new Label();
            OpComboBox = new ComboBox();
            SaveButton = new Button();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            SuspendLayout();
            // 
            // AImgBox
            // 
            InImgBox.BorderStyle = BorderStyle.FixedSingle;
            InImgBox.Location = new Point(3, 3);
            InImgBox.Name = "AImgBox";
            InImgBox.Size = new Size(150, 150);
            InImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InImgBox.TabIndex = 2;
            InImgBox.TabStop = false;
            InImgBox.Click += InImgBox_Click;
            // 
            // BImgBox
            // 
            OutImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutImgBox.Location = new Point(211, 3);
            OutImgBox.Name = "BImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(161, 58);
            label1.Name = "label1";
            label1.Size = new Size(46, 37);
            label1.TabIndex = 4;
            label1.Text = "->";
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(20, 159);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(121, 23);
            OpComboBox.TabIndex = 5;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(250, 158);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // RotateOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(OpComboBox);
            Controls.Add(label1);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "RotateOp";
            Size = new Size(365, 186);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private Label label1;
        private ComboBox OpComboBox;
        private Button SaveButton;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
    }
}
