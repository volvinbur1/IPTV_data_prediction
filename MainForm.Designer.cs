namespace IPTV_Qality_Prediction
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AnalyzDataFileOpen_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Analyze_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PolynomialRegression_label = new System.Windows.Forms.Label();
            this.Delay_textBox = new System.Windows.Forms.TextBox();
            this.Jitter_textBox = new System.Windows.Forms.TextBox();
            this.Drops_textBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MultyvariablePolinomialRegression_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SupportVectorMachine_label = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnalyzDataFileOpen_button
            // 
            this.AnalyzDataFileOpen_button.Location = new System.Drawing.Point(127, 12);
            this.AnalyzDataFileOpen_button.Name = "AnalyzDataFileOpen_button";
            this.AnalyzDataFileOpen_button.Size = new System.Drawing.Size(115, 54);
            this.AnalyzDataFileOpen_button.TabIndex = 0;
            this.AnalyzDataFileOpen_button.Text = "Choose file with example data";
            this.AnalyzDataFileOpen_button.UseVisualStyleBackColor = true;
            this.AnalyzDataFileOpen_button.Click += new System.EventHandler(this.AnalyzDataFileOpen_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jitter";
            // 
            // Analyze_button
            // 
            this.Analyze_button.Location = new System.Drawing.Point(131, 83);
            this.Analyze_button.Name = "Analyze_button";
            this.Analyze_button.Size = new System.Drawing.Size(75, 23);
            this.Analyze_button.TabIndex = 3;
            this.Analyze_button.Text = "Analyze";
            this.Analyze_button.UseVisualStyleBackColor = true;
            this.Analyze_button.Click += new System.EventHandler(this.Analyze_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Drops";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(130, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quality";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PolynomialRegression_label
            // 
            this.PolynomialRegression_label.AutoSize = true;
            this.PolynomialRegression_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolynomialRegression_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PolynomialRegression_label.Location = new System.Drawing.Point(158, 152);
            this.PolynomialRegression_label.Name = "PolynomialRegression_label";
            this.PolynomialRegression_label.Size = new System.Drawing.Size(20, 22);
            this.PolynomialRegression_label.TabIndex = 6;
            this.PolynomialRegression_label.Text = "0";
            this.PolynomialRegression_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delay_textBox
            // 
            this.Delay_textBox.Location = new System.Drawing.Point(63, 47);
            this.Delay_textBox.Name = "Delay_textBox";
            this.Delay_textBox.Size = new System.Drawing.Size(56, 20);
            this.Delay_textBox.TabIndex = 7;
            // 
            // Jitter_textBox
            // 
            this.Jitter_textBox.Location = new System.Drawing.Point(140, 47);
            this.Jitter_textBox.Name = "Jitter_textBox";
            this.Jitter_textBox.Size = new System.Drawing.Size(56, 20);
            this.Jitter_textBox.TabIndex = 8;
            // 
            // Drops_textBox
            // 
            this.Drops_textBox.Location = new System.Drawing.Point(219, 47);
            this.Drops_textBox.Name = "Drops_textBox";
            this.Drops_textBox.Size = new System.Drawing.Size(56, 20);
            this.Drops_textBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MultyvariablePolinomialRegression_label);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.SupportVectorMachine_label);
            this.groupBox1.Controls.Add(this.label155);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Delay_textBox);
            this.groupBox1.Controls.Add(this.Analyze_button);
            this.groupBox1.Controls.Add(this.Drops_textBox);
            this.groupBox1.Controls.Add(this.PolynomialRegression_label);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Jitter_textBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 261);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prediction";
            // 
            // MultyvariablePolinomialRegression_label
            // 
            this.MultyvariablePolinomialRegression_label.AutoSize = true;
            this.MultyvariablePolinomialRegression_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.MultyvariablePolinomialRegression_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultyvariablePolinomialRegression_label.Location = new System.Drawing.Point(255, 223);
            this.MultyvariablePolinomialRegression_label.Name = "MultyvariablePolinomialRegression_label";
            this.MultyvariablePolinomialRegression_label.Size = new System.Drawing.Size(20, 22);
            this.MultyvariablePolinomialRegression_label.TabIndex = 12;
            this.MultyvariablePolinomialRegression_label.Text = "0";
            this.MultyvariablePolinomialRegression_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(6, 226);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Polynomial Regression (Multyvariable)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SupportVectorMachine_label
            // 
            this.SupportVectorMachine_label.AutoSize = true;
            this.SupportVectorMachine_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupportVectorMachine_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SupportVectorMachine_label.Location = new System.Drawing.Point(173, 186);
            this.SupportVectorMachine_label.Name = "SupportVectorMachine_label";
            this.SupportVectorMachine_label.Size = new System.Drawing.Size(20, 22);
            this.SupportVectorMachine_label.TabIndex = 12;
            this.SupportVectorMachine_label.Text = "0";
            this.SupportVectorMachine_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label155
            // 
            this.label155.AutoSize = true;
            this.label155.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label155.Location = new System.Drawing.Point(6, 189);
            this.label155.Name = "label155";
            this.label155.Size = new System.Drawing.Size(161, 19);
            this.label155.TabIndex = 11;
            this.label155.Text = "Support Vector Machine";
            this.label155.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Polynomial Regression";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, -1);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 17);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Song ON";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 342);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AnalyzDataFileOpen_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IPTV-prediction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnalyzDataFileOpen_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Analyze_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PolynomialRegression_label;
        private System.Windows.Forms.TextBox Delay_textBox;
        private System.Windows.Forms.TextBox Jitter_textBox;
        private System.Windows.Forms.TextBox Drops_textBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SupportVectorMachine_label;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label MultyvariablePolinomialRegression_label;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

