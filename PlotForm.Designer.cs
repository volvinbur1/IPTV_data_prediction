namespace IPTV_Qality_Prediction
{
    partial class Plot_form
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
            this.components = new System.ComponentModel.Container();
            this.Algorithm_comboBox = new System.Windows.Forms.ComboBox();
            this.NetworkStatets_comboBox = new System.Windows.Forms.ComboBox();
            this.ShowDots_checkBox = new System.Windows.Forms.CheckBox();
            this.RebuiltPlot_timer = new System.Windows.Forms.Timer(this.components);
            this.Plot_zedGraphControl = new ZedGraph.ZedGraphControl();
            this.SuspendLayout();
            // 
            // Algorithm_comboBox
            // 
            this.Algorithm_comboBox.FormattingEnabled = true;
            this.Algorithm_comboBox.Items.AddRange(new object[] {
            "Multiple Linear Regression",
            "Polynomial Regression",
            "Support Vector Machine"});
            this.Algorithm_comboBox.Location = new System.Drawing.Point(12, 10);
            this.Algorithm_comboBox.Name = "Algorithm_comboBox";
            this.Algorithm_comboBox.Size = new System.Drawing.Size(164, 21);
            this.Algorithm_comboBox.TabIndex = 0;
            this.Algorithm_comboBox.Text = "Choose prediction algorithm";
            this.Algorithm_comboBox.SelectedIndexChanged += new System.EventHandler(this.Algorithm_comboBox_SelectedIndexChanged);
            // 
            // NetworkStatets_comboBox
            // 
            this.NetworkStatets_comboBox.FormattingEnabled = true;
            this.NetworkStatets_comboBox.Items.AddRange(new object[] {
            "Delay",
            "Jitter",
            "Drops"});
            this.NetworkStatets_comboBox.Location = new System.Drawing.Point(205, 10);
            this.NetworkStatets_comboBox.Name = "NetworkStatets_comboBox";
            this.NetworkStatets_comboBox.Size = new System.Drawing.Size(164, 21);
            this.NetworkStatets_comboBox.TabIndex = 1;
            this.NetworkStatets_comboBox.Text = "Choose network type states ";
            this.NetworkStatets_comboBox.SelectedIndexChanged += new System.EventHandler(this.NetworkStatets_comboBox_SelectedIndexChanged);
            // 
            // ShowDots_checkBox
            // 
            this.ShowDots_checkBox.AutoSize = true;
            this.ShowDots_checkBox.Location = new System.Drawing.Point(400, 12);
            this.ShowDots_checkBox.Name = "ShowDots_checkBox";
            this.ShowDots_checkBox.Size = new System.Drawing.Size(76, 17);
            this.ShowDots_checkBox.TabIndex = 2;
            this.ShowDots_checkBox.Text = "Show dots";
            this.ShowDots_checkBox.UseVisualStyleBackColor = true;
            this.ShowDots_checkBox.CheckedChanged += new System.EventHandler(this.ShowDots_checkBox_CheckedChanged);
            // 
            // RebuiltPlot_timer
            // 
            this.RebuiltPlot_timer.Enabled = true;
            this.RebuiltPlot_timer.Tick += new System.EventHandler(this.RebuiltPlot_timer_Tick);
            // 
            // Plot_zedGraphControl
            // 
            this.Plot_zedGraphControl.Location = new System.Drawing.Point(12, 47);
            this.Plot_zedGraphControl.Name = "Plot_zedGraphControl";
            this.Plot_zedGraphControl.ScrollGrace = 0D;
            this.Plot_zedGraphControl.ScrollMaxX = 0D;
            this.Plot_zedGraphControl.ScrollMaxY = 0D;
            this.Plot_zedGraphControl.ScrollMaxY2 = 0D;
            this.Plot_zedGraphControl.ScrollMinX = 0D;
            this.Plot_zedGraphControl.ScrollMinY = 0D;
            this.Plot_zedGraphControl.ScrollMinY2 = 0D;
            this.Plot_zedGraphControl.Size = new System.Drawing.Size(788, 528);
            this.Plot_zedGraphControl.TabIndex = 3;
            this.Plot_zedGraphControl.UseExtendedPrintDialog = true;
            // 
            // Plot_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 587);
            this.Controls.Add(this.Plot_zedGraphControl);
            this.Controls.Add(this.ShowDots_checkBox);
            this.Controls.Add(this.NetworkStatets_comboBox);
            this.Controls.Add(this.Algorithm_comboBox);
            this.Name = "Plot_form";
            this.Text = "Plots";
            this.Load += new System.EventHandler(this.Plot_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Algorithm_comboBox;
        private System.Windows.Forms.ComboBox NetworkStatets_comboBox;
        private System.Windows.Forms.CheckBox ShowDots_checkBox;
        private System.Windows.Forms.Timer RebuiltPlot_timer;
        private ZedGraph.ZedGraphControl Plot_zedGraphControl;
    }
}