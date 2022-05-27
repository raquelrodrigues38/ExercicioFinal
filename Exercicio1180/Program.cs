using System;

namespace Exercicio1180
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Qtde = int.Parse(Console.ReadLine());
            string[] Vetor = Console.ReadLine().Split(' ');

            int[] X = new int[Qtde];

            for (int i = 0; i < Qtde; i++)
            {
                X[i] = int.Parse(Vetor[i]);
            }

            int Menor = X[0];
            int Index = 0;

            for (int i = 0; i < Qtde; i++)
            {
                if (X[i] < Menor)
                {
                    Menor = X[i];
                    Index = i;
                }
            }

            Console.WriteLine("Menor valor: " + Menor);
            Console.WriteLine("Posicao: " + Index);
        }
    }
}
