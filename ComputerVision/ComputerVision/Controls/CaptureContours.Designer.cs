namespace ComputerVision.Controls
{
    partial class CaptureContours
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
            OutImgBox.Location = new Point(358, 3);
            OutImgBox.Name = "OutImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // CaptureContours
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "CaptureContours";
            Size = new Size(530, 157);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private OpenFileDialog openFileDialog;
    }
}
