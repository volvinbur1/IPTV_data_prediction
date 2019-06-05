
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;
using sun.security.util;

namespace IPTV_Qality_Prediction

{
    public partial class Algorithm
    {
        public double[][] NormalizedInputData;

        private double Maximum(double[] valueDoubles)
        {
            double max = double.MinValue;

            foreach (var digit in valueDoubles)
                if (digit > max)
                    max = digit;

            return max;
        }

        private double Minimum(double[] valueDoubles)
        {
            double min = double.MaxValue;

            foreach (var digit in valueDoubles)
                if (digit < min)
                    min = digit;

            return min;
        }

        public void InputDataNormalization()
        {
            int n = LearningData.Length;
            NormalizedInputData = new double[n][];
            
            for (int i = 0; i < 3; i++)
            {
                double[] temp = new double[n];

                for (int j = 0; j < n; j++)
                {
                    temp[j] = LearningData[j][i];
                    NormalizedInputData[j] = new double[3];
                }

                double minDependentValue = Minimum(temp);
                double maxDependentValue = Maximum(temp);

                for (int j = 0; j < n; j++)
                {
                    NormalizedInputData[j][i] = (LearningData[j][i] - minDependentValue) /
                                                (maxDependentValue - minDependentValue);
                }
            }
        }

        public void SupportVectorMachineLearning()
        {
            int n = LearningData.Length;
            int[] output = new int[n];
            double[][] input = new double[n][];
            InputDataNormalization();
            for (int i = 0; i < n; i++)
            {
                output[i] = Convert.ToInt32(LearningData[i][3]);

                input[i] = new double[3];
                input[i][0] = NormalizedInputData[i][0];
                input[i][1] = NormalizedInputData[i][1];
                input[i][2] = NormalizedInputData[i][2];
            }



            SVMLearning(input, output);
        }




        //private void SVMLearning(double[][] input, int[] output)
        //{
        //    var teacher = new MulticlassSupportVectorLearning<Linear>();
        //    {
        //        LinearDualCoordinateDescent Learner(object p) => new LinearDualCoordinateDescent()
        //        {
        //            Loss = Loss.L2
        //        };
        //    }

        //    teacher.ParallelOptions.MaxDegreeOfParallelism = 1;
        //    var machine = teacher.Learn(input, output);

        //    int[] predicted = machine.Decide(input);

        //    double error = new ZeroOneLoss(output).Loss(predicted);
        //}
        private void SVMLearning(double[][] input, int[] output)
        {
            var teacher = new MulticlassSupportVectorLearning<Gaussian>()
            {

                Learner = (param) => new SequentialMinimalOptimization<Gaussian>()
                {

                    UseKernelEstimation = true
                }
            };


            teacher.ParallelOptions.MaxDegreeOfParallelism = 1;

            var machine = teacher.Learn(input, output);


            int[] predicted = machine.Decide(input);


            double[] scores = machine.Score(input);


            double error = new ZeroOneLoss(output).Loss(predicted);
        }


    }
}