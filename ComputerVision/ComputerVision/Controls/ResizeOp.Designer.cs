namespace ComputerVision.Controls
{
    partial class ResizeOp
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
            WidthTextbox = new TextBox();
            HeightTextbox = new TextBox();
            SaveButton = new Button();
            label1 = new Label();
            label2 = new Label();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            OpComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)AImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).BeginInit();
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
            BImgBox.Location = new Point(265, 3);
            BImgBox.Name = "BImgBox";
            BImgBox.Size = new Size(150, 150);
            BImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BImgBox.TabIndex = 3;
            BImgBox.TabStop = false;
            // 
            // WidthTextbox
            // 
            WidthTextbox.Location = new Point(159, 23);
            WidthTextbox.Name = "WidthTextbox";
            WidthTextbox.Size = new Size(100, 23);
            WidthTextbox.TabIndex = 4;
            WidthTextbox.Text = "50";
            WidthTextbox.TextChanged += WidthTextbox_TextChanged;
            // 
            // HeightTextbox
            // 
            HeightTextbox.Location = new Point(159, 70);
            HeightTextbox.Name = "HeightTextbox";
            HeightTextbox.Size = new Size(100, 23);
            HeightTextbox.TabIndex = 5;
            HeightTextbox.Text = "50";
            HeightTextbox.TextChanged += HeightTextbox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(171, 128);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 6;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 52);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 7;
            label1.Text = "Height";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 5);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 8;
            label2.Text = "Width";
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(159, 101);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(100, 23);
            OpComboBox.TabIndex = 9;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // ResizeOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpComboBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveButton);
            Controls.Add(HeightTextbox);
            Controls.Add(WidthTextbox);
            Controls.Add(BImgBox);
            Controls.Add(AImgBox);
            Name = "ResizeOp";
            Size = new Size(419, 159);
            ((System.ComponentModel.ISupportInitialize)AImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox AImgBox;
        private Emgu.CV.UI.ImageBox BImgBox;
        private TextBox WidthTextbox;
        private TextBox HeightTextbox;
        private Button SaveButton;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private ComboBox OpComboBox;
    }
}
