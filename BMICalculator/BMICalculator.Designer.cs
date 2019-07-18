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
            this.ResultProgressBar = new System.Windows.Forms.ProgressBar();
            this.YourBMILabel = new System.Windows.Forms.Label();
            this.ResultDescription = new System.Windows.Forms.TextBox();
            this.InfotableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.InfoLabel14 = new System.Windows.Forms.Label();
            this.InfoLabel04 = new System.Windows.Forms.Label();
            this.InfoLabel13 = new System.Windows.Forms.Label();
            this.InfoLabel03 = new System.Windows.Forms.Label();
            this.InfoLabel12 = new System.Windows.Forms.Label();
            this.InfoLabel02 = new System.Windows.Forms.Label();
            this.InfoLabel11 = new System.Windows.Forms.Label();
            this.InfoLabel10 = new System.Windows.Forms.Label();
            this.InfoLabel00 = new System.Windows.Forms.Label();
            this.Infolabel01 = new System.Windows.Forms.Label();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BMICalculatorLayoutPanel.SuspendLayout();
            this.InfotableLayoutPanel.SuspendLayout();
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
            this.BMICalculatorLayoutPanel.Location = new System.Drawing.Point(0, 2);
            this.BMICalculatorLayoutPanel.Name = "BMICalculatorLayoutPanel";
            this.BMICalculatorLayoutPanel.RowCount = 4;
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculatorLayoutPanel.Size = new System.Drawing.Size(305, 192);
            this.BMICalculatorLayoutPanel.TabIndex = 0;
            // 
            // WeightInput
            // 
            this.WeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightInput.Location = new System.Drawing.Point(155, 99);
            this.WeightInput.Name = "WeightInput";
            this.WeightInput.Size = new System.Drawing.Size(100, 30);
            this.WeightInput.TabIndex = 7;
            this.WeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightInput.Enter += new System.EventHandler(this.WeightInput_Enter);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.Location = new System.Drawing.Point(155, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(141, 42);
            this.ImperialRadioButton.TabIndex = 5;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 147);
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
            this.ResetButton.Location = new System.Drawing.Point(155, 147);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(146, 28);
            this.ResetButton.TabIndex = 1;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 96);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(146, 48);
            this.WeightLabel.TabIndex = 2;
            this.WeightLabel.Text = "My weight";
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.Location = new System.Drawing.Point(8, 48);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(141, 48);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My height";
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Checked = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MetricRadioButton.Location = new System.Drawing.Point(33, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(116, 42);
            this.MetricRadioButton.TabIndex = 4;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // HeightInput
            // 
            this.HeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightInput.Location = new System.Drawing.Point(155, 51);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(100, 30);
            this.HeightInput.TabIndex = 6;
            this.HeightInput.Tag = "";
            this.HeightInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightInput.Enter += new System.EventHandler(this.HeightInput_Enter);
            // 
            // ResultProgressBar
            // 
            this.ResultProgressBar.Location = new System.Drawing.Point(19, 254);
            this.ResultProgressBar.Name = "ResultProgressBar";
            this.ResultProgressBar.Size = new System.Drawing.Size(255, 23);
            this.ResultProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ResultProgressBar.TabIndex = 2;
            // 
            // YourBMILabel
            // 
            this.YourBMILabel.AutoSize = true;
            this.YourBMILabel.Location = new System.Drawing.Point(12, 207);
            this.YourBMILabel.Name = "YourBMILabel";
            this.YourBMILabel.Size = new System.Drawing.Size(158, 39);
            this.YourBMILabel.TabIndex = 3;
            this.YourBMILabel.Text = "Your BMI";
            // 
            // ResultDescription
            // 
            this.ResultDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultDescription.Location = new System.Drawing.Point(19, 284);
            this.ResultDescription.Name = "ResultDescription";
            this.ResultDescription.ReadOnly = true;
            this.ResultDescription.Size = new System.Drawing.Size(255, 21);
            this.ResultDescription.TabIndex = 5;
            this.ResultDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // InfotableLayoutPanel
            // 
            this.InfotableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfotableLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfotableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.InfotableLayoutPanel.ColumnCount = 2;
            this.InfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.94993F));
            this.InfotableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.05006F));
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel14, 1, 4);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel04, 0, 4);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel13, 1, 3);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel03, 0, 3);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel12, 1, 2);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel02, 0, 2);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel11, 1, 1);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel10, 1, 0);
            this.InfotableLayoutPanel.Controls.Add(this.InfoLabel00, 0, 0);
            this.InfotableLayoutPanel.Controls.Add(this.Infolabel01, 0, 1);
            this.InfotableLayoutPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfotableLayoutPanel.Location = new System.Drawing.Point(2, 318);
            this.InfotableLayoutPanel.Name = "InfotableLayoutPanel";
            this.InfotableLayoutPanel.RowCount = 5;
            this.InfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfotableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.InfotableLayoutPanel.Size = new System.Drawing.Size(298, 112);
            this.InfotableLayoutPanel.TabIndex = 6;
            // 
            // InfoLabel14
            // 
            this.InfoLabel14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel14.AutoSize = true;
            this.InfoLabel14.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel14.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel14.Location = new System.Drawing.Point(116, 89);
            this.InfoLabel14.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel14.Name = "InfoLabel14";
            this.InfoLabel14.Size = new System.Drawing.Size(181, 22);
            this.InfoLabel14.TabIndex = 9;
            this.InfoLabel14.Text = "30 or greater";
            // 
            // InfoLabel04
            // 
            this.InfoLabel04.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel04.AutoSize = true;
            this.InfoLabel04.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel04.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel04.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel04.Location = new System.Drawing.Point(1, 89);
            this.InfoLabel04.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel04.Name = "InfoLabel04";
            this.InfoLabel04.Size = new System.Drawing.Size(114, 22);
            this.InfoLabel04.TabIndex = 8;
            this.InfoLabel04.Text = "Obese";
            // 
            // InfoLabel13
            // 
            this.InfoLabel13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel13.AutoSize = true;
            this.InfoLabel13.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel13.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel13.Location = new System.Drawing.Point(116, 67);
            this.InfoLabel13.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel13.Name = "InfoLabel13";
            this.InfoLabel13.Size = new System.Drawing.Size(181, 21);
            this.InfoLabel13.TabIndex = 7;
            this.InfoLabel13.Text = "between 25 and 29.9";
            // 
            // InfoLabel03
            // 
            this.InfoLabel03.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel03.AutoSize = true;
            this.InfoLabel03.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel03.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel03.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel03.Location = new System.Drawing.Point(1, 67);
            this.InfoLabel03.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel03.Name = "InfoLabel03";
            this.InfoLabel03.Size = new System.Drawing.Size(114, 21);
            this.InfoLabel03.TabIndex = 6;
            this.InfoLabel03.Text = "Overweight";
            // 
            // InfoLabel12
            // 
            this.InfoLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel12.AutoSize = true;
            this.InfoLabel12.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel12.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel12.Location = new System.Drawing.Point(116, 45);
            this.InfoLabel12.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel12.Name = "InfoLabel12";
            this.InfoLabel12.Size = new System.Drawing.Size(181, 21);
            this.InfoLabel12.TabIndex = 5;
            this.InfoLabel12.Text = "between 18.5 and 24.9";
            // 
            // InfoLabel02
            // 
            this.InfoLabel02.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel02.AutoSize = true;
            this.InfoLabel02.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel02.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel02.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel02.Location = new System.Drawing.Point(1, 45);
            this.InfoLabel02.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel02.Name = "InfoLabel02";
            this.InfoLabel02.Size = new System.Drawing.Size(114, 21);
            this.InfoLabel02.TabIndex = 4;
            this.InfoLabel02.Text = "Normal";
            // 
            // InfoLabel11
            // 
            this.InfoLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel11.AutoSize = true;
            this.InfoLabel11.BackColor = System.Drawing.SystemColors.Window;
            this.InfoLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel11.ForeColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel11.Location = new System.Drawing.Point(116, 23);
            this.InfoLabel11.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel11.Name = "InfoLabel11";
            this.InfoLabel11.Size = new System.Drawing.Size(181, 21);
            this.InfoLabel11.TabIndex = 3;
            this.InfoLabel11.Text = "less than 18.5";
            // 
            // InfoLabel10
            // 
            this.InfoLabel10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel10.AutoSize = true;
            this.InfoLabel10.BackColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel10.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InfoLabel10.Location = new System.Drawing.Point(116, 1);
            this.InfoLabel10.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel10.Name = "InfoLabel10";
            this.InfoLabel10.Size = new System.Drawing.Size(181, 21);
            this.InfoLabel10.TabIndex = 1;
            this.InfoLabel10.Text = "Result";
            // 
            // InfoLabel00
            // 
            this.InfoLabel00.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoLabel00.AutoSize = true;
            this.InfoLabel00.BackColor = System.Drawing.Color.SteelBlue;
            this.InfoLabel00.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLabel00.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.InfoLabel00.Location = new System.Drawing.Point(1, 1);
            this.InfoLabel00.Margin = new System.Windows.Forms.Padding(0);
            this.InfoLabel00.Name = "InfoLabel00";
            this.InfoLabel00.Size = new System.Drawing.Size(114, 21);
            this.InfoLabel00.TabIndex = 0;
            this.InfoLabel00.Text = "BMI Scale";
            // 
            // Infolabel01
            // 
            this.Infolabel01.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Infolabel01.AutoSize = true;
            this.Infolabel01.BackColor = System.Drawing.SystemColors.Window;
            this.Infolabel01.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Infolabel01.ForeColor = System.Drawing.Color.SteelBlue;
            this.Infolabel01.Location = new System.Drawing.Point(1, 23);
            this.Infolabel01.Margin = new System.Windows.Forms.Padding(0);
            this.Infolabel01.Name = "Infolabel01";
            this.Infolabel01.Size = new System.Drawing.Size(114, 21);
            this.Infolabel01.TabIndex = 2;
            this.Infolabel01.Text = "Underweight";
            // 
            // ResultLabel
            // 
            this.ResultLabel.Location = new System.Drawing.Point(165, 207);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(109, 39);
            this.ResultLabel.TabIndex = 7;
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 433);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.InfotableLayoutPanel);
            this.Controls.Add(this.ResultDescription);
            this.Controls.Add(this.YourBMILabel);
            this.Controls.Add(this.ResultProgressBar);
            this.Controls.Add(this.BMICalculatorLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.BMICalculatorLayoutPanel.ResumeLayout(false);
            this.BMICalculatorLayoutPanel.PerformLayout();
            this.InfotableLayoutPanel.ResumeLayout(false);
            this.InfotableLayoutPanel.PerformLayout();
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
        private System.Windows.Forms.ProgressBar ResultProgressBar;
        private System.Windows.Forms.Label YourBMILabel;
        private System.Windows.Forms.TextBox ResultDescription;
        private System.Windows.Forms.TableLayoutPanel InfotableLayoutPanel;
        private System.Windows.Forms.Label Infolabel01;
        private System.Windows.Forms.Label InfoLabel10;
        private System.Windows.Forms.Label InfoLabel00;
        private System.Windows.Forms.Label InfoLabel14;
        private System.Windows.Forms.Label InfoLabel04;
        private System.Windows.Forms.Label InfoLabel13;
        private System.Windows.Forms.Label InfoLabel03;
        private System.Windows.Forms.Label InfoLabel12;
        private System.Windows.Forms.Label InfoLabel02;
        private System.Windows.Forms.Label InfoLabel11;
        private System.Windows.Forms.Label ResultLabel;
    }
}

