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
        /// This method will take a number of miles and convert them to whole feet
        /// </summary>
        private double numMiles, numFeet;

        public void MTF()
        {
            numMiles = getNumbers("miles");
            numFeet = ToFeet(numMiles);
            Console.WriteLine(numMiles + " miles is " + numFeet + " feet\n");
        }
        public void FTM()
        {
            numFeet = getNumbers("feet");
            numMiles = ToMiles(numFeet);
            Console.WriteLine(numFeet + " feet is " + numMiles + " miles\n");
        }
        public double getNumbers(string prompt)
        {
            double num;
            string input;
            Console.Write("Please enter the number of " + prompt + " : ");
            input = Console.ReadLine();
            num = Convert.ToDouble(input);
            return num;
        }
        public double ToFeet(double miles)
        {
            return miles * 1760 * 3;
        }

        public double ToMiles(double feet)
        {
            return feet / 1760 / 3;
        }


    }
}
