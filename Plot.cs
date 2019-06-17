using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZedGraph;
using IPTV_Qality_Prediction;
using Accord.Math;

namespace IP_TV
{
    public partial class Plot : Form
    {
        private Algorithm algorithm;
        public Plot(Algorithm Obj)
        {
            InitializeComponent();
            algorithm = Obj;
        }

        GraphPane pane;

        private void Plot_Load(object sender, EventArgs e)
        {
            pane = zedGraphControl1.GraphPane;
            pane.CurveList.Clear();
            
            pane.XAxis.Title.Text = ChoosingVariable_comboBox.Text;
            pane.YAxis.Title.Text = "Degree";
            pane.Title.Text = ChoosingAlgorithm_comboBox.Text;
          
            pane.AxisChange();

            string[] comboBoxComponent = new string[]
            {
                "Polynomial Regression",
                "SVM",
                "Multiple Lineal Regression"
            };

            ChoosingAlgorithm_comboBox.Items.AddRange(comboBoxComponent);

            string[] comboBoxComponent1 = new string[]
            {
                "Delay",
                "Jitter",
                "Drops"
            };

            ChoosingVariable_comboBox.Items.AddRange(comboBoxComponent1);
        }

        private void ChoosingVariable_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChoosingAlgorithm_comboBox.SelectedIndex > -1)
            {
                PointPairList dots = new PointPairList();

                double[] xArray = algorithm.LearningData.GetColumn(ChoosingVariable_comboBox.SelectedIndex);
                double[] yArray = algorithm.PredictedData[ChoosingAlgorithm_comboBox.SelectedIndex];

                dots.Add(xArray, yArray);
                LineItem myDots = pane.AddCurve(null, dots, Color.Firebrick, SymbolType.Circle);

                myDots.Line.IsVisible = false;
                myDots.Symbol.Fill.Color = Color.Firebrick;
                myDots.Symbol.Fill.Type = FillType.Solid;
                myDots.Symbol.Size = 3;

                pane.XAxis.Title.Text = ChoosingVariable_comboBox.Text;

                pane.AxisChange();
                pane.AxisChange();

            }
        }

        private void ChoosingAlgorithm_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChoosingVariable_comboBox.SelectedIndex > -1)
            {
                PointPairList dots = new PointPairList();

                double[] xArray = algorithm.LearningData.GetColumn(ChoosingVariable_comboBox.SelectedIndex);
                double[] yArray = algorithm.PredictedData[ChoosingAlgorithm_comboBox.SelectedIndex];

                dots.Add(xArray, yArray);

                LineItem myDots = pane.AddCurve(null, dots, Color.Firebrick, SymbolType.Circle);

                myDots.Line.IsVisible = false;
                myDots.Symbol.Fill.Color = Color.Firebrick;
                myDots.Symbol.Fill.Type = FillType.Solid;
                myDots.Symbol.Size = 3;

                pane.Title.Text = ChoosingAlgorithm_comboBox.Text;

                pane.AxisChange();
                pane.AxisChange();
            }
        }
        private void Plot_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
