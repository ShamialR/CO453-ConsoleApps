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
            TestBook();
            //TestBMI();
            //TestTournament();
            //TestMP3Chart();
            //TestBubbleSort();
            //TestTraffic();
            //TestMotel();
            //TestRPS();
        }
        static void TestDistanceConverter()
        {
            DistanceConverter myConverter = new DistanceConverter();
            myConverter.Start();
        }
        static void TestBook()
        {
            Book book = new Book();
            book.GetDetails();
            book.CheckGender();
            book.WriteChapter1();
            book.WriteChapter2();
        }
        static void TestBMI()
        {
            BMI bmi = new BMI();
            bmi.GetMeasurementType();
            bmi.GetDetails();
            bmi.Calculate();
            bmi.Display();
        }
        static void TestTournament()
        {
            Tournament tournament = new Tournament();
            tournament.GetDetails();
            tournament.ShowDetails();
        }
        static void TestMP3Chart()
        {
            Mp3Chart chart = new Mp3Chart();
            chart.ShowMusicList();
            chart.GetVotes();
            chart.DisplayVotes();
        }
        static void TestBubbleSort()
        {
            Bubble bubbleSort = new Bubble();
            bubbleSort.InputNumbers();
            bubbleSort.SortNumbers();
            bubbleSort.Display();
        }
        static void TestTraffic()
        {
            Traffic traffic = new Traffic();
            traffic.EnterCounts();
            traffic.ShowData();
        }
        static void TestMotel()
        {
            Motel batesMotel = new Motel();
            batesMotel.RunMotel();
        }
        static void TestRPS()
        {
            RPSProject rpsGame = new RPSProject();
            rpsGame.PlayRPS();
        }
    }
}