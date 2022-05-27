using System;

namespace Exercicio1168
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Qtde;

            string Local;

            Qtde = int.Parse(Console.ReadLine());

            for (int A = 0; A < Qtde; A++)
            {
                Local = Console.ReadLine();
                int TotalLed = 0;

                for (int B = 0; B < Local.Length; B++)
                {
                    switch (Local[B])
                    {
                        case '1':
                            TotalLed = TotalLed + 2;
                            break;
                        case '2':
                            TotalLed = TotalLed + 5;
                            break;
                        case '3':
                            TotalLed = TotalLed + 5;
                            break;
                        case '4':
                            TotalLed = TotalLed + 4;
                            break;
                        case '5':
                            TotalLed = TotalLed + 5;
                            break;
                        case '6':
                            TotalLed = TotalLed + 6;
                            break;
                        case '7':
                            TotalLed = TotalLed + 3;
                            break;
                        case '8':
                            TotalLed = TotalLed + 7;
                            break;
                        case '9':
                            TotalLed = TotalLed + 6;
                            break;
                        case '0':
                            TotalLed = TotalLed + 6;
                            break;
                        default:
                            TotalLed = 0;
                            break;
                    }

                }

                Console.WriteLine(TotalLed + " leds");
        }   }    
    }
}
