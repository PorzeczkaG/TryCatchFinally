﻿using System;

namespace BlokTryCatch
{
    class Program
    {

        class PodstZero : Exception 
        {
        };

        class Hzero : Exception
        {
        };

        static void Main(string[] args)
        {
            double a, h;
            string text;
            do
            {
                Console.Write("Prosze podac podstawe: ");
                text = Console.ReadLine();
                double.TryParse(text, out a);
                Console.Write("Prosze podac wysokosc: ");
                text = Console.ReadLine();
                double.TryParse(text, out h);

                try
                {

                    if (a <= 0)
                    {
                        throw new PodstZero();
                    }
                    else if (h <= 0)
                    {
                        throw new Hzero();
                    }
                    Console.WriteLine("Pole trojkata wynosi: {0}", a * h / 2);

                }
                catch (PodstZero) 
                {
                    Console.WriteLine("Podstawa ma wartosc 0 lub mniejsza albo podana wartosc nie jest liczba!");
                }
                catch (Hzero) 
                {
                    Console.WriteLine("Wysokosc ma wartosc 0 lub mniejsza albo podana wartosc nie jest liczba!");
                }
                finally
                {
                    Console.WriteLine("Zapraszam ponownie!");
                    Console.ReadKey();
                }

            }

            Console.ReadLine();
        }

    }
}
