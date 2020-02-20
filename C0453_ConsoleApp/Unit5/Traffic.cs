using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit5
{
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
