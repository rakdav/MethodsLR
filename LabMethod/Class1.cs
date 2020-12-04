using System;

namespace LabMethod
{
    public class Class1
    {
        public static double[] SummaNeg(double[,] mas)
        {
            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            double[] m = new double[rows];
            for(int i=0;i<rows;i++)
            {
                double s = 0;
                for(int j=0;j<columns;j++)
                {
                    if (mas[i, j] < 0) s += mas[i, j];
                }
                m[i] = s;
            }
            return m;
        }
    }
}
