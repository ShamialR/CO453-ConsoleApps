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
        int[] TrafficCount;
        int MAX = 24;
        int Total = 0;
        int HighScore = 0;
        public Traffic()
        {
            TrafficCount = new int[MAX];
        }
        /// <summary>
        /// This method asks the user to enter the hour of day it is, and the number of traffic during that hour
        /// </summary>
        public void EnterCounts()
        {
            Console.WriteLine("Traffic Report");
            Console.WriteLine("===============================");
            for (int i = 1; i < MAX; i++)
            {
                Console.Write("Please enter the traffic count during hour " + i + " : ");
                TrafficCount[i] = Convert.ToInt32(Console.ReadLine());
                if (TrafficCount[i] > HighScore)
                {
                    HighScore = TrafficCount[i];
                }
                Total += TrafficCount[i];
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

            for (int i = 1; i < MAX; i++)
            {
                var Percent = (double)TrafficCount[i] / Total * 100;
                Console.WriteLine(i + "\t" + TrafficCount[i] + "\t\t" + Percent + "%");
            }
            Console.WriteLine("Total Number Of Cars For The Day < " + Total + " > ");
            Console.WriteLine("Busiest Hour Of The Day < " + HighScore + " > ");
        }
    }
}
