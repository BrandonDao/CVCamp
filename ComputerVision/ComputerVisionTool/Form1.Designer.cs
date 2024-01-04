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
            AddInRangeButton = new Button();
            AddRotateFlipButton = new Button();
            AddROIButton = new Button();
            AddTransformationButton = new Button();
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
            AddErodeButton.Location = new Point(12, 162);
            AddErodeButton.Name = "AddErodeButton";
            AddErodeButton.Size = new Size(140, 23);
            AddErodeButton.TabIndex = 4;
            AddErodeButton.Text = "Add Erode";
            AddErodeButton.UseVisualStyleBackColor = true;
            AddErodeButton.Click += AddErodeButton_Click;
            // 
            // AddDilateButton
            // 
            AddDilateButton.Location = new Point(12, 133);
            AddDilateButton.Name = "AddDilateButton";
            AddDilateButton.Size = new Size(140, 23);
            AddDilateButton.TabIndex = 5;
            AddDilateButton.Text = "Add Dilate";
            AddDilateButton.UseVisualStyleBackColor = true;
            AddDilateButton.Click += AddDilateButton_Click;
            // 
            // AddThresholdButton
            // 
            AddThresholdButton.Location = new Point(12, 278);
            AddThresholdButton.Name = "AddThresholdButton";
            AddThresholdButton.Size = new Size(140, 23);
            AddThresholdButton.TabIndex = 6;
            AddThresholdButton.Text = "Add Threshold";
            AddThresholdButton.UseVisualStyleBackColor = true;
            AddThresholdButton.Click += AddThresholdButton_Click;
            // 
            // AddInRangeButton
            // 
            AddInRangeButton.Location = new Point(12, 191);
            AddInRangeButton.Name = "AddInRangeButton";
            AddInRangeButton.Size = new Size(140, 23);
            AddInRangeButton.TabIndex = 7;
            AddInRangeButton.Text = "Add InRange";
            AddInRangeButton.UseVisualStyleBackColor = true;
            AddInRangeButton.Click += AddInRangeButton_Click;
            // 
            // AddRotateFlipButton
            // 
            AddRotateFlipButton.Location = new Point(12, 249);
            AddRotateFlipButton.Name = "AddRotateFlipButton";
            AddRotateFlipButton.Size = new Size(140, 23);
            AddRotateFlipButton.TabIndex = 8;
            AddRotateFlipButton.Text = "Add Rotate && Flip";
            AddRotateFlipButton.UseVisualStyleBackColor = true;
            AddRotateFlipButton.Click += AddRotateFlipButton_Click;
            // 
            // AddROIButton
            // 
            AddROIButton.Location = new Point(12, 220);
            AddROIButton.Name = "AddROIButton";
            AddROIButton.Size = new Size(140, 23);
            AddROIButton.TabIndex = 9;
            AddROIButton.Text = "Add ROI";
            AddROIButton.UseVisualStyleBackColor = true;
            AddROIButton.Click += AddROIButton_Click;
            // 
            // AddTransformationButton
            // 
            AddTransformationButton.Location = new Point(12, 307);
            AddTransformationButton.Name = "AddTransformationButton";
            AddTransformationButton.Size = new Size(140, 23);
            AddTransformationButton.TabIndex = 10;
            AddTransformationButton.Text = "Add Transformation";
            AddTransformationButton.UseVisualStyleBackColor = true;
            AddTransformationButton.Click += AddTransformationButton_Click;
            // 
            // CVToolsForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1184, 561);
            Controls.Add(AddTransformationButton);
            Controls.Add(AddROIButton);
            Controls.Add(AddRotateFlipButton);
            Controls.Add(AddInRangeButton);
            Controls.Add(AddThresholdButton);
            Controls.Add(AddDilateButton);
            Controls.Add(AddErodeButton);
            Controls.Add(AddTabButton);
            Controls.Add(AddConvertColorButton);
            Controls.Add(AddBitwiseButton);
            MaximumSize = new Size(5000, 5000);
            MinimumSize = new Size(1200, 500);
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
        private Button AddInRangeButton;
        private Button AddRotateFlipButton;
        private Button AddROIButton;
        private Button AddTransformationButton;
    }
}