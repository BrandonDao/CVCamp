namespace ComputerVision
{
    partial class BitwiseOp
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
            AImgBox = new Emgu.CV.UI.ImageBox();
            BImgBox = new Emgu.CV.UI.ImageBox();
            CImgBox = new Emgu.CV.UI.ImageBox();
            label1 = new Label();
            OpComboBox = new ComboBox();
            openfileDialog = new OpenFileDialog();
            AutoNameCheckbox = new CheckBox();
            SaveButton = new Button();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)AImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CImgBox).BeginInit();
            SuspendLayout();
            // 
            // AImgBox
            // 
            AImgBox.BorderStyle = BorderStyle.FixedSingle;
            AImgBox.Location = new Point(3, 3);
            AImgBox.Name = "AImgBox";
            AImgBox.Size = new Size(150, 150);
            AImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            AImgBox.TabIndex = 2;
            AImgBox.TabStop = false;
            AImgBox.Tag = 0;
            AImgBox.Click += AImgBox_Click;
            // 
            // BImgBox
            // 
            BImgBox.BorderStyle = BorderStyle.FixedSingle;
            BImgBox.Location = new Point(159, 3);
            BImgBox.Name = "BImgBox";
            BImgBox.Size = new Size(150, 150);
            BImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BImgBox.TabIndex = 3;
            BImgBox.TabStop = false;
            BImgBox.Tag = 1;
            BImgBox.Click += BImgBox_Click;
            // 
            // CImgBox
            // 
            CImgBox.BorderStyle = BorderStyle.FixedSingle;
            CImgBox.Location = new Point(367, 3);
            CImgBox.Name = "CImgBox";
            CImgBox.Size = new Size(150, 150);
            CImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CImgBox.TabIndex = 4;
            CImgBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(315, 62);
            label1.Name = "label1";
            label1.Size = new Size(46, 37);
            label1.TabIndex = 5;
            label1.Text = "->";
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(93, 159);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(121, 23);
            OpComboBox.TabIndex = 6;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // openfileDialog
            // 
            openfileDialog.FileName = "openFileDialog";
            // 
            // AutoNameCheckbox
            // 
            AutoNameCheckbox.AutoSize = true;
            AutoNameCheckbox.Checked = true;
            AutoNameCheckbox.CheckState = CheckState.Checked;
            AutoNameCheckbox.Location = new Point(358, 161);
            AutoNameCheckbox.Name = "AutoNameCheckbox";
            AutoNameCheckbox.Size = new Size(159, 19);
            AutoNameCheckbox.TabIndex = 7;
            AutoNameCheckbox.Text = "Auto-Name Saved Image";
            AutoNameCheckbox.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(277, 159);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // BitwiseOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(AutoNameCheckbox);
            Controls.Add(OpComboBox);
            Controls.Add(label1);
            Controls.Add(CImgBox);
            Controls.Add(BImgBox);
            Controls.Add(AImgBox);
            Name = "BitwiseOp";
            Size = new Size(521, 190);
            ((System.ComponentModel.ISupportInitialize)AImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox AImgBox;
        private Emgu.CV.UI.ImageBox BImgBox;
        private Emgu.CV.UI.ImageBox CImgBox;
        private Label label1;
        private ComboBox OpComboBox;
        private OpenFileDialog openfileDialog;
        private CheckBox AutoNameCheckbox;
        private Button SaveButton;
        private SaveFileDialog saveFileDialog;
    }
}
