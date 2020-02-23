using System;

namespace C0453_ConsoleApp.Unit4
{
    /// <summary>
    /// Task 4.4 Body Mass Index
    /// This class will calculate the BMI of a person using their weight and height, in either Metric or Imperial
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class BMI
    {
        double Weigth, Height, Bmi;
        string Measurement;
        string WeigthA, HeightA;
        /// <summary>
        /// This method will ask the user whether they want to use metric or imperial
        /// </summary>
        public void MeasurementType()
        {
            Console.Write("Would you like to use metric Measurements (kg and metres) or imperial (pounds and inches) \n Please Type M for Metric or I for imperial: ");
            Measurement = Console.ReadLine();
            Measurement = Measurement.ToUpper();
        }
        /// <summary>
        /// This method will ask the user to enter their height and weight, depending on what they chose previously it will also display the imperial or metric measurements
        /// </summary>
        public void GetDetails()
        {
            string input;
            if (Measurement == "I")
            {
                WeigthA = "Pound";
                HeightA = "Inches";
            }
            if (Measurement == "M")
            {
                WeigthA = "kg";
                HeightA = "Metres";
            }

            Console.Write("Please enter your Weigth(" + WeigthA + "): ");
            input = Console.ReadLine();
            Weigth = Convert.ToDouble(input);
            Console.Write("Please enter your Height(" + HeightA + "):  ");
            input = Console.ReadLine();
            Height = Convert.ToDouble(input);
        }
        /// <summary>
        /// This method will calculate the BMI in metric or imperial using the height and weigth entered in GetDetails
        /// </summary>
        public void CalcBmi()
        {
            if (Measurement == "M")
            {
                Bmi = Weigth / (Height * Height);
            }
            else if (Measurement == "I")
            {
                Bmi = Weigth * 703 / (Height * Height);
            }

            Console.WriteLine(Bmi);
        }
        /// <summary>
        /// This Method will display the BMI of the user letting them know what range there are in
        /// </summary>
        public void DisplayBmi()
        {
            if (Bmi < 18.5)
            {
                Console.WriteLine("Bmi less than 18.5 … UnderWeigth");
            }
            else if (Bmi > 18.5 && Bmi <= 25)
            {
                Console.WriteLine("Bmi 18.5 up to 25 … Desirable Weigth for size");
            }
            else if (Bmi > 25 && Bmi <= 30)
            {
                Console.WriteLine("Bmi 25 up to 30 … OverWeigth");
            }
            else if (Bmi > 30 && Bmi <= 40)
            {
                Console.WriteLine("Bmi 30 up to 40 … Obese");
            }
            else if (Bmi > 40)
            {
                Console.WriteLine("Bmi 40 or over … Severely Obese");
            }
            else
            {
                Console.WriteLine("Please try again, there seems to be an error");
            }
        }
    }
}
