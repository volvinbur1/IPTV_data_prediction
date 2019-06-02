using Accord.MachineLearning;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math.Optimization.Losses;
using Accord.Statistics.Kernels;
using com.sun.corba.se.spi.orbutil.fsm;


namespace IPTV_Qality_Prediction

{
    public partial class Algorithm
    {
        public void SupportVectorMachineInOu(double[][] input, double[] output)
        {

        }
        
        public void SupportVectorMachineLearning(double[][] input, int [] output)
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