using System;

namespace ExercicioFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio 1173
            {
                int[] AVetor = new int[10];

                int Inicio = int.Parse(Console.ReadLine());

                int Num = Inicio;

                for (int A = 0; A < AVetor.Length; A++)
                {


                    if (A == 0)
                    {
                        AVetor[A] = Num;
                    }
                    else
                    {
                        AVetor[A] = Num * 2;
                    }

                    Num = AVetor[A];
                }



                for (int B = 0; B < AVetor.Length; B++)
                {
                    Console.WriteLine("N[" + B + "] = " + AVetor[B].ToString("0"));
                }
            }
        }
    }
}
