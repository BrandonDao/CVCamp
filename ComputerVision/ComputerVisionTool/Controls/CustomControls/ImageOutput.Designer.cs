namespace ComputerVisionTool.Controls.CustomControls
{
    partial class ImageOutput
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
            ImageBox = new Emgu.CV.UI.ImageBox();
            NameTextbox = new TextBox();
            SaveButton = new Button();
            saveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)ImageBox).BeginInit();
            SuspendLayout();
            // 
            // ImageBox
            // 
            ImageBox.BorderStyle = BorderStyle.FixedSingle;
            ImageBox.Location = new Point(3, 32);
            ImageBox.Name = "ImageBox";
            ImageBox.Size = new Size(150, 150);
            ImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            ImageBox.TabIndex = 2;
            ImageBox.TabStop = false;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(3, 188);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(150, 23);
            NameTextbox.TabIndex = 3;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(44, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ImageOutput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SaveButton);
            Controls.Add(NameTextbox);
            Controls.Add(ImageBox);
            Name = "ImageOutput";
            Size = new Size(157, 216);
            ((System.ComponentModel.ISupportInitialize)ImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox ImageBox;
        private TextBox NameTextbox;
        private Button SaveButton;
        private SaveFileDialog saveFileDialog;
    }
}
