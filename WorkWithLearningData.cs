using System;
using System.IO;

namespace IPTV_Qality_Prediction
{
    public static class WorkWithLearningData
    {
        public static double[,] ReadFromFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            double[,] columns = new double[lines.Length, 4];
            for (int i = 1; i < lines.Length; i++)
            {
                string[] temp = lines[i].Split('\t');
                for (int j = 0; j < temp.Length; j++)
                    columns[i-1,j] = Convert.ToDouble(temp[j]);
            } 
            return columns;
        }
    }
}