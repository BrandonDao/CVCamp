namespace ComputerVisionTool
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
            AddBitwiseButton = new Button();
            AddColorConvertButton = new Button();
            SuspendLayout();
            // 
            // AddBitwiseButton
            // 
            AddBitwiseButton.Location = new Point(12, 6);
            AddBitwiseButton.Name = "AddBitwiseButton";
            AddBitwiseButton.Size = new Size(140, 23);
            AddBitwiseButton.TabIndex = 1;
            AddBitwiseButton.Text = "Add Bitwise";
            AddBitwiseButton.UseVisualStyleBackColor = true;
            AddBitwiseButton.Click += AddBitwiseButton_Click;
            // 
            // AddColorConvertButton
            // 
            AddColorConvertButton.Location = new Point(12, 35);
            AddColorConvertButton.Name = "AddColorConvertButton";
            AddColorConvertButton.Size = new Size(140, 23);
            AddColorConvertButton.TabIndex = 2;
            AddColorConvertButton.Text = "Add Color Converter";
            AddColorConvertButton.UseVisualStyleBackColor = true;
            AddColorConvertButton.Click += AddColorConvertButton_Click;
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(985, 729);
            Controls.Add(AddColorConvertButton);
            Controls.Add(AddBitwiseButton);
            Name = "Form1";
            Text = "CV Tool";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button AddBitwiseButton;
        private Button AddColorConvertButton;
    }
}