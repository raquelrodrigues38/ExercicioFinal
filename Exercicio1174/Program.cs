using System;

namespace Exercicio1174
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] AVetor = new double[100];
            for (int A = 0; A < AVetor.Length; A++)
            {
                double Num = double.Parse(Console.ReadLine());
                AVetor[A] = Num;
            }

            for (int B = 0; B < AVetor.Length; B++)
            {
                if (AVetor[B] <= 10)
                {
                    Console.WriteLine("A[" + B + "] = " + AVetor[B].ToString("0.0"));
                }
            }
        }
}   }   
