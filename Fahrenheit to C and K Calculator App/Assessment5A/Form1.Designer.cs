namespace Assessment5A
{
    partial class Form1
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
            this.lblFahrenheitUserInputPrompt = new System.Windows.Forms.Label();
            this.txtBoxTempInFahrenheit = new System.Windows.Forms.TextBox();
            this.lblKelvinUserOutputPrompt = new System.Windows.Forms.Label();
            this.lblOutputKelvin = new System.Windows.Forms.Label();
            this.lblCelsiusUserOutputPrompt = new System.Windows.Forms.Label();
            this.lblOutputCelsius = new System.Windows.Forms.Label();
            this.TemperatureChartListBox = new System.Windows.Forms.ListBox();
            this.lblChartUserPrompt = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFahrenheitUserInputPrompt
            // 
            this.lblFahrenheitUserInputPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrenheitUserInputPrompt.Location = new System.Drawing.Point(152, 159);
            this.lblFahrenheitUserInputPrompt.Name = "lblFahrenheitUserInputPrompt";
            this.lblFahrenheitUserInputPrompt.Size = new System.Drawing.Size(177, 44);
            this.lblFahrenheitUserInputPrompt.TabIndex = 0;
            this.lblFahrenheitUserInputPrompt.Text = "Enter a Temperature in Fahrenheit";
            this.lblFahrenheitUserInputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFahrenheitUserInputPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxTempInFahrenheit
            // 
            this.txtBoxTempInFahrenheit.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTempInFahrenheit.Location = new System.Drawing.Point(379, 172);
            this.txtBoxTempInFahrenheit.Name = "txtBoxTempInFahrenheit";
            this.txtBoxTempInFahrenheit.Size = new System.Drawing.Size(183, 27);
            this.txtBoxTempInFahrenheit.TabIndex = 1;
            this.txtBoxTempInFahrenheit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblKelvinUserOutputPrompt
            // 
            this.lblKelvinUserOutputPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelvinUserOutputPrompt.Location = new System.Drawing.Point(152, 335);
            this.lblKelvinUserOutputPrompt.Name = "lblKelvinUserOutputPrompt";
            this.lblKelvinUserOutputPrompt.Size = new System.Drawing.Size(177, 23);
            this.lblKelvinUserOutputPrompt.TabIndex = 2;
            this.lblKelvinUserOutputPrompt.Text = "The Kelvin value is:";
            this.lblKelvinUserOutputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKelvinUserOutputPrompt.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOutputKelvin
            // 
            this.lblOutputKelvin.BackColor = System.Drawing.Color.White;
            this.lblOutputKelvin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputKelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputKelvin.Location = new System.Drawing.Point(379, 251);
            this.lblOutputKelvin.Name = "lblOutputKelvin";
            this.lblOutputKelvin.Size = new System.Drawing.Size(183, 39);
            this.lblOutputKelvin.TabIndex = 3;
            this.lblOutputKelvin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutputKelvin.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCelsiusUserOutputPrompt
            // 
            this.lblCelsiusUserOutputPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelsiusUserOutputPrompt.Location = new System.Drawing.Point(152, 251);
            this.lblCelsiusUserOutputPrompt.Name = "lblCelsiusUserOutputPrompt";
            this.lblCelsiusUserOutputPrompt.Size = new System.Drawing.Size(185, 39);
            this.lblCelsiusUserOutputPrompt.TabIndex = 4;
            this.lblCelsiusUserOutputPrompt.Text = "The Celsius value is: ";
            this.lblCelsiusUserOutputPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCelsiusUserOutputPrompt.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblOutputCelsius
            // 
            this.lblOutputCelsius.BackColor = System.Drawing.Color.White;
            this.lblOutputCelsius.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputCelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputCelsius.Location = new System.Drawing.Point(379, 318);
            this.lblOutputCelsius.Name = "lblOutputCelsius";
            this.lblOutputCelsius.Size = new System.Drawing.Size(183, 40);
            this.lblOutputCelsius.TabIndex = 5;
            this.lblOutputCelsius.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOutputCelsius.Click += new System.EventHandler(this.label5_Click);
            // 
            // TemperatureChartListBox
            // 
            this.TemperatureChartListBox.FormattingEnabled = true;
            this.TemperatureChartListBox.Location = new System.Drawing.Point(807, 198);
            this.TemperatureChartListBox.Name = "TemperatureChartListBox";
            this.TemperatureChartListBox.Size = new System.Drawing.Size(394, 160);
            this.TemperatureChartListBox.TabIndex = 6;
            // 
            // lblChartUserPrompt
            // 
            this.lblChartUserPrompt.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartUserPrompt.Location = new System.Drawing.Point(804, 113);
            this.lblChartUserPrompt.Name = "lblChartUserPrompt";
            this.lblChartUserPrompt.Size = new System.Drawing.Size(377, 70);
            this.lblChartUserPrompt.TabIndex = 7;
            this.lblChartUserPrompt.Text = "Chart for the pre-calculated values for the Fahrenheit scale from the freezing po" +
    "int of water to the boiling point \r\n (32F -212F)";
            this.lblChartUserPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Firebrick;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(311, 434);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(152, 39);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Firebrick;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(539, 434);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(152, 39);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Firebrick;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(769, 434);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 39);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.Blue;
            this.lblCopyright.Location = new System.Drawing.Point(1155, 522);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(111, 15);
            this.lblCopyright.TabIndex = 11;
            this.lblCopyright.Text = "© Ahmed Matoussi";
            this.lblCopyright.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(333, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(510, 95);
            this.lblWelcome.TabIndex = 12;
            this.lblWelcome.Text = " Welcome to \r\n The F -  C -  K \r\nTemperature convertor";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1298, 546);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblChartUserPrompt);
            this.Controls.Add(this.TemperatureChartListBox);
            this.Controls.Add(this.lblOutputCelsius);
            this.Controls.Add(this.lblCelsiusUserOutputPrompt);
            this.Controls.Add(this.lblOutputKelvin);
            this.Controls.Add(this.lblKelvinUserOutputPrompt);
            this.Controls.Add(this.txtBoxTempInFahrenheit);
            this.Controls.Add(this.lblFahrenheitUserInputPrompt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheitUserInputPrompt;
        private System.Windows.Forms.TextBox txtBoxTempInFahrenheit;
        private System.Windows.Forms.Label lblKelvinUserOutputPrompt;
        private System.Windows.Forms.Label lblOutputKelvin;
        private System.Windows.Forms.Label lblCelsiusUserOutputPrompt;
        private System.Windows.Forms.Label lblOutputCelsius;
        private System.Windows.Forms.ListBox TemperatureChartListBox;
        private System.Windows.Forms.Label lblChartUserPrompt;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblWelcome;
    }
}

