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

        private Algorithm algorithmObj;

        private void AnalyzDataFileOpen_button_Click(object sender, EventArgs e)
        {
            string path;

            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog.FileName;
                algorithmObj = new Algorithm(WorkWithLearningData.ReadFromFile(path));
            }
        }

        private void Analyze_button_Click(object sender, EventArgs e)
        {
            if (algorithmObj != null)
            {
                if (!Double.TryParse(Delay_textBox.Text, out double delay) ||
                    !Double.TryParse(Jitter_textBox.Text, out double jitter) ||
                    !Double.TryParse(Drops_textBox.Text, out double drops))
                {
                    MessageBox.Show("Incorrect input!\nEnter positive integers", "ERROR", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    algorithmObj.PolynomialRegressionLearning();
                    algorithmObj.SupportVectorMachineLearning();
                }

                Delay_textBox.Clear();
                Jitter_textBox.Clear();
                Drops_textBox.Clear();
            }
            else
            {
                MessageBox.Show("Please, choose file with learning data", "OOOPS!(", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
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
