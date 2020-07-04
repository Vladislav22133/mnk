using System;

namespace мнк
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.Write($"Введите количество элементов массива x,y:\t");
            int n = int.Parse(Console.ReadLine());
            float[] x = new float[n];
            float[] y = new float[n];
            for (i = 0; i < x.Length; i++)
            {
                Console.Write($"Введите x:\t");
                x[i] = float.Parse(Console.ReadLine());
            }
            for (i = 0; i < y.Length; i++)
            {
                Console.Write($"Введите y:\t");
                y[i] = float.Parse(Console.ReadLine());
            }
            float sumX = 0;
            for (i = 0; i < x.Length; i++)
            {
                sumX += x[i];
            }
            float sumY = 0;
            for (i = 0; i < y.Length; i++)
            {
                sumY += y[i];
            }
            float sumxy = 0;
            for (i = 0; i < x.Length; i++)
            {
                sumxy += x[i] * y[i];
            }
            float sumx2 = 0;
            for (i = 0; i < x.Length; i++)
            {
                sumx2 += x[i] * x[i];

            }
            Double a, b;
            a = (n * sumxy - sumX * sumY) / (n * sumx2 - Math.Pow(sumX,2));
            Console.WriteLine("a: " + a);
            b = (sumY - a * sumX) / n;
            Console.WriteLine("b: " + b);
            Console.ReadKey();
        }
    }
}



