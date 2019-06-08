using System;
using System.Data;
using System.Reflection;
using Accord.Math;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Models.Regression.Linear;

namespace IPTV_Qality_Prediction
{
    public partial class Algorithm
    {
        private double[][] LearningData;
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

        private PolynomialRegression[] objRegression;
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

        private PolynomialRegression PRLearning(double[] independentVariables, double[] dependentVariables)
        {
            var polyTeacher = new PolynomialLeastSquares()
            {
                Degree = 6
            };

            PolynomialRegression objRegressionLocal = polyTeacher.Learn(independentVariables, dependentVariables);

            double[] prediction = objRegressionLocal.Transform(independentVariables);

            errorPR += new SquareLoss(independentVariables).Loss(prediction);

            return objRegressionLocal;
        }

        public void PolynomialRegressionLearning()
        {
            int n = LearningData.Length;
            double[] dependentVariables = LearningData.GetColumn(3);
            double[] independentVariables = new double[n];
            objRegression = new PolynomialRegression[n];
           
            //InputDataNormalization();
            for (int i = 0; i < 3; i++)
            {
                independentVariables = NormalizedInputData.GetColumn(i);
                objRegression[i] = PRLearning(independentVariables, dependentVariables);
            }
        }

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
            ErrorMLR = new SquareLoss(dependentVariables).Loss(prediction);
        }
    }
}
