using System;

namespace HW_12T13H_19H
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane airBus380 = new Plane();
            Powerboat clariss = new Powerboat();
            Eagle predator = new Eagle();
            Duck donald = new Duck();
            Hen gallina = new Hen();

            airBus380.StartEngine();
            airBus380.Fly();
            Console.WriteLine();
            clariss.StartEngine();
            clariss.Swim();
            Console.WriteLine();
            predator.Fly();
            Console.WriteLine();
            donald.Swim();
            donald.Fly();
            Console.WriteLine();
            gallina.Run();

            Console.ReadLine();

        }
    }
}
