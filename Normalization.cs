using Accord.Math;

namespace IPTV_Qality_Prediction
{
    public partial class Algorithm
    {
        public double Delay
        {
            private get => Delay;
            set
            {
                double minValue = Minimum(LearningData.GetColumn(0));
                double maxValue = Maximum(LearningData.GetColumn(0));
                delay = (value - minValue) /
                        (maxValue - minValue);
            }
        }
        public double Jitter
        {
            private get => Jitter;
            set
            {
                double minValue = Minimum(LearningData.GetColumn(1));
                double maxValue = Maximum(LearningData.GetColumn(1));
                jitter = (value - minValue) /
                         (maxValue - minValue);
            }
        }
        public double Drops
        {
            private get => Drops;
            set
            {
                double minValue = Minimum(LearningData.GetColumn(2));
                double maxValue = Maximum(LearningData.GetColumn(2));
                drops = (value - minValue) /
                        (maxValue - minValue);
            }
        }

        public void LearningDataNormalization()
        {
            int n = LearningData.Length;
            NormalizedInputData = new double[n][];

            for (int j = 0; j < n; j++)
                NormalizedInputData[j] = new double[3];

            for (int i = 0; i < 3; i++)
            {
                double minDependentValue = Minimum(LearningData.GetColumn(i));
                double maxDependentValue = Maximum(LearningData.GetColumn(i));

                for (int j = 0; j < n; j++)
                {
                    NormalizedInputData[j][i] = (LearningData[j][i] - minDependentValue) /
                                                (maxDependentValue - minDependentValue);
                }
            }
        }


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

    }
}