using Accord.Math;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace IPTV_Qality_Prediction
{
    public partial class Plot_form : Form
    {
        private Algorithm algorithm;

        private bool rebuiltPlot = false;
        private GraphPane pane;
        public Plot_form(Algorithm Obj)
        {
            InitializeComponent();
            algorithm = Obj;
        }

        private void Plot_form_Load(object sender, EventArgs e)
        {
            pane = Plot_zedGraphControl.GraphPane;
            pane.CurveList.Clear();

            pane.XAxis.Title.Text = NetworkStatets_comboBox.Text;
            pane.YAxis.Title.Text = "Degree";
            pane.Title.Text = Algorithm_comboBox.Text;

            pane.AxisChange();
        }

        private void Plot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void Algorithm_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NetworkStatets_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;

            pane.Title.Text = Algorithm_comboBox.SelectedItem.ToString();
            Plot_zedGraphControl.Refresh();
        }

        private void NetworkStatets_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Algorithm_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;

            pane.XAxis.Title.Text = NetworkStatets_comboBox.SelectedItem.ToString();
            Plot_zedGraphControl.Refresh();
        }

        private void ShowDots_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NetworkStatets_comboBox.SelectedIndex > -1 && Algorithm_comboBox.SelectedIndex > -1)
                rebuiltPlot = true;
        }

        private void RebuiltPlot_timer_Tick(object sender, EventArgs e)
        {
            if (rebuiltPlot)
            {
                pane.CurveList.Clear();

                if (Algorithm_comboBox.SelectedItem.ToString() == "Multiple Linear Regression")
                {
                    PointPairList dots = new PointPairList();

                    double[] xArray = algorithm.XYpairMLR[0];
                    double[] yArray = algorithm.XYpairMLR[1];

                    dots.Add(xArray, yArray);
                    LineItem myDots = pane.AddCurve(null, dots, Color.LimeGreen, SymbolType.Circle);

                    myDots.Line.IsVisible = true;
                    myDots.Symbol.Fill.Type = FillType.Solid;
                    myDots.Symbol.Size = 3;
                }

                if (Algorithm_comboBox.SelectedItem.ToString() == "Polynomial Regression")
                {
                    PointPairList dots = new PointPairList();

                    double[] xArray = algorithm.XYpairPL[NetworkStatets_comboBox.SelectedIndex][0];
                    double[] yArray = algorithm.XYpairPL[NetworkStatets_comboBox.SelectedIndex][1];

                    //double[] yArray = new double[algorithm.XYpair[0][1].Length];

                    //for (int i = 0; i < algorithm.XYpair[0][1].Length; i++)
                    //    yArray[i] = (algorithm.XYpair[0][1][i] + algorithm.XYpair[1][1][i] + algorithm.XYpair[2][1][i])/3;

                    dots.Add(xArray, yArray);
                    LineItem myDots = pane.AddCurve(null, dots, Color.LimeGreen, SymbolType.Circle);

                    myDots.Line.IsVisible = true;
                    myDots.Symbol.Fill.Type = FillType.Solid;
                    myDots.Symbol.Size = 3;
                }

                if (ShowDots_checkBox.Checked)
                {
                    PointPairList dots = new PointPairList();

                    double[] xArray = algorithm.NormalizedInputData.GetColumn(NetworkStatets_comboBox.SelectedIndex);
                    double[] yArray = algorithm.PredictedData[Algorithm_comboBox.SelectedIndex];

                    dots.Add(xArray, yArray);
                    LineItem myDots = pane.AddCurve(null, dots, Color.Firebrick, SymbolType.Circle);

                    myDots.Line.IsVisible = false;
                    myDots.Symbol.Fill.Type = FillType.Solid;
                    myDots.Symbol.Size = 3;
                }

                pane.YAxis.Scale.Min = -0.05;
                pane.YAxis.Scale.Max = 1.05;

                //double min = algorithm.NormalizedInputData.GetColumn(NetworkStatets_comboBox.SelectedIndex).Min(),
                //    max = algorithm.NormalizedInputData.GetColumn(NetworkStatets_comboBox.SelectedIndex).Max();

                //int multiper = 0;
                //double temp = max;
                //for (int i = 1; i <= 10000; i *= 10)
                //    if ((int) temp / i == 0)
                //    {
                //        multiper = i;
                //        break;
                //    }
                //    else
                //        temp /= i;

                //pane.XAxis.Scale.Min = min - 0.1 * multiper;
                //pane.XAxis.Scale.Max = max + 0.1 * multiper;

                pane.XAxis.Scale.Min = -0.05;
                pane.XAxis.Scale.Max = 1.05;

                pane.AxisChange();

                Plot_zedGraphControl.Refresh();
                
                rebuiltPlot = false;
            }
        }
    }
}
