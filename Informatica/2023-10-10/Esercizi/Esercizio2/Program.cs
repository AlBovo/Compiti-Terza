﻿using System;

namespace Esercizio2
{
    internal class Program
    {
        const int SOGLIA1 = 10000, SOGLIA2 = 15000;
        const double ALIQUOTA1 = 15.0 / 100.0, ALIQUOTA2 = 20.0 / 100.0, ALIQUOTA3 = 23.0 / 100.0;
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double reddito, imposta;
            string input;
            bool inputOK;

            do
            {
                Console.Write("Inserisci il tuo reddito: ");
                input = Console.ReadLine();
                inputOK = double.TryParse(input, out reddito);

                if (!inputOK)
                {
                    Console.WriteLine("L'input inserito non è un numero, riprova ...");
                }
                else if (reddito < 0)
                {
                    Console.WriteLine("Il tuo reddito non può essere negativo, riprova ...");
                    inputOK = false;
                }
            } while (!inputOK);

            imposta = reddito;
            
            if (reddito <= SOGLIA1)
            {
                reddito -= reddito * ALIQUOTA1;
            }
            else if(reddito <= SOGLIA2)
            {
                reddito -= SOGLIA1 * ALIQUOTA1 + (reddito - SOGLIA2) * ALIQUOTA2;
            }
            else
            {
                reddito -= SOGLIA1 * ALIQUOTA1 + (SOGLIA2 - SOGLIA1) * ALIQUOTA2 + (reddito - SOGLIA2) * ALIQUOTA3;
            }
            imposta -= reddito;

            Console.WriteLine("Il tuo reddito dopo aver pagato le tasse, ovvero {0:C} sono {1:C}", imposta, reddito);

            Console.Write("Premi un tasto per continuare ...");
            Console.ReadKey();
        }
    }
}
