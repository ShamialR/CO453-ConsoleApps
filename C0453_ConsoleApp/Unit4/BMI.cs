using System;

namespace C0453_ConsoleApp.Unit4
{
    class BMI
    {
        double weight, height, bmi;
        string measurement;
        string WeightA, HeightA;

        public void MeasurementType()
        {
            Console.Write("Would you like to use metric measurements (kg and metres) or imperial (pounds and inches) \n Please Type M for Metric or I for imperial: ");
            measurement = Console.ReadLine();
        }
        public void GetDetails()
        {
            string input;
            if (measurement == "I")
            {
                WeightA = "Pound";
                HeightA = "Inches";
            }
            else if (measurement == "M")
            {
                WeightA = "kg";
                HeightA = "Metres";
            }

            Console.Write("Please enter your weight(" + WeightA + "): ");
            input = Console.ReadLine();
            weight = Convert.ToDouble(input);
            Console.Write("Please enter your height(" + HeightA + "):  ");
            input = Console.ReadLine();
            height = Convert.ToDouble(input);
        }

        public void CalcBMI()
        {
            if (measurement == "M")
            {
                bmi = weight / (height * height);
            }
            else if (measurement == "I")
            {
                bmi = weight * 703 / (height * height);
            }

            Console.WriteLine(bmi);
        }

        public void DisplayBMI()
        {
            if (bmi < 18.5)
            {
                Console.WriteLine("BMI less than 18.5 … Underweight");
            }
            else if (bmi > 18.5 && bmi <= 25)
            {
                Console.WriteLine("BMI 18.5 up to 25 … Desirable weight for size");
            }
            else if (bmi > 25 && bmi <= 30)
            {
                Console.WriteLine("BMI 25 up to 30 … Overweight");
            }
            else if (bmi > 30 && bmi <= 40)
            {
                Console.WriteLine("BMI 30 up to 40 … Obese");
            }
            else if (bmi > 40)
            {
                Console.WriteLine("BMI 40 or over … Severely Obese");
            }
            else
            {
                Console.WriteLine("Please try again, there seems to be an error");
            }
        }
    }
}
