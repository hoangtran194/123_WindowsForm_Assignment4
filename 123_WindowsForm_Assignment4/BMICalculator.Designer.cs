namespace _123_WindowsForm_Assignment4
{
    partial class BMICalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BMICalculator));
            this.dataTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.metricRadioButton = new System.Windows.Forms.RadioButton();
            this.imperialRadioButton = new System.Windows.Forms.RadioButton();
            this.myHeightLabel = new System.Windows.Forms.Label();
            this.myWeightLabel = new System.Windows.Forms.Label();
            this.optionLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.myHeightTextBox = new _123_WindowsForm_Assignment4.WaterMarkTextBox();
            this.myWeightTextBox = new _123_WindowsForm_Assignment4.WaterMarkTextBox();
            this.dataTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableLayout
            // 
            this.dataTableLayout.BackColor = System.Drawing.Color.White;
            this.dataTableLayout.ColumnCount = 3;
            this.dataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.dataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.dataTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.dataTableLayout.Controls.Add(this.myHeightTextBox, 1, 0);
            this.dataTableLayout.Controls.Add(this.myWeightTextBox, 1, 1);
            this.dataTableLayout.Controls.Add(this.metricRadioButton, 1, 2);
            this.dataTableLayout.Controls.Add(this.imperialRadioButton, 2, 2);
            this.dataTableLayout.Controls.Add(this.myHeightLabel, 0, 0);
            this.dataTableLayout.Controls.Add(this.myWeightLabel, 0, 1);
            this.dataTableLayout.Controls.Add(this.optionLabel, 0, 2);
            this.dataTableLayout.Location = new System.Drawing.Point(2, 12);
            this.dataTableLayout.Name = "dataTableLayout";
            this.dataTableLayout.RowCount = 3;
            this.dataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.dataTableLayout.Size = new System.Drawing.Size(756, 217);
            this.dataTableLayout.TabIndex = 5;
            // 
            // metricRadioButton
            // 
            this.metricRadioButton.AutoSize = true;
            this.metricRadioButton.Location = new System.Drawing.Point(305, 147);
            this.metricRadioButton.Name = "metricRadioButton";
            this.metricRadioButton.Size = new System.Drawing.Size(204, 65);
            this.metricRadioButton.TabIndex = 2;
            this.metricRadioButton.TabStop = true;
            this.metricRadioButton.Text = "Metric";
            this.metricRadioButton.UseVisualStyleBackColor = true;
            this.metricRadioButton.CheckedChanged += new System.EventHandler(this.metricRadioButton_CheckedChanged);
            // 
            // imperialRadioButton
            // 
            this.imperialRadioButton.AutoSize = true;
            this.imperialRadioButton.Location = new System.Drawing.Point(531, 147);
            this.imperialRadioButton.Name = "imperialRadioButton";
            this.imperialRadioButton.Size = new System.Drawing.Size(222, 65);
            this.imperialRadioButton.TabIndex = 3;
            this.imperialRadioButton.TabStop = true;
            this.imperialRadioButton.Text = "Imperial";
            this.imperialRadioButton.UseVisualStyleBackColor = true;
            this.imperialRadioButton.CheckedChanged += new System.EventHandler(this.imperialRadioButton_CheckedChanged);
            // 
            // myHeightLabel
            // 
            this.myHeightLabel.AutoSize = true;
            this.myHeightLabel.Location = new System.Drawing.Point(3, 0);
            this.myHeightLabel.Name = "myHeightLabel";
            this.myHeightLabel.Size = new System.Drawing.Size(265, 61);
            this.myHeightLabel.TabIndex = 4;
            this.myHeightLabel.Text = "My Height";
            // 
            // myWeightLabel
            // 
            this.myWeightLabel.AutoSize = true;
            this.myWeightLabel.Location = new System.Drawing.Point(3, 72);
            this.myWeightLabel.Name = "myWeightLabel";
            this.myWeightLabel.Size = new System.Drawing.Size(277, 61);
            this.myWeightLabel.TabIndex = 5;
            this.myWeightLabel.Text = "My Weight";
            // 
            // optionLabel
            // 
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(3, 144);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(183, 61);
            this.optionLabel.TabIndex = 6;
            this.optionLabel.Text = "Option";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(197, 278);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(370, 87);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate BMI";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Location = new System.Drawing.Point(16, 413);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(731, 180);
            this.resultTextBox.TabIndex = 7;
            // 
            // myHeightTextBox
            // 
            this.myHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableLayout.SetColumnSpan(this.myHeightTextBox, 2);
            this.myHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myHeightTextBox.Location = new System.Drawing.Point(305, 3);
            this.myHeightTextBox.Name = "myHeightTextBox";
            this.myHeightTextBox.Size = new System.Drawing.Size(448, 67);
            this.myHeightTextBox.TabIndex = 0;
            this.myHeightTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.myHeightTextBox.WaterMarkText = "Water Mark";
            this.myHeightTextBox.TextChanged += new System.EventHandler(this.myHeightTextBox_TextChanged);
            this.myHeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myHeightTextBox_KeyPress);
            // 
            // myWeightTextBox
            // 
            this.myWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataTableLayout.SetColumnSpan(this.myWeightTextBox, 2);
            this.myWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myWeightTextBox.Location = new System.Drawing.Point(305, 75);
            this.myWeightTextBox.Name = "myWeightTextBox";
            this.myWeightTextBox.Size = new System.Drawing.Size(448, 67);
            this.myWeightTextBox.TabIndex = 1;
            this.myWeightTextBox.WaterMarkColor = System.Drawing.Color.Gray;
            this.myWeightTextBox.WaterMarkText = "Water Mark";
            this.myWeightTextBox.TextChanged += new System.EventHandler(this.myWeightTextBox_TextChanged);
            this.myWeightTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.myWeightTextBox_KeyPress);
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(31F, 61F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 998);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dataTableLayout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dataTableLayout.ResumeLayout(false);
            this.dataTableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel dataTableLayout;
        private WaterMarkTextBox myHeightTextBox;
        private WaterMarkTextBox myWeightTextBox;
        private System.Windows.Forms.RadioButton metricRadioButton;
        private System.Windows.Forms.RadioButton imperialRadioButton;
        private System.Windows.Forms.Label myHeightLabel;
        private System.Windows.Forms.Label myWeightLabel;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

