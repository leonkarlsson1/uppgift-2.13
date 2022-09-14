using System;

namespace Uppgift_2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in lön1");
            double lön1 = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv in lön2");
            double lön2 = double.Parse(Console.ReadLine());
            Console.WriteLine("skriv in lön3");
            double lön3 = double.Parse(Console.ReadLine());
            double medelvärde = (lön1 + lön2 + lön3) /3;
            Console.WriteLine("medelvärde av " + lön1 + " plus " + lön2 + " plus "+ lön3 + " är " +medelvärde + "kr");
        }
    }
}