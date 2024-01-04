namespace ComputerVisionTool.Controls.Operations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ROIOp));
            InputImg = new CustomControls.ImageInput();
            XTrackbar = new TrackBar();
            YTrackbar = new TrackBar();
            X2Trackbar = new TrackBar();
            Y2Trackbar = new TrackBar();
            OutputImg = new CustomControls.ImageOutput();
            ResetTrackbarsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)XTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)YTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)X2Trackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Y2Trackbar).BeginInit();
            SuspendLayout();
            // 
            // InputImg
            // 
            InputImg.Location = new Point(41, 33);
            InputImg.Name = "InputImg";
            InputImg.Size = new Size(156, 186);
            InputImg.TabIndex = 0;
            // 
            // XTrackbar
            // 
            XTrackbar.Location = new Point(41, 3);
            XTrackbar.Name = "XTrackbar";
            XTrackbar.Size = new Size(156, 45);
            XTrackbar.TabIndex = 1;
            XTrackbar.Scroll += XTrackbar_Scroll;
            // 
            // YTrackbar
            // 
            YTrackbar.Location = new Point(7, 63);
            YTrackbar.Name = "YTrackbar";
            YTrackbar.Orientation = Orientation.Vertical;
            YTrackbar.Size = new Size(45, 156);
            YTrackbar.TabIndex = 2;
            YTrackbar.Value = 10;
            YTrackbar.Scroll += YTrackbar_Scroll;
            // 
            // X2Trackbar
            // 
            X2Trackbar.Location = new Point(41, 225);
            X2Trackbar.Name = "X2Trackbar";
            X2Trackbar.Size = new Size(156, 45);
            X2Trackbar.TabIndex = 3;
            X2Trackbar.Value = 10;
            X2Trackbar.Scroll += X2Trackbar_Scroll;
            // 
            // Y2Trackbar
            // 
            Y2Trackbar.Location = new Point(203, 63);
            Y2Trackbar.Name = "Y2Trackbar";
            Y2Trackbar.Orientation = Orientation.Vertical;
            Y2Trackbar.Size = new Size(45, 156);
            Y2Trackbar.TabIndex = 4;
            Y2Trackbar.Scroll += Y2Trackbar_Scroll;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(327, 33);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 5;
            // 
            // ResetTrackbarsButton
            // 
            ResetTrackbarsButton.Location = new Point(3, 256);
            ResetTrackbarsButton.Name = "ResetTrackbarsButton";
            ResetTrackbarsButton.Size = new Size(101, 23);
            ResetTrackbarsButton.TabIndex = 6;
            ResetTrackbarsButton.Text = "Reset Sliders";
            ResetTrackbarsButton.UseVisualStyleBackColor = true;
            ResetTrackbarsButton.Click += ResetTrackbarsButton_Click;
            // 
            // ROIOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ResetTrackbarsButton);
            Controls.Add(OutputImg);
            Controls.Add(Y2Trackbar);
            Controls.Add(X2Trackbar);
            Controls.Add(InputImg);
            Controls.Add(YTrackbar);
            Controls.Add(XTrackbar);
            Name = "ROIOp";
            Size = new Size(487, 282);
            ((System.ComponentModel.ISupportInitialize)XTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)YTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)X2Trackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Y2Trackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private TrackBar XTrackbar;
        private TrackBar YTrackbar;
        private TrackBar X2Trackbar;
        private TrackBar Y2Trackbar;
        private CustomControls.ImageOutput OutputImg;
        private Button ResetTrackbarsButton;
    }
}
