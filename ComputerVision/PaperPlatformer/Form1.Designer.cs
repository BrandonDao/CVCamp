namespace PaperPlatformer
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
            CameraInputImgBox = new Emgu.CV.UI.ImageBox();
            InRangeImgBox = new Emgu.CV.UI.ImageBox();
            PerspectiveImgBox = new Emgu.CV.UI.ImageBox();
            DilatedErodedImgBox = new Emgu.CV.UI.ImageBox();
            PaperContourImgBox = new Emgu.CV.UI.ImageBox();
            EpsilonTrackbar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            BinInvThresholdImgBox = new Emgu.CV.UI.ImageBox();
            label6 = new Label();
            label8 = new Label();
            BoundingBoxesImgBox = new Emgu.CV.UI.ImageBox();
            label7 = new Label();
            GameImgBox = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)CameraInputImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PerspectiveImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DilatedErodedImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PaperContourImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EpsilonTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BinInvThresholdImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BoundingBoxesImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GameImgBox).BeginInit();
            SuspendLayout();
            // 
            // CameraInputImgBox
            // 
            CameraInputImgBox.Location = new Point(12, 30);
            CameraInputImgBox.Name = "CameraInputImgBox";
            CameraInputImgBox.Size = new Size(160, 120);
            CameraInputImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            CameraInputImgBox.TabIndex = 2;
            CameraInputImgBox.TabStop = false;
            // 
            // InRangeImgBox
            // 
            InRangeImgBox.Location = new Point(178, 30);
            InRangeImgBox.Name = "InRangeImgBox";
            InRangeImgBox.Size = new Size(160, 120);
            InRangeImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            InRangeImgBox.TabIndex = 3;
            InRangeImgBox.TabStop = false;
            // 
            // PerspectiveImgBox
            // 
            PerspectiveImgBox.Location = new Point(12, 333);
            PerspectiveImgBox.Name = "PerspectiveImgBox";
            PerspectiveImgBox.Size = new Size(160, 120);
            PerspectiveImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            PerspectiveImgBox.TabIndex = 4;
            PerspectiveImgBox.TabStop = false;
            // 
            // DilatedErodedImgBox
            // 
            DilatedErodedImgBox.Location = new Point(12, 181);
            DilatedErodedImgBox.Name = "DilatedErodedImgBox";
            DilatedErodedImgBox.Size = new Size(160, 120);
            DilatedErodedImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            DilatedErodedImgBox.TabIndex = 5;
            DilatedErodedImgBox.TabStop = false;
            // 
            // PaperContourImgBox
            // 
            PaperContourImgBox.Location = new Point(178, 181);
            PaperContourImgBox.Name = "PaperContourImgBox";
            PaperContourImgBox.Size = new Size(160, 120);
            PaperContourImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            PaperContourImgBox.TabIndex = 6;
            PaperContourImgBox.TabStop = false;
            // 
            // EpsilonTrackbar
            // 
            EpsilonTrackbar.Location = new Point(344, 169);
            EpsilonTrackbar.Maximum = 500;
            EpsilonTrackbar.Name = "EpsilonTrackbar";
            EpsilonTrackbar.Orientation = Orientation.Vertical;
            EpsilonTrackbar.Size = new Size(45, 143);
            EpsilonTrackbar.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 8;
            label1.Text = "Raw Camera Input";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 9);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 9;
            label2.Text = "In Range";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 10;
            label3.Text = "Dilate/Erode";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(178, 163);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 11;
            label4.Text = "Paper Contour";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 315);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 12;
            label5.Text = "Perspective Warp";
            // 
            // BinInvThresholdImgBox
            // 
            BinInvThresholdImgBox.Location = new Point(178, 333);
            BinInvThresholdImgBox.Name = "BinInvThresholdImgBox";
            BinInvThresholdImgBox.Size = new Size(160, 120);
            BinInvThresholdImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BinInvThresholdImgBox.TabIndex = 13;
            BinInvThresholdImgBox.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 315);
            label6.Name = "label6";
            label6.Size = new Size(135, 15);
            label6.TabIndex = 14;
            label6.Text = "Binary Inverse Threshold";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 468);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 16;
            label8.Text = "Bounding Boxes";
            // 
            // BoundingBoxesImgBox
            // 
            BoundingBoxesImgBox.Location = new Point(12, 486);
            BoundingBoxesImgBox.Name = "BoundingBoxesImgBox";
            BoundingBoxesImgBox.Size = new Size(160, 120);
            BoundingBoxesImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            BoundingBoxesImgBox.TabIndex = 15;
            BoundingBoxesImgBox.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(337, 157);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 17;
            label7.Text = "Epsilon";
            // 
            // GameImgBox
            // 
            GameImgBox.Location = new Point(393, 30);
            GameImgBox.Name = "GameImgBox";
            GameImgBox.Size = new Size(640, 480);
            GameImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            GameImgBox.TabIndex = 18;
            GameImgBox.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 617);
            Controls.Add(GameImgBox);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(BoundingBoxesImgBox);
            Controls.Add(label6);
            Controls.Add(BinInvThresholdImgBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EpsilonTrackbar);
            Controls.Add(PaperContourImgBox);
            Controls.Add(DilatedErodedImgBox);
            Controls.Add(PerspectiveImgBox);
            Controls.Add(InRangeImgBox);
            Controls.Add(CameraInputImgBox);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)CameraInputImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InRangeImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PerspectiveImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DilatedErodedImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)PaperContourImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EpsilonTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)BinInvThresholdImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BoundingBoxesImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)GameImgBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox CameraInputImgBox;
        private Emgu.CV.UI.ImageBox InRangeImgBox;
        private Emgu.CV.UI.ImageBox PerspectiveImgBox;
        private Emgu.CV.UI.ImageBox DilatedErodedImgBox;
        private Emgu.CV.UI.ImageBox PaperContourImgBox;
        private TrackBar EpsilonTrackbar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Emgu.CV.UI.ImageBox BinInvThresholdImgBox;
        private Label label6;
        private Label label8;
        private Emgu.CV.UI.ImageBox BoundingBoxesImgBox;
        private Label label7;
        private Emgu.CV.UI.ImageBox GameImgBox;
    }
}
