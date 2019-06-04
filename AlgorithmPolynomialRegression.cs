using System;
using System.Reflection;
using Accord.Statistics.Models.Regression.Linear;

namespace IPTV_Qality_Prediction
{
    public partial class Algorithm
    {
        private double[][] LearningData;
        private double[] coefOfFunction;
        private double[][] coefOfFunctionEachVar = new double[3][];

        public double Delay { get; set; }
        public double Jitter { get; set; }
        public double Drops { get; set; }

        public Algorithm(double[][] array)
        {
            LearningData = array;
        }

        public int PolynomialRegressionPediction()
        {
            int qualityMark = 0;

            int func(int i, double x)
            {
                double y = 0;
                for (int j = 0; j <= coefOfFunctionEachVar.Length; j++)
                    y += coefOfFunctionEachVar[i][j] * Math.Pow(x, j);

                return (int)Math.Round(y);
            }

            qualityMark += func(0, Delay);
            qualityMark += func(1, Jitter);
            qualityMark += func(2, Drops);
            return (int)Math.Round((double)(qualityMark/3));
        }

        private double[] PRLearning(int degree, double[][] independentVariables, double[][] dependentVariables)
        {
            PolynomialRegression objRegression =
                PolynomialRegression.FromData(degree, independentVariables, dependentVariables);

            OrdinaryLeastSquares ols = new OrdinaryLeastSquares();

            MultivariateLinearRegression regression = ols.Learn(independentVariables, dependentVariables);


            double[] coef = new double[objRegression.Weights.Length + 1];

            coef[0] = objRegression.Intercept;

            int index = objRegression.Weights.Length - 1;

            for (int i = 1; i <= objRegression.Weights.Length; i++)
            {
                coef[i] = objRegression.Weights[index];
                index--;
            }
            return coef;
        }

        public void PolynomialRegressionLearning()
        {
            int n = LearningData.Length;
            double[] dependentVariables = new double[n], independentVariables = new double[n];

            for (int j = 0; j < n; j++)
                dependentVariables[j] = LearningData[j][3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < n; j++)
                    independentVariables[j] = LearningData[j][i];
                coefOfFunctionEachVar[i] = PRLearning(3, independentVariables, dependentVariables);
            }
        }
    }
}
