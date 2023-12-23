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
            isMirroredCheckbox = new CheckBox();
            CaptureImgBox = new Emgu.CV.UI.ImageBox();
            CaptureButton = new Button();
            InRangeImgBox = new Emgu.CV.UI.ImageBox();
            VarianceTrackbar = new TrackBar();
            DilateErodeImgBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CaptureImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilateErodeImgBox).BeginInit();
            SuspendLayout();
            // 
            // CameraImgBox
            // 
            CameraImgBox.Location = new Point(12, 12);
            CameraImgBox.Name = "CameraImgBox";
            CameraImgBox.Size = new Size(478, 321);
            CameraImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CameraImgBox.TabIndex = 2;
            CameraImgBox.TabStop = false;
            // 
            // isMirroredCheckbox
            // 
            isMirroredCheckbox.AutoSize = true;
            isMirroredCheckbox.Location = new Point(12, 339);
            isMirroredCheckbox.Name = "isMirroredCheckbox";
            isMirroredCheckbox.Size = new Size(103, 19);
            isMirroredCheckbox.TabIndex = 3;
            isMirroredCheckbox.Text = "Mirror Camera";
            isMirroredCheckbox.UseVisualStyleBackColor = true;
            // 
            // CaptureImgBox
            // 
            CaptureImgBox.Location = new Point(12, 364);
            CaptureImgBox.Name = "CaptureImgBox";
            CaptureImgBox.Size = new Size(172, 130);
            CaptureImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CaptureImgBox.TabIndex = 4;
            CaptureImgBox.TabStop = false;
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
            DilateErodeImgBox.Location = new Point(368, 364);
            DilateErodeImgBox.Name = "DilateErodeImgBox";
            DilateErodeImgBox.Size = new Size(172, 130);
            DilateErodeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            DilateErodeImgBox.TabIndex = 9;
            DilateErodeImgBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1054, 543);
            Controls.Add(DilateErodeImgBox);
            Controls.Add(VarianceTrackbar);
            Controls.Add(InRangeImgBox);
            Controls.Add(CaptureButton);
            Controls.Add(CaptureImgBox);
            Controls.Add(isMirroredCheckbox);
            Controls.Add(CameraImgBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CameraImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)CaptureImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)VarianceTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilateErodeImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraImgBox;
        private CheckBox isMirroredCheckbox;
        private Emgu.CV.UI.ImageBox CaptureImgBox;
        private Button CaptureButton;
        private Emgu.CV.UI.ImageBox InRangeImgBox;
        private TrackBar VarianceTrackbar;
        private Emgu.CV.UI.ImageBox DilateErodeImgBox;
    }
}