namespace ComputerVisionTool
{
    partial class CVToolsForm
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
            AddConvertColorButton = new Button();
            AddTabButton = new Button();
            AddErodeButton = new Button();
            AddDilateButton = new Button();
            AddThresholdButton = new Button();
            SuspendLayout();
            // 
            // AddBitwiseButton
            // 
            AddBitwiseButton.Location = new Point(12, 75);
            AddBitwiseButton.Name = "AddBitwiseButton";
            AddBitwiseButton.Size = new Size(140, 23);
            AddBitwiseButton.TabIndex = 1;
            AddBitwiseButton.Text = "Add Bitwise";
            AddBitwiseButton.UseVisualStyleBackColor = true;
            AddBitwiseButton.Click += AddBitwiseButton_Click;
            // 
            // AddConvertColorButton
            // 
            AddConvertColorButton.Location = new Point(12, 104);
            AddConvertColorButton.Name = "AddConvertColorButton";
            AddConvertColorButton.Size = new Size(140, 23);
            AddConvertColorButton.TabIndex = 2;
            AddConvertColorButton.Text = "Add Color Converter";
            AddConvertColorButton.UseVisualStyleBackColor = true;
            AddConvertColorButton.Click += AddConvertColorButton_Click;
            // 
            // AddTabButton
            // 
            AddTabButton.Location = new Point(12, 12);
            AddTabButton.Name = "AddTabButton";
            AddTabButton.Size = new Size(140, 23);
            AddTabButton.TabIndex = 3;
            AddTabButton.Text = "Add Tab";
            AddTabButton.UseVisualStyleBackColor = true;
            AddTabButton.Click += AddTabButton_Click;
            // 
            // AddErodeButton
            // 
            AddErodeButton.Location = new Point(12, 133);
            AddErodeButton.Name = "AddErodeButton";
            AddErodeButton.Size = new Size(140, 23);
            AddErodeButton.TabIndex = 4;
            AddErodeButton.Text = "Add Erode";
            AddErodeButton.UseVisualStyleBackColor = true;
            AddErodeButton.Click += AddErodeButton_Click;
            // 
            // AddDilateButton
            // 
            AddDilateButton.Location = new Point(12, 162);
            AddDilateButton.Name = "AddDilateButton";
            AddDilateButton.Size = new Size(140, 23);
            AddDilateButton.TabIndex = 5;
            AddDilateButton.Text = "Add Dilate";
            AddDilateButton.UseVisualStyleBackColor = true;
            AddDilateButton.Click += AddDilateButton_Click;
            // 
            // AddThresholdButton
            // 
            AddThresholdButton.Location = new Point(12, 191);
            AddThresholdButton.Name = "AddThresholdButton";
            AddThresholdButton.Size = new Size(140, 23);
            AddThresholdButton.TabIndex = 6;
            AddThresholdButton.Text = "Add Threshold";
            AddThresholdButton.UseVisualStyleBackColor = true;
            AddThresholdButton.Click += AddThresholdButton_Click;
            // 
            // CVToolsForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(984, 461);
            Controls.Add(AddThresholdButton);
            Controls.Add(AddDilateButton);
            Controls.Add(AddErodeButton);
            Controls.Add(AddTabButton);
            Controls.Add(AddConvertColorButton);
            Controls.Add(AddBitwiseButton);
            MaximumSize = new Size(5000, 5000);
            MinimumSize = new Size(1000, 500);
            Name = "CVToolsForm";
            ShowIcon = false;
            Text = "CV Tool";
            Load += Form1_Load;
            ClientSizeChanged += CVToolsForm_ClientSizeChanged;
            ResumeLayout(false);
        }

        #endregion
        private Button AddBitwiseButton;
        private Button AddConvertColorButton;
        private Button AddTabButton;
        private Button AddErodeButton;
        private Button AddDilateButton;
        private Button AddThresholdButton;
    }
}