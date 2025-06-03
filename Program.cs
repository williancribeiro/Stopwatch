// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;
using System;
using System.Threading;
using System.Threading.Channels;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Start(5);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos");
            Console.WriteLine("M = Minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            String data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (type == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);
        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar..");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar..");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo!!");
            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Cronometro finalizado..");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
