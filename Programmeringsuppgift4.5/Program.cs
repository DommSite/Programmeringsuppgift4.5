﻿using System;

namespace inlämningsuppgift4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett heltal");
            string heltal = Console.ReadLine();
            string nytal = "";
            for (int i = 0; i < heltal.Length; i++)
            {
                string tecken = heltal[i].ToString();
                try
                {
                    int siffra = int.Parse(tecken) + 1;
                    if (siffra == 10)
                    {
                        siffra = 0;
                    }
                    nytal = nytal + siffra;
                }


                catch
                {
                    Console.WriteLine("tecken är inte en siffra: " + tecken);
                }
            }
            Console.WriteLine(nytal);
        }
    }
}
