using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.5 Traffic Survey
    /// This class shows a list of the hour of day, how many cars passed in that hour, what percentage of the total day's cars that hour equals to, the total amount of traffic and the hour that has the most traffic
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Traffic
    {
        int[] trafficCount;
        const int MAX_TRAFFIC = 24;
        int total = 0;
        int highScore = 0;
        public Traffic()
        {
            trafficCount = new int[MAX_TRAFFIC];
        }

        /// <summary>
        /// This method asks the user to enter the hour of day it is, and the number of traffic during that hour
        /// </summary>
        public void GetCounts()
        {
            Console.WriteLine("Traffic Report");
            Console.WriteLine("===============================");
            for (int i = 1; i < MAX_TRAFFIC; i++)
            {
                Console.Write("Please enter the traffic count during hour " + i + " : ");
                trafficCount[i] = Convert.ToInt32(Console.ReadLine());
                if (trafficCount[i] > highScore)
                {
                    highScore = trafficCount[i];
                }
                total += trafficCount[i];
            }
        }

        /// <summary>
        /// This method shows a list of the hour of day, how many cars passed in that hour, what percentage of the total day's cars that hour equals to, the total amount of traffic and the hour that has the most traffic
        /// </summary>
        public void ShowData()
        {
            Console.WriteLine("Traffic Count");
            Console.WriteLine("==============");
            Console.WriteLine("Hour\tCar Count\tPercentage");

            for (int i = 1; i < MAX_TRAFFIC; i++)
            {
                var Percent = (double)trafficCount[i] / total * 100;
                Console.WriteLine(i + "\t" + trafficCount[i] + "\t\t" + Percent + "%");
            }
            Console.WriteLine("Total Number Of Cars For The Day < " + total + " > ");
            Console.WriteLine("Busiest Hour Of The Day < " + highScore + " > ");
        }
    }
}
