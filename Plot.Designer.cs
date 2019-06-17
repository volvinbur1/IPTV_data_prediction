namespace IP_TV
{
    public partial class Plot
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
            this.ChoosingVariable_comboBox = new System.Windows.Forms.ComboBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.ChoosingAlgorithm_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ChoosingVariable_comboBox
            // 
            this.ChoosingVariable_comboBox.FormattingEnabled = true;
            this.ChoosingVariable_comboBox.Location = new System.Drawing.Point(13, 12);
            this.ChoosingVariable_comboBox.Name = "ChoosingVariable_comboBox";
            this.ChoosingVariable_comboBox.Size = new System.Drawing.Size(162, 24);
            this.ChoosingVariable_comboBox.TabIndex = 0;
            this.ChoosingVariable_comboBox.Text = "Variable integer";
            this.ChoosingVariable_comboBox.SelectedIndexChanged += new System.EventHandler(this.ChoosingVariable_comboBox_SelectedIndexChanged);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(13, 43);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(853, 522);
            this.zedGraphControl1.TabIndex = 1;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // ChoosingAlgorithm_comboBox
            // 
            this.ChoosingAlgorithm_comboBox.FormattingEnabled = true;
            this.ChoosingAlgorithm_comboBox.Location = new System.Drawing.Point(181, 12);
            this.ChoosingAlgorithm_comboBox.Name = "ChoosingAlgorithm_comboBox";
            this.ChoosingAlgorithm_comboBox.Size = new System.Drawing.Size(163, 24);
            this.ChoosingAlgorithm_comboBox.TabIndex = 2;
            this.ChoosingAlgorithm_comboBox.Text = "Algorithm";
            this.ChoosingAlgorithm_comboBox.SelectedIndexChanged += new System.EventHandler(this.ChoosingAlgorithm_comboBox_SelectedIndexChanged);
            // 
            // Plot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 578);
            this.Controls.Add(this.ChoosingAlgorithm_comboBox);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.ChoosingVariable_comboBox);
            this.Name = "Plot";
            this.Text = "Plot";
            this.Load += new System.EventHandler(this.Plot_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ChoosingVariable_comboBox;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.ComboBox ChoosingAlgorithm_comboBox;
    }
}