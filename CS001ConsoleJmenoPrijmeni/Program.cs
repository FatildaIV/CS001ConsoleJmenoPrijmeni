using System;

namespace CS001ConsoleJmenoPrijmeni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj,");
            Console.WriteLine("{0}!", JmenoPrijmeni());

            Console.ReadKey();
        }
        static string JmenoPrijmeni()
        {
            return "Karel Hofman";
        }
    }
}
