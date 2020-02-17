using System;

namespace C0453_ConsoleApp.Unit4
{
    class BMI
    {
        double Weigth, Height, Bmi;
        string Measurement;
        string WeigthA, HeightA;

        public void MeasurementType()
        {
            Console.Write("Would you like to use metric Measurements (kg and metres) or imperial (pounds and inches) \n Please Type M for Metric or I for imperial: ");
            Measurement = Console.ReadLine();
        }
        public void GetDetails()
        {
            string input;
            if (Measurement == "I")
            {
                WeigthA = "Pound";
                HeightA = "Inches";
            }
            else if (Measurement == "M")
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
