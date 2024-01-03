namespace ComputerVisionTool.Controls.Operations
{
    partial class ThresholdOp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThresholdOp));
            InputImg = new CustomControls.ImageInput();
            OutputImg = new CustomControls.ImageOutput();
            MaxValueTrackbar = new TrackBar();
            ThresholdTrackbar = new TrackBar();
            ThresholdLabel = new Label();
            MaxValueLabel = new Label();
            OpComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)MaxValueTrackbar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdTrackbar).BeginInit();
            SuspendLayout();
            // 
            // InputImg
            // 
            InputImg.Location = new Point(3, 3);
            InputImg.Name = "InputImg";
            InputImg.Size = new Size(156, 186);
            InputImg.TabIndex = 0;
            // 
            // OutputImg
            // 
            OutputImg.Location = new Point(459, 3);
            OutputImg.Mat = (Emgu.CV.Mat)resources.GetObject("OutputImg.Mat");
            OutputImg.Name = "OutputImg";
            OutputImg.Size = new Size(157, 216);
            OutputImg.TabIndex = 1;
            // 
            // MaxValueTrackbar
            // 
            MaxValueTrackbar.Location = new Point(165, 158);
            MaxValueTrackbar.Maximum = 255;
            MaxValueTrackbar.Name = "MaxValueTrackbar";
            MaxValueTrackbar.Size = new Size(289, 45);
            MaxValueTrackbar.TabIndex = 2;
            MaxValueTrackbar.Scroll += MaxValueTrackbar_Scroll;
            // 
            // ThresholdTrackbar
            // 
            ThresholdTrackbar.Location = new Point(165, 92);
            ThresholdTrackbar.Maximum = 255;
            ThresholdTrackbar.Name = "ThresholdTrackbar";
            ThresholdTrackbar.Size = new Size(289, 45);
            ThresholdTrackbar.TabIndex = 3;
            ThresholdTrackbar.Scroll += ThresholdTrackbar_Scroll;
            // 
            // ThresholdLabel
            // 
            ThresholdLabel.AutoSize = true;
            ThresholdLabel.Location = new Point(165, 74);
            ThresholdLabel.Name = "ThresholdLabel";
            ThresholdLabel.Size = new Size(59, 15);
            ThresholdLabel.TabIndex = 4;
            ThresholdLabel.Text = "Threshold";
            // 
            // MaxValueLabel
            // 
            MaxValueLabel.AutoSize = true;
            MaxValueLabel.Location = new Point(165, 140);
            MaxValueLabel.Name = "MaxValueLabel";
            MaxValueLabel.Size = new Size(61, 15);
            MaxValueLabel.TabIndex = 5;
            MaxValueLabel.Text = "Max Value";
            // 
            // OpComboBox
            // 
            OpComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            OpComboBox.FormattingEnabled = true;
            OpComboBox.Location = new Point(165, 34);
            OpComboBox.Name = "OpComboBox";
            OpComboBox.Size = new Size(121, 23);
            OpComboBox.TabIndex = 6;
            OpComboBox.SelectedIndexChanged += OpComboBox_SelectedIndexChanged;
            // 
            // ThresholdOp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OpComboBox);
            Controls.Add(MaxValueLabel);
            Controls.Add(ThresholdLabel);
            Controls.Add(ThresholdTrackbar);
            Controls.Add(MaxValueTrackbar);
            Controls.Add(OutputImg);
            Controls.Add(InputImg);
            Name = "ThresholdOp";
            Size = new Size(619, 221);
            ((System.ComponentModel.ISupportInitialize)MaxValueTrackbar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ThresholdTrackbar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.ImageInput InputImg;
        private CustomControls.ImageOutput OutputImg;
        private TrackBar MaxValueTrackbar;
        private TrackBar ThresholdTrackbar;
        private Label ThresholdLabel;
        private Label MaxValueLabel;
        private ComboBox OpComboBox;
    }
}
