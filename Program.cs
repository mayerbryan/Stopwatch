using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("0 to exite the application");
            Console.WriteLine("1 for Stopwatch");
            Console.WriteLine("2 for CountDown Timer");
            short option = short.Parse(Console.ReadLine());
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: StopWatchMenu(); break;
                case 2: CountDownMenu(); break;
            }
        }

        static void StopWatchMenu()
        {
            Console.Clear();
            Console.WriteLine("Press Enter to start");
            Console.ReadLine();
            int time = 0;
            while (!Console.KeyAvailable)
            {
                Console.Clear();
                time++;
                Console.WriteLine(time);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.WriteLine("Final Time: "+ time);
            Console.WriteLine("Press Enter to go back to Menu");
            Console.ReadLine();
            Console.ReadLine();
            Menu();
            
        }

        static void CountDownMenu()
        {
            Console.Clear();
            Console.WriteLine("Type the amount of hours");
            int horas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type the amount of minutes");
            int minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type the amount of seconds");
            int segundos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Press 1 to start or 2 to reset");
            short selecao = short.Parse(Console.ReadLine());
            switch (selecao)
            {
                case 1: CountDownStart(horas, minutos, segundos); break;
                case 2: Console.Clear(); CountDownMenu(); break;
            }
        }

        static async void CountDownStart(int hour, int min, int sec)
        {
            min = min * 60;
            int currentTime = min + sec;
            while (currentTime > -1)
            {
                Console.Clear();
                TimeSpan t = TimeSpan.FromSeconds(currentTime);
                Console.WriteLine(t.ToString());
                currentTime--;
                Thread.Sleep(1000);
            }
            Console.WriteLine("Count Down finished!");
            Thread.Sleep(2500);
            Console.WriteLine("Press Enter to go back to Menu");
            Console.ReadLine();
            Menu();
        }
    }
}