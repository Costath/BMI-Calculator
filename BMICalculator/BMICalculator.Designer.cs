/*
 * Author's name: Thales Costa
 * Author's student ID: 301035028
 * Professor: Tom Tsiliopoulos
 * Course: Programming 2
 * Date last modified: July 20th, 2019
 * 
 * Description: This software implements a BMI (Body Mass Index) Calculator. User selects the desired 
 * measurement system between Imperial and Metric, and inputs height and weight values. The BMI value 
 * is calculated and displayed in a specific box, and a BMI scale is shown, highlighted according to 
 * the calculated BMI value.
 * The user can perform another calculation by simply clicking on height and weight text boxes.
 */
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
            this.ButtonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DelButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.HeightUnitLabel = new System.Windows.Forms.Label();
            this.WeightUnitLabel = new System.Windows.Forms.Label();
            this.BMITextBox = new System.Windows.Forms.TextBox();
            this.BMIScaleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ObeseLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NormalLabel2 = new System.Windows.Forms.Label();
            this.OverweightLabel2 = new System.Windows.Forms.Label();
            this.UnderweightLabel2 = new System.Windows.Forms.Label();
            this.ObeseLabel2 = new System.Windows.Forms.Label();
            this.OverweightLabel1 = new System.Windows.Forms.Label();
            this.NormalLabel1 = new System.Windows.Forms.Label();
            this.UnderweightLabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ButtonsTableLayoutPanel.SuspendLayout();
            this.BMIScaleTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsTableLayoutPanel
            // 
            this.ButtonsTableLayoutPanel.ColumnCount = 3;
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ButtonsTableLayoutPanel.Controls.Add(this.DelButton, 0, 3);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ZeroButton, 1, 3);
            this.ButtonsTableLayoutPanel.Controls.Add(this.ThreeButton, 2, 2);
            this.ButtonsTableLayoutPanel.Controls.Add(this.TwoButton, 1, 2);
            this.ButtonsTableLayoutPanel.Controls.Add(this.OneButton, 0, 2);
            this.ButtonsTableLayoutPanel.Controls.Add(this.SixButton, 2, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.FiveButton, 1, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.FourButton, 0, 1);
            this.ButtonsTableLayoutPanel.Controls.Add(this.NineButton, 2, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.EightButton, 1, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.SevenButton, 0, 0);
            this.ButtonsTableLayoutPanel.Controls.Add(this.DecimalButton, 2, 3);
            this.ButtonsTableLayoutPanel.Location = new System.Drawing.Point(0, 260);
            this.ButtonsTableLayoutPanel.Name = "ButtonsTableLayoutPanel";
            this.ButtonsTableLayoutPanel.RowCount = 4;
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonsTableLayoutPanel.Size = new System.Drawing.Size(303, 181);
            this.ButtonsTableLayoutPanel.TabIndex = 0;
            // 
            // DelButton
            // 
            this.DelButton.Location = new System.Drawing.Point(3, 138);
            this.DelButton.Name = "DelButton";
            this.DelButton.Size = new System.Drawing.Size(95, 39);
            this.DelButton.TabIndex = 11;
            this.DelButton.Text = "Del";
            this.DelButton.UseVisualStyleBackColor = true;
            this.DelButton.Click += new System.EventHandler(this.DelButton_Click);
            // 
            // ZeroButton
            // 
            this.ZeroButton.Location = new System.Drawing.Point(104, 138);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(95, 39);
            this.ZeroButton.TabIndex = 10;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Location = new System.Drawing.Point(205, 93);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(95, 39);
            this.ThreeButton.TabIndex = 8;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Location = new System.Drawing.Point(104, 93);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(95, 39);
            this.TwoButton.TabIndex = 7;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Location = new System.Drawing.Point(3, 93);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(95, 39);
            this.OneButton.TabIndex = 6;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Location = new System.Drawing.Point(205, 48);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(95, 39);
            this.SixButton.TabIndex = 5;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Location = new System.Drawing.Point(104, 48);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(95, 39);
            this.FiveButton.TabIndex = 4;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Location = new System.Drawing.Point(3, 48);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(95, 39);
            this.FourButton.TabIndex = 3;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Location = new System.Drawing.Point(205, 3);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(95, 39);
            this.NineButton.TabIndex = 2;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Location = new System.Drawing.Point(104, 3);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(95, 39);
            this.EightButton.TabIndex = 1;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Location = new System.Drawing.Point(3, 3);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(95, 39);
            this.SevenButton.TabIndex = 0;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Location = new System.Drawing.Point(205, 138);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(95, 39);
            this.DecimalButton.TabIndex = 9;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton_Click);
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Location = new System.Drawing.Point(12, 21);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(128, 35);
            this.ImperialRadioButton.TabIndex = 1;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            this.ImperialRadioButton.CheckedChanged += new System.EventHandler(this.ImperialRadioButton_CheckedChanged);
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Location = new System.Drawing.Point(186, 21);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(106, 35);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(6, 58);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(144, 31);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "My Height:";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(6, 98);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(149, 31);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "My Weight:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.HeightTextBox.Location = new System.Drawing.Point(159, 62);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.ReadOnly = true;
            this.HeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.HeightTextBox.Enter += new System.EventHandler(this.HeightTextBox_Enter);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.WeightTextBox.Location = new System.Drawing.Point(159, 98);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.ReadOnly = true;
            this.WeightTextBox.Size = new System.Drawing.Size(100, 38);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WeightTextBox.Enter += new System.EventHandler(this.WeightTextBox_Enter);
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Location = new System.Drawing.Point(51, 142);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(203, 43);
            this.CalculateBMIButton.TabIndex = 8;
            this.CalculateBMIButton.Text = "Calculate BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = true;
            this.CalculateBMIButton.Click += new System.EventHandler(this.CalculateBMIButton_Click);
            // 
            // HeightUnitLabel
            // 
            this.HeightUnitLabel.AutoSize = true;
            this.HeightUnitLabel.Location = new System.Drawing.Point(259, 65);
            this.HeightUnitLabel.Name = "HeightUnitLabel";
            this.HeightUnitLabel.Size = new System.Drawing.Size(35, 31);
            this.HeightUnitLabel.TabIndex = 10;
            this.HeightUnitLabel.Text = "in";
            // 
            // WeightUnitLabel
            // 
            this.WeightUnitLabel.AutoSize = true;
            this.WeightUnitLabel.Location = new System.Drawing.Point(261, 98);
            this.WeightUnitLabel.Name = "WeightUnitLabel";
            this.WeightUnitLabel.Size = new System.Drawing.Size(35, 31);
            this.WeightUnitLabel.TabIndex = 11;
            this.WeightUnitLabel.Text = "lb";
            // 
            // BMITextBox
            // 
            this.BMITextBox.BackColor = System.Drawing.SystemColors.Window;
            this.BMITextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BMITextBox.Location = new System.Drawing.Point(104, 187);
            this.BMITextBox.Name = "BMITextBox";
            this.BMITextBox.ReadOnly = true;
            this.BMITextBox.Size = new System.Drawing.Size(95, 38);
            this.BMITextBox.TabIndex = 12;
            this.BMITextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMIScaleTableLayoutPanel
            // 
            this.BMIScaleTableLayoutPanel.ColumnCount = 2;
            this.BMIScaleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47F));
            this.BMIScaleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53F));
            this.BMIScaleTableLayoutPanel.Controls.Add(this.ObeseLabel1, 0, 4);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.label5, 1, 0);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.NormalLabel2, 1, 2);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.OverweightLabel2, 1, 3);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.UnderweightLabel2, 1, 1);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.ObeseLabel2, 0, 4);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.OverweightLabel1, 0, 3);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.NormalLabel1, 0, 2);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.UnderweightLabel1, 0, 1);
            this.BMIScaleTableLayoutPanel.Controls.Add(this.label1, 0, 0);
            this.BMIScaleTableLayoutPanel.Location = new System.Drawing.Point(0, 231);
            this.BMIScaleTableLayoutPanel.Name = "BMIScaleTableLayoutPanel";
            this.BMIScaleTableLayoutPanel.RowCount = 5;
            this.BMIScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01618F));
            this.BMIScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.40618F));
            this.BMIScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78072F));
            this.BMIScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.78072F));
            this.BMIScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.01619F));
            this.BMIScaleTableLayoutPanel.Size = new System.Drawing.Size(303, 210);
            this.BMIScaleTableLayoutPanel.TabIndex = 13;
            this.BMIScaleTableLayoutPanel.Visible = false;
            // 
            // ObeseLabel1
            // 
            this.ObeseLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObeseLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ObeseLabel1.Location = new System.Drawing.Point(3, 175);
            this.ObeseLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.ObeseLabel1.Name = "ObeseLabel1";
            this.ObeseLabel1.Size = new System.Drawing.Size(139, 32);
            this.ObeseLabel1.TabIndex = 15;
            this.ObeseLabel1.Text = "Obese";
            this.ObeseLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(142, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 33);
            this.label5.TabIndex = 9;
            this.label5.Text = "Result";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalLabel2
            // 
            this.NormalLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NormalLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NormalLabel2.Location = new System.Drawing.Point(142, 67);
            this.NormalLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.NormalLabel2.Name = "NormalLabel2";
            this.NormalLabel2.Size = new System.Drawing.Size(158, 54);
            this.NormalLabel2.TabIndex = 11;
            this.NormalLabel2.Text = "between 18.5 and 24.9";
            this.NormalLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverweightLabel2
            // 
            this.OverweightLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverweightLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OverweightLabel2.Location = new System.Drawing.Point(142, 121);
            this.OverweightLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.OverweightLabel2.Name = "OverweightLabel2";
            this.OverweightLabel2.Size = new System.Drawing.Size(158, 54);
            this.OverweightLabel2.TabIndex = 12;
            this.OverweightLabel2.Text = "between 25 and 29.9";
            this.OverweightLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnderweightLabel2
            // 
            this.UnderweightLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderweightLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UnderweightLabel2.Location = new System.Drawing.Point(142, 33);
            this.UnderweightLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.UnderweightLabel2.Name = "UnderweightLabel2";
            this.UnderweightLabel2.Size = new System.Drawing.Size(158, 34);
            this.UnderweightLabel2.TabIndex = 14;
            this.UnderweightLabel2.Text = "less than 18.5";
            this.UnderweightLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ObeseLabel2
            // 
            this.ObeseLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ObeseLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ObeseLabel2.Location = new System.Drawing.Point(142, 175);
            this.ObeseLabel2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 3);
            this.ObeseLabel2.Name = "ObeseLabel2";
            this.ObeseLabel2.Size = new System.Drawing.Size(158, 32);
            this.ObeseLabel2.TabIndex = 6;
            this.ObeseLabel2.Text = "30 or greater";
            this.ObeseLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OverweightLabel1
            // 
            this.OverweightLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OverweightLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.OverweightLabel1.Location = new System.Drawing.Point(3, 121);
            this.OverweightLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.OverweightLabel1.Name = "OverweightLabel1";
            this.OverweightLabel1.Size = new System.Drawing.Size(139, 54);
            this.OverweightLabel1.TabIndex = 7;
            this.OverweightLabel1.Text = "Overweight";
            this.OverweightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NormalLabel1
            // 
            this.NormalLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NormalLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.NormalLabel1.Location = new System.Drawing.Point(3, 67);
            this.NormalLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.NormalLabel1.Name = "NormalLabel1";
            this.NormalLabel1.Size = new System.Drawing.Size(139, 54);
            this.NormalLabel1.TabIndex = 8;
            this.NormalLabel1.Text = "Normal";
            this.NormalLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnderweightLabel1
            // 
            this.UnderweightLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.UnderweightLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnderweightLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.UnderweightLabel1.Location = new System.Drawing.Point(3, 33);
            this.UnderweightLabel1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.UnderweightLabel1.Name = "UnderweightLabel1";
            this.UnderweightLabel1.Size = new System.Drawing.Size(139, 34);
            this.UnderweightLabel1.TabIndex = 13;
            this.UnderweightLabel1.Text = "Underweight";
            this.UnderweightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "BMI Scale";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(205, 187);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(95, 38);
            this.ResetButton.TabIndex = 14;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.BMIScaleTableLayoutPanel);
            this.Controls.Add(this.BMITextBox);
            this.Controls.Add(this.WeightUnitLabel);
            this.Controls.Add(this.HeightUnitLabel);
            this.Controls.Add(this.CalculateBMIButton);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.MetricRadioButton);
            this.Controls.Add(this.ImperialRadioButton);
            this.Controls.Add(this.ButtonsTableLayoutPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BMICalculatorForm_FormClosing);
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.ButtonsTableLayoutPanel.ResumeLayout(false);
            this.BMIScaleTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ButtonsTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.Button ZeroButton;
        private System.Windows.Forms.Button ThreeButton;
        private System.Windows.Forms.Button TwoButton;
        private System.Windows.Forms.Button OneButton;
        private System.Windows.Forms.Button SixButton;
        private System.Windows.Forms.Button FiveButton;
        private System.Windows.Forms.Button FourButton;
        private System.Windows.Forms.Button NineButton;
        private System.Windows.Forms.Button EightButton;
        private System.Windows.Forms.Button SevenButton;
        private System.Windows.Forms.Button DecimalButton;
        private System.Windows.Forms.Button DelButton;
        private System.Windows.Forms.Label HeightUnitLabel;
        private System.Windows.Forms.Label WeightUnitLabel;
        private System.Windows.Forms.TextBox BMITextBox;
        private System.Windows.Forms.TableLayoutPanel BMIScaleTableLayoutPanel;
        private System.Windows.Forms.Label ObeseLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NormalLabel2;
        private System.Windows.Forms.Label OverweightLabel2;
        private System.Windows.Forms.Label UnderweightLabel2;
        private System.Windows.Forms.Label ObeseLabel2;
        private System.Windows.Forms.Label OverweightLabel1;
        private System.Windows.Forms.Label NormalLabel1;
        private System.Windows.Forms.Label UnderweightLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ResetButton;
    }
}

