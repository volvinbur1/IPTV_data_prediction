using System;
using System.Drawing;
using System.Security;
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
                try
                {
                    path = openFileDialog.FileName;
                    UseWaitCursor = true;
                    algorithmObj = new Algorithm(WorkWithLearningData.ReadFromFile(path));

                    algorithmObj.LearningDataNormalization();

                    algorithmObj.PolynomialRegressionLearning();
                    algorithmObj.MultipleLinearRegressionLearning();
                    algorithmObj.SupportVectorMachineLearning();

                    ErrorPR_lable.Text = $"{Math.Round(algorithmObj.ErrorPR, 3) * 100}%";
                    ErrorSVM_lable.Text = $"{Math.Round(algorithmObj.ErrorSVM, 3) * 100}%";
                    ErrorMLR_label.Text = $"{Math.Round(algorithmObj.ErrorMLR, 3) * 100}%";

                    LearningInfo_label.Text = "Algorithm\nis\nlearned";
                    LearningInfo_label.ForeColor = Color.Green;

                    PredictionElem_groupBox.Enabled = true;
                    AnalyzDataFileOpen_button.Enabled = false;

                    UseWaitCursor = false;
                }
                catch (SecurityException)
                {
                    UseWaitCursor = false;
                    MessageBox.Show("You have not enought permision");
                }
                catch (FormatException)
                {
                    UseWaitCursor = false;
                    MessageBox.Show("Inappropriate learning data");
                }
                catch (Exception exception)
                {
                    UseWaitCursor = false;
                    MessageBox.Show(exception.Message);
                }
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
                    algorithmObj.Delay = delay;
                    algorithmObj.Jitter = jitter;
                    algorithmObj.Drops = drops;

                    PolynomialRegression_label.Text = Math.Round(algorithmObj.PolynomialRegressionPediction(), 3).ToString();
                    MultipleLinearRegression_label.Text = Math.Round(algorithmObj.MultipleLinearRegressionPrediction(), 3).ToString();
                    SupportVectorMachine_label.Text = algorithmObj.SupportVectorMachinePrediction().ToString();

                    PreviousValues_label.Text = $"Previous values:  {delay}     {jitter}     {drops}";
                    PreviousValues_label.Visible = true;
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
    }
}
