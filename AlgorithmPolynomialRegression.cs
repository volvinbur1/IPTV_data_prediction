using System;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Models.Regression.Linear;

namespace IPTV_Qality_Prediction
{
    public partial class Algorithm
    {
        internal double[][] LearningData;
        internal double[][] PredictedData = new double[3][];
        private double errorPR = 0;
        private double delay;
        private double jitter;
        private double drops;
        
        public double ErrorMLR { get; private set; } = 0;

        public double ErrorPR
        {
            get { return errorPR / 3; }
        }
      
        public Algorithm(double[][] array)
        {
            LearningData = array;
        }

        private PolynomialRegression[] objRegression = new PolynomialRegression[3];
        private MultipleLinearRegression multipleLinearRegressionObj;

        public double PolynomialRegressionPediction()
        {
            double prediction = Math.Abs(objRegression[0].Transform(delay));
            prediction += Math.Abs(objRegression[1].Transform(jitter));
            prediction += Math.Abs(objRegression[2].Transform(jitter));
            return prediction / 3;
        }

        public double MultipleLinearRegressionPrediction()
        {
            double[] input = new double[] {delay, jitter, drops};
            double prediction = multipleLinearRegressionObj.Transform(input);
            return prediction;
        }

        public double[][][] XYpairPL = new double[3][][];
        private double[][] predictionPL = new double[3][];
        private int indexPredictionPL = 0;
        private PolynomialRegression PRLearning(double[] independentVariables, double[] dependentVariables)
        {
            var polyTeacher = new PolynomialLeastSquares()
            {
                Degree = 6
            };

            PolynomialRegression objRegressionLocal = polyTeacher.Learn(independentVariables, dependentVariables);

            double[] prediction = objRegressionLocal.Transform(independentVariables);

            predictionPL[indexPredictionPL] = prediction;
            
            //PredictedData[1] = prediction;

            errorPR += new SquareLoss(independentVariables).Loss(prediction);

            double[] coefOfFunction = new double[objRegressionLocal.Weights.Length + 1];
            coefOfFunction[0] = objRegressionLocal.Intercept;

            int index = objRegressionLocal.Weights.Length - 1;

            for (int i = 1; i <= objRegressionLocal.Weights.Length; i++)
            {
                coefOfFunction[i] = objRegressionLocal.Weights[index];
                index--;
            }

            double func(double x)
            {
                double y = 0;
                for (int i = 0; i <= polyTeacher.Degree; i++)
                    y += coefOfFunction[i] * Math.Pow(x, i);
                return y;
            }

            double min = NormalizedInputData.GetColumn(indexPredictionPL).Min(),
                max = NormalizedInputData.GetColumn(indexPredictionPL).Max();

            XYpairPL[indexPredictionPL] = new double[2][];
            XYpairPL[indexPredictionPL][0] = new double[100];
            XYpairPL[indexPredictionPL][1] = new double[100];

            index = 0;
            for (double i = min; i <= max; i+=0.01)
            {
                XYpairPL[indexPredictionPL][0][index] = i;
                XYpairPL[indexPredictionPL][1][index] = func(i);
                index++;
            }

            indexPredictionPL++;

            return objRegressionLocal;
        }

        public void PolynomialRegressionLearning()
        {
            int n = LearningData.Length;
            double[] dependentVariables = LearningData.GetColumn(3);
            double[] independentVariables = new double[n];
           
            //InputDataNormalization();
            for (int i = 0; i < 3; i++)
            {
                independentVariables = NormalizedInputData.GetColumn(i);
                objRegression[i] = PRLearning(independentVariables, dependentVariables);
            }

            PredictedData[1] = new double[predictionPL[0].Length];

            for (int i = 0; i < predictionPL[0].Length; i++)
            {
                PredictedData[1][i] = (predictionPL[0][i] + predictionPL[1][i] + predictionPL[2][i]) / 3;
            }
        }

        public double[][] XYpairMLR = new double[2][];

        public void MultipleLinearRegressionLearning()
        {
            int n = LearningData.Length;
            double[] dependentVariables = LearningData.GetColumn(3);
            double[][] independentVariables = new double[n][];

            for (int j = 0; j < n; j++)
                dependentVariables[j] = LearningData[j][3];

            for (int j = 0; j < n; j++)
            {
                independentVariables[j] = new double[3];
                independentVariables[j][0] = NormalizedInputData[j][0];
                independentVariables[j][1] = NormalizedInputData[j][1];
                independentVariables[j][2] = NormalizedInputData[j][2];
            }

            multipleLinearRegressionObj = MultipleLinearRegression.FromData(independentVariables, dependentVariables);
            double[] prediction = multipleLinearRegressionObj.Transform(independentVariables);

            PredictedData[0] = prediction;

            ErrorMLR = new SquareLoss(dependentVariables).Loss(prediction);

            double[] coefOfFunction = new double[multipleLinearRegressionObj.Weights.Length + 1];
            coefOfFunction[0] = multipleLinearRegressionObj.Intercept;

            int index = multipleLinearRegressionObj.Weights.Length - 1;

            for (int i = 1; i <= multipleLinearRegressionObj.Weights.Length; i++)
            {
                coefOfFunction[i] = multipleLinearRegressionObj.Weights[index];
                index--;
            }

            double func(double _x1, double _x2, double _x3) =>
                (coefOfFunction[0] + coefOfFunction[3] * _x1 + coefOfFunction[2] * _x2 + coefOfFunction[1] * _x3);

            XYpairMLR[0] = new double[100];
            XYpairMLR[1] = new double[100];

            for (int i = 0; i < 100; i++)
            {
                XYpairMLR[0][i] = i;
                XYpairMLR[1][i] = func(i, i, i);
            }
        }
    }
}
