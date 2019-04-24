using System;
using The365People.DynamicsExtensionManager.Core;

namespace The365People.DynamicsExtensionManager.Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dynamics Extension Manager Tester");
            Console.WriteLine();

            DynamicsService[] lServices = DynamicsServiceManager.GetServices();
            foreach (DynamicsService lService in lServices)
                Console.WriteLine(lService);

            Console.WriteLine();
            Console.WriteLine("Press any key to end.");
            Console.ReadKey();
        }
    }
}
