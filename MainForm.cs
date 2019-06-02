using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPTV_Qality_Prediction
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AnalyzDataFileOpen_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.RestoreDirectory = true;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;            
            }
        }

        private void Analyze_button_Click(object sender, EventArgs e)
        {
            if(!Double.TryParse(Delay_textBox.Text, out delay) || !Double.TryParse(Jitter_textBox.Text, out jitter) || !Double.TryParse(Drops_textBox.Text, out drops))
            {
                MessageBox.Show("Incorrect input! \nEnter positive numbers","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Delay_textBox.Clear();
            Jitter_textBox.Clear();
            Drops_textBox.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }


        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                WMP.URL = @"song.mp3";
                WMP.controls.play();
                WMP.close();
            }


        }
    }
}
