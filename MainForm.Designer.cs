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
            this.PredictionElem_groupBox = new System.Windows.Forms.GroupBox();
            this.ErrorMLR_label = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.MultipleLinearRegression_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ErrorSVM_lable = new System.Windows.Forms.Label();
            this.ErrorPR_lable = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SupportVectorMachine_label = new System.Windows.Forms.Label();
            this.label155 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PreviousValues_label = new System.Windows.Forms.Label();
            this.LearningInfo_label = new System.Windows.Forms.Label();
            this.PredictionElem_groupBox.SuspendLayout();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delay";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(164, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jitter";
            // 
            // Analyze_button
            // 
            this.Analyze_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Analyze_button.Location = new System.Drawing.Point(135, 87);
            this.Analyze_button.Name = "Analyze_button";
            this.Analyze_button.Size = new System.Drawing.Size(77, 23);
            this.Analyze_button.TabIndex = 10;
            this.Analyze_button.Text = "Analyze";
            this.Analyze_button.UseVisualStyleBackColor = true;
            this.Analyze_button.Click += new System.EventHandler(this.Analyze_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(239, 23);
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
            this.PolynomialRegression_label.Location = new System.Drawing.Point(155, 153);
            this.PolynomialRegression_label.Name = "PolynomialRegression_label";
            this.PolynomialRegression_label.Size = new System.Drawing.Size(20, 22);
            this.PolynomialRegression_label.TabIndex = 6;
            this.PolynomialRegression_label.Text = "0";
            this.PolynomialRegression_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Delay_textBox
            // 
            this.Delay_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delay_textBox.Location = new System.Drawing.Point(71, 39);
            this.Delay_textBox.Name = "Delay_textBox";
            this.Delay_textBox.Size = new System.Drawing.Size(56, 20);
            this.Delay_textBox.TabIndex = 7;
            // 
            // Jitter_textBox
            // 
            this.Jitter_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Jitter_textBox.Location = new System.Drawing.Point(148, 39);
            this.Jitter_textBox.Name = "Jitter_textBox";
            this.Jitter_textBox.Size = new System.Drawing.Size(56, 20);
            this.Jitter_textBox.TabIndex = 8;
            // 
            // Drops_textBox
            // 
            this.Drops_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Drops_textBox.Location = new System.Drawing.Point(227, 39);
            this.Drops_textBox.Name = "Drops_textBox";
            this.Drops_textBox.Size = new System.Drawing.Size(56, 20);
            this.Drops_textBox.TabIndex = 9;
            // 
            // PredictionElem_groupBox
            // 
            this.PredictionElem_groupBox.Controls.Add(this.PreviousValues_label);
            this.PredictionElem_groupBox.Controls.Add(this.ErrorMLR_label);
            this.PredictionElem_groupBox.Controls.Add(this.label9);
            this.PredictionElem_groupBox.Controls.Add(this.MultipleLinearRegression_label);
            this.PredictionElem_groupBox.Controls.Add(this.label8);
            this.PredictionElem_groupBox.Controls.Add(this.ErrorSVM_lable);
            this.PredictionElem_groupBox.Controls.Add(this.ErrorPR_lable);
            this.PredictionElem_groupBox.Controls.Add(this.label5);
            this.PredictionElem_groupBox.Controls.Add(this.label7);
            this.PredictionElem_groupBox.Controls.Add(this.SupportVectorMachine_label);
            this.PredictionElem_groupBox.Controls.Add(this.label155);
            this.PredictionElem_groupBox.Controls.Add(this.label6);
            this.PredictionElem_groupBox.Controls.Add(this.Delay_textBox);
            this.PredictionElem_groupBox.Controls.Add(this.Analyze_button);
            this.PredictionElem_groupBox.Controls.Add(this.Drops_textBox);
            this.PredictionElem_groupBox.Controls.Add(this.PolynomialRegression_label);
            this.PredictionElem_groupBox.Controls.Add(this.label3);
            this.PredictionElem_groupBox.Controls.Add(this.label1);
            this.PredictionElem_groupBox.Controls.Add(this.label2);
            this.PredictionElem_groupBox.Controls.Add(this.label4);
            this.PredictionElem_groupBox.Controls.Add(this.Jitter_textBox);
            this.PredictionElem_groupBox.Enabled = false;
            this.PredictionElem_groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PredictionElem_groupBox.Location = new System.Drawing.Point(12, 72);
            this.PredictionElem_groupBox.Name = "PredictionElem_groupBox";
            this.PredictionElem_groupBox.Size = new System.Drawing.Size(340, 258);
            this.PredictionElem_groupBox.TabIndex = 10;
            this.PredictionElem_groupBox.TabStop = false;
            this.PredictionElem_groupBox.Text = "Prediction";
            // 
            // ErrorMLR_label
            // 
            this.ErrorMLR_label.AutoSize = true;
            this.ErrorMLR_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorMLR_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorMLR_label.Location = new System.Drawing.Point(273, 224);
            this.ErrorMLR_label.Name = "ErrorMLR_label";
            this.ErrorMLR_label.Size = new System.Drawing.Size(35, 22);
            this.ErrorMLR_label.TabIndex = 19;
            this.ErrorMLR_label.Text = "0%";
            this.ErrorMLR_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label9.Location = new System.Drawing.Point(227, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Error";
            // 
            // MultipleLinearRegression_label
            // 
            this.MultipleLinearRegression_label.AutoSize = true;
            this.MultipleLinearRegression_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MultipleLinearRegression_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MultipleLinearRegression_label.Location = new System.Drawing.Point(174, 224);
            this.MultipleLinearRegression_label.Name = "MultipleLinearRegression_label";
            this.MultipleLinearRegression_label.Size = new System.Drawing.Size(20, 22);
            this.MultipleLinearRegression_label.TabIndex = 17;
            this.MultipleLinearRegression_label.Text = "0";
            this.MultipleLinearRegression_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Multiple Linear Regression";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorSVM_lable
            // 
            this.ErrorSVM_lable.AutoSize = true;
            this.ErrorSVM_lable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorSVM_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorSVM_lable.Location = new System.Drawing.Point(273, 187);
            this.ErrorSVM_lable.Name = "ErrorSVM_lable";
            this.ErrorSVM_lable.Size = new System.Drawing.Size(35, 22);
            this.ErrorSVM_lable.TabIndex = 15;
            this.ErrorSVM_lable.Text = "0%";
            this.ErrorSVM_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ErrorPR_lable
            // 
            this.ErrorPR_lable.AutoSize = true;
            this.ErrorPR_lable.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorPR_lable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ErrorPR_lable.Location = new System.Drawing.Point(273, 153);
            this.ErrorPR_lable.Name = "ErrorPR_lable";
            this.ErrorPR_lable.Size = new System.Drawing.Size(35, 22);
            this.ErrorPR_lable.TabIndex = 14;
            this.ErrorPR_lable.Text = "0%";
            this.ErrorPR_lable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label5.Location = new System.Drawing.Point(227, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Error";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.label7.Location = new System.Drawing.Point(227, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Error";
            // 
            // SupportVectorMachine_label
            // 
            this.SupportVectorMachine_label.AutoSize = true;
            this.SupportVectorMachine_label.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SupportVectorMachine_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SupportVectorMachine_label.Location = new System.Drawing.Point(165, 187);
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
            // PreviousValues_label
            // 
            this.PreviousValues_label.AutoSize = true;
            this.PreviousValues_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PreviousValues_label.Location = new System.Drawing.Point(10, 69);
            this.PreviousValues_label.Name = "PreviousValues_label";
            this.PreviousValues_label.Size = new System.Drawing.Size(82, 13);
            this.PreviousValues_label.TabIndex = 20;
            this.PreviousValues_label.Text = "Previous values";
            this.PreviousValues_label.Visible = false;
            // 
            // LearningInfo_label
            // 
            this.LearningInfo_label.AutoSize = true;
            this.LearningInfo_label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LearningInfo_label.ForeColor = System.Drawing.Color.Red;
            this.LearningInfo_label.Location = new System.Drawing.Point(19, 9);
            this.LearningInfo_label.Name = "LearningInfo_label";
            this.LearningInfo_label.Size = new System.Drawing.Size(77, 57);
            this.LearningInfo_label.TabIndex = 11;
            this.LearningInfo_label.Text = "Algorithm\r\nis not\r\nlearned";
            this.LearningInfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 342);
            this.Controls.Add(this.LearningInfo_label);
            this.Controls.Add(this.PredictionElem_groupBox);
            this.Controls.Add(this.AnalyzDataFileOpen_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IPTV-prediction";
            this.PredictionElem_groupBox.ResumeLayout(false);
            this.PredictionElem_groupBox.PerformLayout();
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
        private System.Windows.Forms.GroupBox PredictionElem_groupBox;
        private System.Windows.Forms.Label SupportVectorMachine_label;
        private System.Windows.Forms.Label label155;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label ErrorSVM_lable;
        private System.Windows.Forms.Label ErrorPR_lable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ErrorMLR_label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label MultipleLinearRegression_label;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PreviousValues_label;
        private System.Windows.Forms.Label LearningInfo_label;
    }
}

