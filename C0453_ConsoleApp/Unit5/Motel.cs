using System;

namespace C0453_ConsoleApp.Unit5
{
    class Motel
    {
        int[] Rooms;
        int RoomNumber, Guests;
        int RoomsBooked = 0, TotalGuests = 0, ExcessGuests = 0, GuestsCount = 0;
        const int MAX = 20;

        //*******************************************************
        public Motel()
        {
            Rooms = new int[MAX + 1];        // allow Rooms from 1 to MAX
        }
        //******************************************************
        public void RunMotel()
        {
            string Choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("The Bates Motel");
                Console.WriteLine("===============");
                Console.WriteLine("1. Book a Room");
                Console.WriteLine("2. Vacate a Room");
                Console.WriteLine("3. Display ALL Room Details");
                Console.WriteLine("4. Vacate ALL Rooms");
                Console.WriteLine("5. Management Information");
                Console.WriteLine("6. Quit");
                Console.Write("Enter your Choice : ");
                Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    BookRoomTest();
                }
                else if(Choice == "2")
                {
                    VacateOneRoom();
                }
                else if(Choice == "3")
                {
                    ShowAllRooms();
                }
                else if (Choice == "4")
                {
                    VacateAllRooms();
                }
                else if (Choice == "5")
                {
                    ManagementInformation();
                }
            }
            while (Choice != "6");
        }
        //*******************************************************
        public void BookRoom()
        {
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("===============");
            Console.WriteLine("Book a Room");
            Console.Write("Enter the Room number : ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());
            if (Rooms[RoomNumber] != 0)
            {
                Console.WriteLine("Sorry this Room is already booked");
            }
            else
            {
                Console.Write("How many Guests : ");
                Guests = Convert.ToInt32(Console.ReadLine()); 
                Rooms[RoomNumber] = Guests;     // make the booking
                Console.WriteLine("Room " + RoomNumber + " booked for " + Guests + " people");
                TotalGuests += Guests;
                RoomsBooked++;
            }
            Console.ReadKey();
        }
        //*******************************************************

        public void ShowAllRooms()
        {
            Console.WriteLine("Bates Motel Room Status");
            Console.WriteLine("=======================");
            for (int i = 1; i < MAX+1; i++)
            {
                Console.WriteLine("Room " + i + "\t " + Rooms[i] + " Guests");
            }
            Console.ReadKey();
        }

        public void VacateOneRoom()
        {
            Console.Write("Which Room would you like to vacate: ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());
            Rooms[RoomNumber] = 0;
            Console.Write("Room " + RoomNumber + " has been vacated");
            RoomsBooked -= 1;
            Console.ReadKey();
        }

        public void VacateAllRooms()
        {
            for(int i = 1; i < MAX+1; i++)
            {
                Rooms[i] = 0;
            }
            RoomsBooked = 0;
            Console.ReadKey();
        }

        public void ManagementInformation()
        {
            int EmptyRooms = 20 - RoomsBooked;
            Console.WriteLine("Currently " + RoomsBooked + " Rooms have been booked");
            Console.WriteLine("Currently there are " + TotalGuests + " Guests");
            Console.WriteLine("Currently there are " + EmptyRooms + " empty Rooms");
            Console.ReadKey();
        }

        public void BookRoomTest()
        {
            Console.WriteLine("\nThe Bates Motel");
            Console.WriteLine("===============");
            Console.WriteLine("Book a Room");
            Console.Write("Enter the Room number : ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());
            if (Rooms[RoomNumber] != 0)
            {
                Console.WriteLine("Sorry this Room is already booked");
            }
            else
            {
                Console.Write("How many Guests : ");
                Guests = Convert.ToInt32(Console.ReadLine());
                ExcessGuests = Guests;
                GuestsCount = Guests;
                Console.WriteLine("Sorry! There is a limit of 4 guests per room. 4 guests have been booked into room " + RoomNumber + ", please choose different rooms to accomadate the rest.");
                Rooms[RoomNumber] = 4;
                do
                {
                    ExcessGuests -= 4;
                    Console.Write("Enter a different Room number for 4 the " + ExcessGuests + " remaining guests: ");
                    RoomNumber = Convert.ToInt32(Console.ReadLine());
                    if(ExcessGuests > 4)
                    {
                        Guests = 4;
                        Rooms[RoomNumber] = Guests;
                    }
                    else
                    {
                        Rooms[RoomNumber] = ExcessGuests;
                    }
                    Guests = ExcessGuests;
                }
                while (Guests > 4);
                     // make the booking
                TotalGuests += GuestsCount;
                RoomsBooked++;
            }
            Console.ReadKey();
        }
    }
}
