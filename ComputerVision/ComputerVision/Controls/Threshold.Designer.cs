namespace ComputerVision.Controls
{
    partial class Threshold
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
            OpComboBox = new ComboBox();
            ThresholdTrackbar = new TrackBar();
            ValueTrackbar = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)InImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ValueTrackbar).BeginInit();
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
            // 
            // OutImgBox
            // 
            OutImgBox.BorderStyle = BorderStyle.FixedSingle;
            OutImgBox.Location = new Point(390, 3);
            OutImgBox.Name = "OutImgBox";
            OutImgBox.Size = new Size(150, 150);
            OutImgBox.SizeMode = PictureBoxSizeMode.Zoom;
            OutImgBox.TabIndex = 3;
            OutImgBox.TabStop = false;
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(159, 3);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(121, 23);
            OpComboBox.TabIndex = 4;
            // 
            // ThresholdTrackbar
            // 
            ThresholdTrackbar.Location = new Point(159, 64);
            ThresholdTrackbar.Name = "ThresholdTrackbar";
            ThresholdTrackbar.Size = new Size(225, 45);
            ThresholdTrackbar.TabIndex = 5;
            // 
            // ValueTrackbar
            // 
            ValueTrackbar.Location = new Point(159, 125);
            ValueTrackbar.Name = "ValueTrackbar";
            ValueTrackbar.Size = new Size(225, 45);
            ValueTrackbar.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 46);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Threshold";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 107);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "Value";
            // 
            // Threshold
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ValueTrackbar);
            Controls.Add(ThresholdTrackbar);
            Controls.Add(OpComboBox);
            Controls.Add(OutImgBox);
            Controls.Add(InImgBox);
            Name = "Threshold";
            Size = new Size(543, 156);
            ((System.ComponentModel.ISupportInitialize)InImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutImgBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ValueTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox InImgBox;
        private Emgu.CV.UI.ImageBox OutImgBox;
        private ComboBox OpComboBox;
        private TrackBar ThresholdTrackbar;
        private TrackBar ValueTrackbar;
        private Label label1;
        private Label label2;
    }
}
