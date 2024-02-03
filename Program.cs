using System;
using System.Threading;
namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 10m = 10 minutos");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja Contar?");

            string data = Console.ReadLine().ToLower(); //tolower tranforma tudo em letras minusculas.
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if (time == 0)
                System.Environment.Exit(0);

            Console.Clear();
            Console.WriteLine("Qual o tipo de contagem que deseja?");
            Console.WriteLine("R = Regressiva");
            Console.WriteLine("P = Progressiva");

            string couting = Console.ReadLine().ToLower();
            char typeCounting = char.Parse(couting);

            PreStart(time * multiplier, typeCounting);
        }
        static void PreStart(int time, char contagem)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1000);

            if (contagem == 'p')
                StartProgressive(time);
            if (contagem == 'r')
                StartRegressive(time);

        }
        static void StartProgressive(int time)
        {

            int CurrentTime = 0;

            while (CurrentTime != time)
            {
                Console.Clear();
                CurrentTime++;
                Console.WriteLine(CurrentTime);
                Thread.Sleep(1000); //Faz a aplicação "Dormir" por 1 segundo
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Menu();
        }
        static void StartRegressive(int time)
        {
            while (time >= 0)
            {
                Console.Clear();
                Console.WriteLine(time);
                time--;
                Thread.Sleep(1000); //Faz a aplicação "Dormir" por 1 segundo
            }
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado");
            Menu();
        }
    }
}