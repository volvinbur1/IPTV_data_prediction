using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPTV_Qality_Prediction
{
    public static partial class Algorithm
    {
        private double[][] LearningData;
        private double[] coefOfFunction;

        public Algorithm(double[][] array)
        {
            LearningData = array;
        }

        private void PRLearningOneIndVar(int degree, double[] independentVariables, double[] dependentVariables)
        {
            PolynomialRegression objRegression =
                PolynomialRegression.FromData(degree, independentVariables, dependentVariables);

            coefOfFunction = new double[objRegression.Weights.Length + 1];

            coefOfFunction[0] = objRegression.Intercept;

            int index = objRegression.Weights.Length - 1;

            for (int i = 1; i <= objRegression.Weights.Length; i++)
            {
                coefOfFunction[i] = objRegression.Weights[index];
                index--;
            }
        }

        public void PolynomialRegressionLearning()//int colunmIndex)
        {
            int n = LearningData.Length;
            double[] dependentVariables = new double[n], independentVariables = new double[n];

            for (int i = 0; i < n; i++)
            {
                dependentVariables[i] = LearningData[i][3];
                independentVariables[i] = LearningData[i][2];
            }

            PRLearningOneIndVar(3, independentVariables, dependentVariables);
        }
    }
}
