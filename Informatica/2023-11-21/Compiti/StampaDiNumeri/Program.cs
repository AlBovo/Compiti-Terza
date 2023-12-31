﻿using System.Data;

namespace ContoAllaRovescia
{
    internal class Program
    {
        #region Matrice contenente le rappresentazioni dei numeri
        static string[][] cifre =
        {
            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "▓      ▓",
                "▓      ▓",
                "▓      ▓",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                "       ▓",
                "       ▓",
                "       ▓",
                "        ",
                "       ▓",
                "       ▓",
                "       ▓",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                " ▓▓▓▓▓▓ ",
                "▓       ",
                "▓       ",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                "▓      ▓",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                "       ▓",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "▓       ",
                "▓       ",
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "▓       ",
                "▓       ",
                " ▓▓▓▓▓▓ ",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                "        ",
                "       ▓",
                "       ▓",
                "       ▓",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
            },

            new string[]
            {
                " ▓▓▓▓▓▓ ",
                "▓      ▓",
                "▓      ▓",
                " ▓▓▓▓▓▓ ",
                "       ▓",
                "       ▓",
                " ▓▓▓▓▓▓ ",
            },
        };
        #endregion

        #region Funzione per leggere un numero valido
        static int ReadInt(string messaggio)
        {
            int result = 0;
            bool inputOK;

            do
            {
                Console.Write(messaggio);
                inputOK = int.TryParse(Console.ReadLine(), out result);

                if (!inputOK)
                {
                    Console.WriteLine("L'input inserito non è un numero intero, riprova ...");
                }
                else if(result < 0)
                {
                    Console.WriteLine("L'intero inserito deve essere positivo, riprova ...");
                    inputOK = false;
                }

            } while (!inputOK);
            return result;
        }
        #endregion

        #region Funzione per stampare il numero nella sua rappresentazione
        static void StampaNumero(int numero)
        {
            Console.WriteLine();
            foreach(char cifra in numero.ToString())
            {
                int line = 2;
                (int, int) position = Console.GetCursorPosition();

                foreach(string st in cifre[cifra - '0'])
                {
                    Console.WriteLine(st);
                    Console.SetCursorPosition(position.Item1, ++line);
                }

                Console.SetCursorPosition(position.Item1 + 8 + 2, position.Item2);
                numero /= 10;
            }
        }
        #endregion

        static void Main(string[] args)
        {
            StampaNumero(ReadInt("Inserisci il numero da stampare: "));

            Console.SetCursorPosition(0, 10);
            Console.Write("Premi un tasto per terminare l'esecuzione del programma ...");
            Console.ReadKey();
        }
    }
}