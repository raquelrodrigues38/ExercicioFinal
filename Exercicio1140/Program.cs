using System;

namespace Exercicio1140
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Frase = Console.ReadLine().ToUpper();
            string[] ArrayFrase = Frase.Split(' ');

            char Local;

            Local = ArrayFrase[0][0];

            string Resposta = "";

            if (Frase == "*")
            {
                Resposta = "N";
            }

            for (int A = 1; A < ArrayFrase.Length; A++)
            {
                if ((ArrayFrase[A][0]) == (Local))
                {
                    Resposta = "Y";
                }
                else
                {
                    Resposta = "N";
                    break;
                }

                Local = ArrayFrase[A][0];

            }

            Console.WriteLine(Resposta);
        }
    }         //*deu erro no beecrowd
}
