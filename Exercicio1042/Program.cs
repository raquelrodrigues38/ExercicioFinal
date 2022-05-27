using System;

namespace Exercicio1042
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numeros = Console.ReadLine().Split(' ');
            int A = int.Parse(numeros[0]);
            int B = int.Parse(numeros[1]);
            int C = int.Parse(numeros[2]);

            int Maior = 0;
            int Meio = 0;
            int Menor = 0;

            if (A < B && A < C && B < C)
            {
                Menor = A;
                Meio = B;
                Maior = C;
            }
            else if (A < B && A < C && B > C)
            {
                Menor = A;
                Meio = C;
                Maior = B;
            }
            else if (A > B && A < C && B < C)
            {
                Menor = B;
                Meio = A;
                Maior = C;
            }
            else if (A > B && A > C && B < C)
            {
                Menor = B;
                Meio = C;
                Maior = A;
            }
            else if (A > B && A > C && B > C)
            {
                Menor = C;
                Meio = B;
                Maior = A;
            }
            else
            {
                Menor = C;
                Meio = A;
                Maior = B;
            }


            Console.WriteLine(Menor);
            Console.WriteLine(Meio);
            Console.WriteLine(Maior);
            Console.WriteLine("");
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }
    }
}
