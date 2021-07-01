using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();
            System.Console.WriteLine("Començando a fazer o café da manhã");

            FazerCafe();

            FritarOvos();

            FritarBacon();

            EsquentarPao();

            MontarSanduiche();

            ServirCafe();

            System.Console.WriteLine($"Café da manhã terminado em {stopwatch.Elapsed.TotalSeconds} minutos");
        }

        private static void ServirCafe()
        {
            System.Console.WriteLine("Começando a servir café");

            Task.Delay(200).Wait();

            System.Console.WriteLine("Café servido!");
        }

        private static void MontarSanduiche()
        {
            System.Console.WriteLine("Começando a montar sanduíche");

            Task.Delay(1500).Wait();

            System.Console.WriteLine("Sanduíche pronto!");
        }

        private static void EsquentarPao()
        {
            System.Console.WriteLine("Começando a esquentar pão");

            Task.Delay(1000).Wait();

            System.Console.WriteLine("Pães prontos!");
        }

        private static void FritarBacon()
        {
            System.Console.WriteLine("Começando a fritar bacon");

            Task.Delay(2000).Wait();

            System.Console.WriteLine("bacon prontos!");
        }

        private static void FritarOvos()
        {
            System.Console.WriteLine("Começando a fritar ovos");

            Task.Delay(3000).Wait();

            System.Console.WriteLine("Ovos prontos!");
        }

        private static void FazerCafe()
        {
            System.Console.WriteLine("Começando a fazer café");

            Task.Delay(6000).Wait();

            System.Console.WriteLine("Café pronto!");
        }
    }
}
