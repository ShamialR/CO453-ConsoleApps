using System;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.6 Bates Motel
    /// This class allows users to book a room in Bates Motel
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Motel
    {
        int[] Rooms;
        int RoomNumber, Guests;
        int RoomsBooked = 0, TotalGuests = 0, ExcessGuests = 0, GuestsCount = 0;
        const int MAX = 20;

        /// <summary>
        /// This method allows Rooms from 1 to MAX 
        /// </summary>
        public Motel()
        {
            Rooms = new int[MAX + 1];
        }
        /// <summary>
        /// This method displays the menu where people can choose what they want to do, once they've chosen it calls said method
        /// </summary>
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
                    BookRoom();
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
        /// <summary>
        /// Thismethod allows the user to book a room in the hotel as long as its not already booked and only allows 4 people per room
        /// </summary>
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

            do
            {
                Console.Write("How many guests : ");

                Guests = Convert.ToInt32(Console.ReadLine());
                if (Guests > 4)
                {
                    Console.WriteLine("You can only have less then 4 guests booked within room " + RoomNumber);
                }
            }
            while (Guests > 4);
            Rooms[RoomNumber] = Guests;
            Console.WriteLine("Room " + RoomNumber + " booked for " + Guests + " people");
            TotalGuests += Guests;
            RoomsBooked++;
        }
        /// <summary>
        /// This method shows all the rooms in  the hotel and displays the number of people staying in each room
        /// </summary>
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
        /// <summary>
        /// This allows the user to vacate a room, so it sets the rooms guest count to 0 so it can be booked again
        /// </summary>
        public void VacateOneRoom()
        {
            Console.Write("Which Room would you like to vacate: ");
            RoomNumber = Convert.ToInt32(Console.ReadLine());
            TotalGuests = TotalGuests - Rooms[RoomNumber];
            Rooms[RoomNumber] = 0;
            Console.Write("Room " + RoomNumber + " has been vacated");
            RoomsBooked -= 1;
            Console.ReadKey();
        }
        /// <summary>
        /// this method sets all the rooms in the motels guest count to zero
        /// </summary>
        public void VacateAllRooms()
        {
            for(int i = 1; i < MAX+1; i++)
            {
                Rooms[i] = 0;
            }
            RoomsBooked = 0;
            TotalGuests = 0;
            Console.ReadKey();
        }
        /// <summary>
        /// This is a method made for management where it displays information about the motel, including rooms currently booked, total number of guests and how many empty rooms there are
        /// </summary>
        public void ManagementInformation()
        {
            int EmptyRooms = 20 - RoomsBooked;
            Console.WriteLine("Currently " + RoomsBooked + " Rooms have been booked");
            Console.WriteLine("Currently there are " + TotalGuests + " Guests");
            Console.WriteLine("Currently there are " + EmptyRooms + " empty Rooms");
            Console.ReadKey(); 
        }
    }
}
