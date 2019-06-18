using System;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;

namespace IPTV_Qality_Prediction

{
    public partial class Algorithm
    {
       public void SupportVectorMachineLearning()
        {
            int n = LearningData.Length;
            int[] output = new int[n];
            double[][] input = new double[n][];
            //InputDataNormalization();
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

        //private MulticlassSupportVectorMachine<Linear> machine;
        private MulticlassSupportVectorMachine<Gaussian> machine;

        public double ErrorSVM { get; private set; }

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

            machine = teacher.Learn(input, output);

            int[] prediction = machine.Decide(input);

            PredictedData[2] = new double[prediction.Length];

            for (int i = 0; i < prediction.Length; i++)
                PredictedData[2][i] = Convert.ToDouble(prediction[i]);

            ErrorSVM = new ZeroOneLoss(output).Loss(prediction);
        }

        public int SupportVectorMachinePrediction()
        {
            double[] input = new double[] {delay, jitter, drops};
            int prediction = machine.Decide(input);
            return prediction;
        }
    }
}
