using System;

namespace Stopwatch{
    class Program{
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("digite o tempo desejado em horas");
            int horas = Int32.Parse(Console.ReadLine());
            Console.WriteLine("digite o tempo desejado em minutos");
            int minutos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("digite o tempo desejado em segudos");
            int segundos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("pressione 1 para começar ou 2 para resetar");
            int selecao = Int32.Parse(Console.ReadLine());
            switch(selecao){
                case 1: Start(horas, minutos, segundos); break;
                case 2: Console.Clear(); Menu(); break;
            }
           
        }

        static async void Start(int hour, int min, int sec){
            min = min*60;
            int currentTime = min+sec;
            while(currentTime > -1){
                Console.Clear();
                TimeSpan t = TimeSpan.FromSeconds(currentTime);
                Console.WriteLine(t.ToString());
                currentTime--;                
                Thread.Sleep(1000);
            }
            Console.WriteLine("cronometro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}