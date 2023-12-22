namespace ComputerVision.Controls
{
    partial class CopyToOp
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
            label1 = new Label();
            label2 = new Label();
            OutputImgBox = new Emgu.CV.UI.ImageBox();
            MaskImgBox = new Emgu.CV.UI.ImageBox();
            MaskCheckbox = new CheckBox();
            saveFileDialog = new SaveFileDialog();
            openFileDialog = new OpenFileDialog();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaskImgBox).BeginInit();
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
            AImgBox.Click += AImgBox_Click;
            // 
            // BImgBox
            // 
            BImgBox.BorderStyle = BorderStyle.FixedSingle;
            BImgBox.Location = new Point(200, 3);
            BImgBox.Name = "BImgBox";
            BImgBox.Size = new Size(150, 150);
            BImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BImgBox.TabIndex = 3;
            BImgBox.TabStop = false;
            BImgBox.Click += BImgBox_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(159, 58);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 4;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(356, 58);
            label2.Name = "label2";
            label2.Size = new Size(46, 37);
            label2.TabIndex = 5;
            label2.Text = "->";
            // 
            // OutputImgBox
            // 
            OutputImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutputImgBox.Location = new Point(408, 3);
            OutputImgBox.Name = "OutputImgBox";
            OutputImgBox.Size = new Size(150, 150);
            OutputImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutputImgBox.TabIndex = 6;
            OutputImgBox.TabStop = false;
            // 
            // MaskImgBox
            // 
            MaskImgBox.BorderStyle = BorderStyle.FixedSingle;
            MaskImgBox.Location = new Point(200, 159);
            MaskImgBox.Name = "MaskImgBox";
            MaskImgBox.Size = new Size(75, 75);
            MaskImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            MaskImgBox.TabIndex = 2;
            MaskImgBox.TabStop = false;
            MaskImgBox.Click += MaskImgBox_Click;
            // 
            // MaskCheckbox
            // 
            MaskCheckbox.AutoSize = true;
            MaskCheckbox.Location = new Point(281, 187);
            MaskCheckbox.Name = "MaskCheckbox";
            MaskCheckbox.Size = new Size(76, 19);
            MaskCheckbox.TabIndex = 7;
            MaskCheckbox.Text = "Use Mask";
            MaskCheckbox.UseVisualStyleBackColor = true;
            MaskCheckbox.CheckedChanged += MaskCheckbox_CheckedChanged;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(452, 159);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CopyToOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(MaskCheckbox);
            Controls.Add(MaskImgBox);
            Controls.Add(OutputImgBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BImgBox);
            Controls.Add(AImgBox);
            Name = "CopyToOp";
            Size = new Size(562, 237);
            ((System.ComponentModel.ISupportInitialize)AImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaskImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox AImgBox;
        private Emgu.CV.UI.ImageBox BImgBox;
        private Label label1;
        private Label label2;
        private Emgu.CV.UI.ImageBox OutputImgBox;
        private Emgu.CV.UI.ImageBox MaskImgBox;
        private CheckBox MaskCheckbox;
        private SaveFileDialog saveFileDialog;
        private OpenFileDialog openFileDialog;
        private Button SaveButton;
    }
}
