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
            //TestBook();
            //TestBMI();
            //TestTournament();
            //TestMP3Chart();
            TestBubbleSort();
        }
        static void TestDistanceConverter()
        {
            DistanceConverter MyConverter = new DistanceConverter();
            MyConverter.DistanceConverterBoth();

        }

        static void TestBook()
        {
            Book MyBook = new Book();       // create a new Book object
            MyBook.getDetails();            // call its getDetails() method
            MyBook.CheckGender();
            MyBook.writeChapter1();         // call its writeChapter1() method
            MyBook.writeChapter2();
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

        static void TestMotelBooking()
        {
            SimpleIO motel = new SimpleIO();

            SimpleIO.WriteTitle("The Bates Motel", "Task 5.6");

            string[] choices =
            {
                "1. Book a Room",
                "2. Vacate a Room",
                "3. Display All Rooms",
                "4. Vacate All Rooms",
                "5. Quit"
            };

            int choice = SimpleIO.GetChoice(choices);

            switch (choice)
            {
                case 1:
                    motel.Book(1, 2);
                    break;

                default:
                    break;
            }
        }
    }
}
