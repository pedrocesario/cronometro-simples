using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(0);
        }

        static void Menu()
        {
            // Inicio Variáveis
            string data = null;
            char? type = null;
            int time = 0;
            int multiplier = 1;
            // Fim variáveis

            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 segundos");
            Console.WriteLine("M = Minuto => 60s = 01 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar");

            data = Console.ReadLine().ToLower();
            type = char.Parse(data.Substring(data.Length - 1, 1));
            time = int.Parse(data.Substring(0, data.Length - 1));

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);


        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);
        }
        static void Start(int tempo)
        {

            // Inicio Variáveis
            int tempoAtual = 0;
            // Fim variáveis

            while (tempoAtual != tempo)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
