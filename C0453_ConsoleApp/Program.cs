using C0453_ConsoleApp.Unit4;
using C0453_ConsoleApp.Unit5;
using C0453_ConsoleApp.Project;
using System;
namespace C0453_ConsoleApp
{
    class Program
    {
        static void Main()
        {
            //TestDistanceConverter();
            //TestBook();
            //TestBMI();
            //TestTournament();
            //TestMP3Chart();
            //TestBubbleSort();
            //TestTraffic();
            //TestMotel();
            TestRPS();
        }
        static void TestDistanceConverter()
        {
            DistanceConverter MyConverter = new DistanceConverter();
            MyConverter.DistanceConverterBoth();
        }
        static void TestBook()
        {
            Book MyBook = new Book();
            MyBook.GetDetails();
            MyBook.CheckGender();
            MyBook.WriteChapter1();
            MyBook.WriteChapter2();
        }
        static void TestBMI()
        {
            BMI MyBMI = new BMI();
            MyBMI.MeasurementType();
            MyBMI.GetDetails();
            MyBMI.CalcBmi();
            MyBMI.DisplayBmi();
        }
        static void TestTournament()
        {
            Tournament MyTournament = new Tournament();
            MyTournament.GetDetails();
            MyTournament.ShowDetails();
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
        static void TestTraffic()
        {
            Traffic MyTraffic = new Traffic();
            MyTraffic.EnterCounts();
            MyTraffic.ShowData();
        }
        static void TestMotel()
        {
            Motel BatesMotel = new Motel();
            BatesMotel.RunMotel();
        }
        static void TestRPS()
        {
            RPSProject MyGame = new RPSProject();
            MyGame.Play();
        }
    }
}