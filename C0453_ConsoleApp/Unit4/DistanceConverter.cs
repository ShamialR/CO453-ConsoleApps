using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// Task 4.1 Distance Converter
    /// This class will convert miles to whole feet, or feet to miles
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public class DistanceConverter
    {
        private double NumMiles, NumFeet;
        /// <summary>
        /// This method creates a menu where the user can select whether to convert feet to miles, miles to feet or to quit the console
        /// </summary>
        public void DistanceConverterBoth()
        {
            Console.WriteLine("Shamial's Distance Converter!\n");

            DistanceConverter Converter = new DistanceConverter();
            string Choice;

            do
            {
                Console.WriteLine("1 = Convert Miles to Feet");
                Console.WriteLine("2 = Convert Feet to Miles");
                Console.WriteLine("3 = Quit\n");

                Console.WriteLine("What would you like to do?\n");

                Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    Converter.MTF();
                }
                else if (Choice == "2")
                {
                    Converter.FTM();
                }
            }
            while (Choice != "3");

        }
        /// <summary>
        /// This uses a method below which asks the user to enter the number of in this case miles using the parameter and then uses the ToFeet method, entering NumMiles and converts it to feet before displaying it
        /// </summary>
        public void MTF()
        {
            NumMiles = GetNumbers("miles");
            NumFeet = ToFeet(NumMiles);
            Console.WriteLine(NumMiles + " miles is " + NumFeet + " feet\n");
        }
        /// <summary>
        /// This uses a method below which asks the user to enter the number of in this case feet using the parameter and then uses the ToMiles method, entering NuFeet and converts it to miles before displaying it
        /// </summary>
        public void FTM()
        {
            NumFeet = GetNumbers("feet");
            NumMiles = ToMiles(NumFeet);
            Console.WriteLine(NumFeet + " feet is " + NumMiles + " miles\n");
        }
        /// <summary>
        /// This method asks the user to enter the number of miles or feet they want to convert.
        /// </summary>
        public double GetNumbers(string Prompt)
        {
            double Num;
            string Input;
            Console.Write("Please enter the Number of " + Prompt + " : ");
            Input = Console.ReadLine();
            Num = Convert.ToDouble(Input);
            return Num;
        }
        /// <summary>
        /// This method gets the number of miles entered by the user from the parameter, then returns that value mutliplied by 1760 then multiplied by 3
        /// </summary>
        public double ToFeet(double Miles)
        {
            return Miles * 1760 * 3;
        }
        /// <summary>
        /// This method gets the number of feet entered by the user from the parameter, then returns that value divided by 1760 then divided by 3
        /// </summary>
        public double ToMiles(double Feet)
        {
            return Feet / 1760 / 3;
        }


    }
}
