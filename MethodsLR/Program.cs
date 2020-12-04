using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabMethod;

namespace MethodsLR
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //средний уровень
                int n8;
                
                if(int.TryParse(Console.ReadLine(),out n8))
                {
                    Console.WriteLine(ToDecimal(n8));
                }
                //начальный уровень библиотеки
                int n = int.Parse(Console.ReadLine());
                int m = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                double[,] mas = new double[n,m];
                for(int i=0;i<n;i++)
                {
                    for(int j=0;j<m;j++)
                    {
                        mas[i, j] = rnd.Next(50) - 25;
                        Console.Write(mas[i,j]+" ");
                    }
                    Console.WriteLine();
                }
                double[] onem = Class1.SummaNeg(mas);
                for (int i = 0; i < onem.Length; i++) Console.Write(onem[i]+" ");
                Console.WriteLine();
                Console.ReadKey();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Средний уровень
        static int ToDecimal(int n)
        {
            int i = 0;
            int s = 0;
            while(n!=0)
            {
                int m = n % 10;
                s += m * Step8(i);
                i++;
                n /= 10;
            }
            return s;
        }
        static int Step8(int n)
        {
            int s = 1;
            for(int i=1;i<=n;i++)
            {
                s *= 8;
            }
            return s;
        }
    }
}
