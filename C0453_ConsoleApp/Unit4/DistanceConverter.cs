using System;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// Task 4.1 Distance Converter
    /// This class will convert miles to whole feet, or feet to miles
    /// Author: Shamial Rashid 21905385
    /// </summary>
    public class DistanceConverter
    {
        private double miles, feet;
        /// <summary>
        /// This method creates a menu where the user can select whether to convert feet to miles, miles to feet or to quit the console
        /// </summary>
        public void Converter()
        {
            string Choice;

            Console.WriteLine("Shamial's Distance Converter!\n");

            do
            {
                Console.WriteLine("1 = Convert Miles to Feet");
                Console.WriteLine("2 = Convert Feet to Miles");
                Console.WriteLine("3 = Quit\n");

                Console.WriteLine("What would you like to do?\n");

                Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    miles = GetNumbers("miles");
                    feet = ToFeet(miles);
                    Console.WriteLine(miles + " miles is " + feet + " feet\n");
                }
                else if (Choice == "2")
                {
                    feet = GetNumbers("feet");
                    miles = ToMiles(feet);
                    Console.WriteLine(feet + " feet is " + miles + " miles\n");
                }
            }
            while (Choice != "3");

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
