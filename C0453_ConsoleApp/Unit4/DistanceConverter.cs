using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// This class will convert miles to whole feet, or feet to miles
    /// 
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public class DistanceConverter
    {
        /// <summary>
        /// This method will take a Number of miles and convert them to whole feet
        /// 
        /// </summary>
        private double NumMiles, NumFeet;

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
        public void MTF()
        {
            NumMiles = GetNumbers("miles");
            NumFeet = ToFeet(NumMiles);
            Console.WriteLine(NumMiles + " miles is " + NumFeet + " feet\n");
        }
        public void FTM()
        {
            NumFeet = GetNumbers("feet");
            NumMiles = ToMiles(NumFeet);
            Console.WriteLine(NumFeet + " feet is " + NumMiles + " miles\n");
        }
        public double GetNumbers(string Prompt)
        {
            double Num;
            string Input;
            Console.Write("Please enter the Number of " + Prompt + " : ");
            Input = Console.ReadLine();
            Num = Convert.ToDouble(Input);
            return Num;
        }
        public double ToFeet(double Miles)
        {
            return Miles * 1760 * 3;
        }

        public double ToMiles(double Feet)
        {
            return Feet / 1760 / 3;
        }


    }
}
