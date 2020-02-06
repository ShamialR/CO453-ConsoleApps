using C0453_ConsoleApp.Unit4;
using System;

namespace C0453_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shamial's Distance Converter!\n");

            DistanceConverter converter = new DistanceConverter();
            string choice;

            do
            {
                Console.WriteLine("1 = Convert Miles to Feet");
                Console.WriteLine("2 = Convert Feet to Miles");
                Console.WriteLine("3 = Quit\n");

                Console.WriteLine("What would you like to do?\n");

                choice = Console.ReadLine();
                if (choice == "1")
                {
                    converter.MTF();
                }
                else if (choice == "2")
                {
                    converter.FTM();
                }
            }
            while (choice != "3");

        } 
    }
}
