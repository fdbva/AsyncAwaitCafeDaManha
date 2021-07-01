using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Console
{
    class Program
    {
        private static Random _random = new Random();
        // async await Task
        static async Task Main(string[] args)
        {
            try
            {
                var stopwatch = Stopwatch.StartNew();
                System.Console.WriteLine("Començando a fazer o café da manhã");

                var fazerCafeTask = FazerCafe();

                var servirCafeTask = ServirCafe(fazerCafeTask);

                var fritarOvosTask = FritarOvos();

                var fritarBaconTask = FritarBacon();

                var esquentarPaoTask = EsquentarPao();
                
                await Task.WhenAll(fritarOvosTask, fritarBaconTask, esquentarPaoTask);

                await MontarSanduiche();

                await servirCafeTask;

                System.Console.WriteLine($"Café da manhã terminado em {stopwatch.Elapsed.TotalSeconds} minutos");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e);
                throw;
            }
        }

        private static async Task ServirCafe(Task fazerCafeTask)
        {
            await fazerCafeTask;
            System.Console.WriteLine("Começando a servir café");

            await Task.Delay(200);

            System.Console.WriteLine("Café servido!");
        }

        private static async Task MontarSanduiche()
        {
            System.Console.WriteLine("Começando a montar sanduíche");

            await Task.Delay(1500);

            System.Console.WriteLine("Sanduíche pronto!");
        }

        private static async Task EsquentarPao()
        {
            System.Console.WriteLine("Começando a esquentar pão");

            await Task.Delay(_random.Next(200, 5000));

            System.Console.WriteLine("Pães prontos!");
        }

        private static async Task FritarBacon()
        {
            System.Console.WriteLine("Começando a fritar bacon");

            await Task.Delay(_random.Next(200, 5000));

            System.Console.WriteLine("bacon prontos!");
        }

        private static async Task FritarOvos()
        {
            System.Console.WriteLine("Começando a fritar ovos");

            await Task.Delay(_random.Next(200, 5000));

            System.Console.WriteLine("Ovos prontos!");
        }

        private static async Task FazerCafe()
        {
            System.Console.WriteLine("Começando a fazer café");

            await Task.Delay(_random.Next(200, 5000));

            System.Console.WriteLine("Café pronto!");
        }
    }
}
