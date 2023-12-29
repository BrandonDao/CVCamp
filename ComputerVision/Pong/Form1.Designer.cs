namespace Pong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            CameraImgBox = new Emgu.CV.UI.ImageBox();
            IsMirroredCheckbox = new CheckBox();
            CaptureColorImgBox = new Emgu.CV.UI.ImageBox();
            CaptureButton = new Button();
            InRangeImgBox = new Emgu.CV.UI.ImageBox();
            VarianceTrackbar = new TrackBar();
            DilateErodeImgBox = new Emgu.CV.UI.ImageBox();
            KernelSizeTrackbar = new TrackBar();
            IterationsTrackbar = new TrackBar();
            GamePictureBox = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            openFileDialog = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureColorImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilateErodeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KernelSizeTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IterationsTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // CameraImgBox
            // 
            CameraImgBox.BorderStyle = BorderStyle.FixedSingle;
            CameraImgBox.Location = new Point(12, 12);
            CameraImgBox.Name = "CameraImgBox";
            CameraImgBox.Size = new Size(528, 321);
            CameraImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CameraImgBox.TabIndex = 2;
            CameraImgBox.TabStop = false;
            // 
            // IsMirroredCheckbox
            // 
            IsMirroredCheckbox.AutoSize = true;
            IsMirroredCheckbox.Checked = true;
            IsMirroredCheckbox.CheckState = CheckState.Checked;
            IsMirroredCheckbox.Location = new Point(12, 339);
            IsMirroredCheckbox.Name = "IsMirroredCheckbox";
            IsMirroredCheckbox.Size = new Size(103, 19);
            IsMirroredCheckbox.TabIndex = 3;
            IsMirroredCheckbox.Text = "Mirror Camera";
            IsMirroredCheckbox.UseVisualStyleBackColor = true;
            // 
            // CaptureImgBox
            // 
            CaptureColorImgBox.BorderStyle = BorderStyle.FixedSingle;
            CaptureColorImgBox.Location = new Point(12, 364);
            CaptureColorImgBox.Name = "CaptureImgBox";
            CaptureColorImgBox.Size = new Size(172, 130);
            CaptureColorImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CaptureColorImgBox.TabIndex = 4;
            CaptureColorImgBox.TabStop = false;
            CaptureColorImgBox.Click += CaptureImgBox_Click;
            // 
            // CaptureButton
            // 
            CaptureButton.Location = new Point(12, 500);
            CaptureButton.Name = "CaptureButton";
            CaptureButton.Size = new Size(172, 23);
            CaptureButton.TabIndex = 5;
            CaptureButton.Text = "Capture Current Frame";
            CaptureButton.UseVisualStyleBackColor = true;
            CaptureButton.Click += CaptureButton_Click;
            // 
            // InRangeImgBox
            // 
            InRangeImgBox.BorderStyle = BorderStyle.FixedSingle;
            InRangeImgBox.Location = new Point(190, 364);
            InRangeImgBox.Name = "InRangeImgBox";
            InRangeImgBox.Size = new Size(172, 130);
            InRangeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InRangeImgBox.TabIndex = 7;
            InRangeImgBox.TabStop = false;
            // 
            // VarianceTrackbar
            // 
            VarianceTrackbar.Location = new Point(190, 500);
            VarianceTrackbar.Maximum = 100;
            VarianceTrackbar.Name = "VarianceTrackbar";
            VarianceTrackbar.Size = new Size(172, 45);
            VarianceTrackbar.TabIndex = 8;
            VarianceTrackbar.Scroll += VarianceTrackbar_Scroll;
            // 
            // DilateErodeImgBox
            // 
            DilateErodeImgBox.BorderStyle = BorderStyle.FixedSingle;
            DilateErodeImgBox.Location = new Point(368, 364);
            DilateErodeImgBox.Name = "DilateErodeImgBox";
            DilateErodeImgBox.Size = new Size(172, 130);
            DilateErodeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            DilateErodeImgBox.TabIndex = 9;
            DilateErodeImgBox.TabStop = false;
            // 
            // KernelSizeTrackbar
            // 
            KernelSizeTrackbar.Location = new Point(368, 500);
            KernelSizeTrackbar.Maximum = 50;
            KernelSizeTrackbar.Minimum = 1;
            KernelSizeTrackbar.Name = "KernelSizeTrackbar";
            KernelSizeTrackbar.Size = new Size(172, 45);
            KernelSizeTrackbar.TabIndex = 10;
            KernelSizeTrackbar.Value = 1;
            KernelSizeTrackbar.Scroll += KernelSizeTrackbar_Scroll;
            // 
            // IterationsTrackbar
            // 
            IterationsTrackbar.Location = new Point(368, 528);
            IterationsTrackbar.Maximum = 20;
            IterationsTrackbar.Name = "IterationsTrackbar";
            IterationsTrackbar.Size = new Size(172, 45);
            IterationsTrackbar.TabIndex = 11;
            // 
            // GamePictureBox
            // 
            GamePictureBox.BorderStyle = BorderStyle.FixedSingle;
            GamePictureBox.Location = new Point(546, 12);
            GamePictureBox.Name = "GamePictureBox";
            GamePictureBox.Size = new Size(673, 561);
            GamePictureBox.TabIndex = 12;
            GamePictureBox.TabStop = false;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            // 
            // openFileDialog1
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1231, 585);
            Controls.Add(GamePictureBox);
            Controls.Add(IterationsTrackbar);
            Controls.Add(KernelSizeTrackbar);
            Controls.Add(DilateErodeImgBox);
            Controls.Add(VarianceTrackbar);
            Controls.Add(InRangeImgBox);
            Controls.Add(CaptureButton);
            Controls.Add(CaptureColorImgBox);
            Controls.Add(IsMirroredCheckbox);
            Controls.Add(CameraImgBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureColorImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilateErodeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)KernelSizeTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)IterationsTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)GamePictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraImgBox;
        private CheckBox IsMirroredCheckbox;
        private Emgu.CV.UI.ImageBox CaptureColorImgBox;
        private Button CaptureButton;
        private Emgu.CV.UI.ImageBox InRangeImgBox;
        private TrackBar VarianceTrackbar;
        private Emgu.CV.UI.ImageBox DilateErodeImgBox;
        private TrackBar KernelSizeTrackbar;
        private TrackBar IterationsTrackbar;
        private PictureBox GamePictureBox;
        private System.Windows.Forms.Timer GameTimer;
        private OpenFileDialog openFileDialog;
    }
}