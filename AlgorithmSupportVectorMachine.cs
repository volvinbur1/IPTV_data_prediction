using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;
using System;

namespace IPTV_Qality_Prediction

{
    public partial class Algorithm
    {
        public void SupportVectorMachineLearning()
        {
            int n = LearningData.Length;
            int[] input = new int[n];
            double[][] output = new double[n][];

            for (int i = 0; i < n; i++)
            {
                input[i] = Convert.ToInt32(LearningData[i][3]);

                output[i] = new double[3];
                output[i][0] = LearningData[i][0];
                output[i][1] = LearningData[i][1];
                output[i][2] = LearningData[i][2];
            }

            SVMLearning(output,input);
        }
        
        private void SVMLearning(double[][] input, int[] output)
        {
            var teacher = new MulticlassSupportVectorLearning<Linear>();
            {
                System.Func<object, LinearDualCoordinateDescent> Learner = (p) => new LinearDualCoordinateDescent()
                {
                    Loss = Loss.L2
                };
            }

            teacher.ParallelOptions.MaxDegreeOfParallelism = 1;
            var machine = teacher.Learn(input, output);

            int[] predicted = machine.Decide(input);

            double error = new ZeroOneLoss(output).Loss(predicted);
        }
    }
}