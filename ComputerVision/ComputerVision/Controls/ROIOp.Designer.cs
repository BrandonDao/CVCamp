namespace ComputerVision.Controls
{
    partial class ROIOp
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            XTextBox = new TextBox();
            YTextBox = new TextBox();
            WidthTextBox = new TextBox();
            HeightTextBox = new TextBox();
            XTrackbar = new TrackBar();
            YTrackbar = new TrackBar();
            WidthTrackbar = new TrackBar();
            HeightTrackbar = new TrackBar();
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WidthTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HeightTrackbar).BeginInit();
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
            InImgBox.Click += AImgBox_Click;
            // 
            // BImgBox
            // 
            OutImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutImgBox.Location = new Point(417, 3);
            OutImgBox.Name = "BImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 17);
            label1.Name = "label1";
            label1.Size = new Size(14, 15);
            label1.TabIndex = 4;
            label1.Text = "X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 53);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 5;
            label2.Text = "Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 88);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Width";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 123);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Height";
            // 
            // XTextBox
            // 
            XTextBox.Enabled = false;
            XTextBox.Location = new Point(208, 14);
            XTextBox.Name = "XTextBox";
            XTextBox.Size = new Size(50, 23);
            XTextBox.TabIndex = 8;
            // 
            // YTextBox
            // 
            YTextBox.Enabled = false;
            YTextBox.Location = new Point(208, 50);
            YTextBox.Name = "YTextBox";
            YTextBox.Size = new Size(50, 23);
            YTextBox.TabIndex = 9;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Enabled = false;
            WidthTextBox.Location = new Point(208, 85);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(50, 23);
            WidthTextBox.TabIndex = 10;
            // 
            // HeightTextBox
            // 
            HeightTextBox.Enabled = false;
            HeightTextBox.Location = new Point(208, 120);
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.Size = new Size(50, 23);
            HeightTextBox.TabIndex = 11;
            // 
            // XTrackbar
            // 
            XTrackbar.Location = new Point(261, 14);
            XTrackbar.Name = "XTrackbar";
            XTrackbar.Size = new Size(150, 45);
            XTrackbar.TabIndex = 12;
            XTrackbar.Scroll += XTrackbar_Scroll;
            // 
            // YTrackbar
            // 
            YTrackbar.Location = new Point(261, 50);
            YTrackbar.Name = "YTrackbar";
            YTrackbar.Size = new Size(150, 45);
            YTrackbar.TabIndex = 13;
            YTrackbar.Scroll += YTrackbar_Scroll;
            // 
            // WidthTrackbar
            // 
            WidthTrackbar.Location = new Point(261, 88);
            WidthTrackbar.Minimum = 1;
            WidthTrackbar.Name = "WidthTrackbar";
            WidthTrackbar.Size = new Size(150, 45);
            WidthTrackbar.TabIndex = 14;
            WidthTrackbar.Value = 1;
            WidthTrackbar.Scroll += WidthTrackbar_Scroll;
            // 
            // HeightTrackbar
            // 
            HeightTrackbar.Location = new Point(261, 120);
            HeightTrackbar.Minimum = 1;
            HeightTrackbar.Name = "HeightTrackbar";
            HeightTrackbar.Size = new Size(150, 45);
            HeightTrackbar.TabIndex = 15;
            HeightTrackbar.Value = 1;
            HeightTrackbar.Scroll += HeightTrackbar_Scroll;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(458, 155);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 16;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ROIOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(HeightTrackbar);
            Controls.Add(WidthTrackbar);
            Controls.Add(YTrackbar);
            Controls.Add(XTrackbar);
            Controls.Add(HeightTextBox);
            Controls.Add(WidthTextBox);
            Controls.Add(YTextBox);
            Controls.Add(XTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "ROIOp";
            Size = new Size(571, 180);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)XTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)YTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)WidthTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)HeightTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox XTextBox;
        private TextBox YTextBox;
        private TextBox WidthTextBox;
        private TextBox HeightTextBox;
        private TrackBar XTrackbar;
        private TrackBar YTrackbar;
        private TrackBar WidthTrackbar;
        private TrackBar HeightTrackbar;
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private Button SaveButton;
    }
}
