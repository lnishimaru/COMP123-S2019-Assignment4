namespace BMICalculator
{
    partial class BMICalculatorForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BMICalculatorLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.WeightInput = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.BMICalculatorLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculatorLayoutPanel
            // 
            this.BMICalculatorLayoutPanel.ColumnCount = 2;
            this.BMICalculatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BMICalculatorLayoutPanel.Controls.Add(this.WeightInput, 1, 2);
            this.BMICalculatorLayoutPanel.Controls.Add(this.ImperialRadioButton, 1, 0);
            this.BMICalculatorLayoutPanel.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.BMICalculatorLayoutPanel.Controls.Add(this.ResetButton, 1, 3);
            this.BMICalculatorLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMICalculatorLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculatorLayoutPanel.Controls.Add(this.MetricRadioButton, 0, 0);
            this.BMICalculatorLayoutPanel.Controls.Add(this.HeightInput, 1, 1);
            this.BMICalculatorLayoutPanel.Location = new System.Drawing.Point(0, 53);
            this.BMICalculatorLayoutPanel.Name = "BMICalculatorLayoutPanel";
            this.BMICalculatorLayoutPanel.RowCount = 4;
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.Size = new System.Drawing.Size(305, 219);
            this.BMICalculatorLayoutPanel.TabIndex = 0;
            // 
            // WeightInput
            // 
            this.WeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInput.Location = new System.Drawing.Point(155, 111);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 30);
            this.WeightInput.TabIndex = 7;
            this.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(155, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(140, 48);
            this.ImperialRadioButton.TabIndex = 5;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 165);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(146, 28);
            this.CalculateBMIButton.TabIndex = 0;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(155, 165);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 28);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 108);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(146, 54);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My weight";
            this.WeightLabel.Click += new System.EventHandler(this.WeightLabel_Click);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(4, 54);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(145, 54);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My height";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Location = new System.Drawing.Point(32, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(117, 48);
            this.MetricRadioButton.TabIndex = 4;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(155, 57);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 30);
            this.HeightInput.TabIndex = 6;
            this.HeightInput.Tag = "";
            this.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "BMI Calculator";
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Location = new System.Drawing.Point(19, 374);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(255, 23);
            this.ResultProgressBar.TabIndex = 2;
            this.ResultProgressBar.Value = 25;
            this.ResultProgressBar.Click += new System.EventHandler(this.ResultProgressBar_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(12, 304);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(158, 39);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Your BMI";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(174, 304);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(100, 45);
            this.ResultTextBox.TabIndex = 4;
            this.ResultTextBox.Text = "25";
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ResultProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BMICalculatorLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.BMICalculatorLayoutPanel.ResumeLayout(false);
            this.BMICalculatorLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculatorLayoutPanel;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.TextBox WeightInput;
        private System.Windows.Forms.TextBox HeightInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}

