using C0453_ConsoleApp.Unit4;
using C0453_ConsoleApp.Unit5;
using System;

namespace C0453_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestDistanceConverter();
            TestBook();
            //TestBMI();
            //TestTournament();
            //TestMP3Chart();
            //TestBubbleSort();
        }
        static void TestDistanceConverter()
        {
            
            DistanceConverter MyConverter = new DistanceConverter();
            MyConverter.DistanceConverterBoth();

        }

        static void TestBook()
        {
            Book myBook = new Book();       // create a new Book object
            myBook.getDetails();            // call its getDetails() method
            myBook.CheckGender();
            myBook.writeChapter1();         // call its writeChapter1() method
            myBook.writeChapter2();
        }

        static void TestBMI()
        {
            BMI MyBMI = new BMI();
            MyBMI.MeasurementType();
            MyBMI.GetDetails();
            MyBMI.CalcBMI();
            MyBMI.DisplayBMI();
        }

        static void TestTournament()
        {
            Tournament MyTournament = new Tournament();   // create a new tournament object
            MyTournament.getDetails();
            MyTournament.ShowDetails();// call the getScores method  
        }

        static void TestMP3Chart()
        {
            Mp3Chart MyChart = new Mp3Chart();
            MyChart.Vote();
        }

        static void TestBubbleSort()
        {
            Bubble BSort = new Bubble();
            BSort.InputNumbers();
            BSort.SortNumbers();
            BSort.Display();
        }

    }
}
