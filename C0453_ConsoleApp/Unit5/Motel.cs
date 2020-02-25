using System;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.6 Bates Motel
    /// This class allows users to book a room in Bates Motel using a menu where you can book a room, vacate one room, vacate all rooms, see all rooms and see management information
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Motel
    {
        private int[] rooms;
        public const int MAXN_ROOMS = 20;
        private int roomNumber, guests;
        private int roomsBooked = 0, totalGuests = 0;

        /// <summary>
        /// This method allows Rooms from 1 to MAX 
        /// </summary>
        public Motel()
        {
            rooms = new int[MAXN_ROOMS + 1];
        }

        /// <summary>
        /// This method displays the menu where people can choose what they want to do, once they've chosen it calls said method
        /// </summary>
        public void RunMotel()
        { 
            string choice;
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
                choice = Console.ReadLine();
                if (choice == "1")
                {
                    BookRoom();
                }
                else if(choice == "2")
                {
                    VacateOneRoom();
                }
                else if(choice == "3")
                {
                    ShowAllRooms();
                }
                else if (choice == "4")
                {
                    VacateAllRooms();
                }
                else if (choice == "5")
                {
                    ManagementInformation();
                }
            }
            while (choice != "6");
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
            roomNumber = Convert.ToInt32(Console.ReadLine());

            if (rooms[roomNumber] != 0)
            {
                Console.WriteLine("Sorry this Room is already booked");
            }

            do
            {
                Console.Write("How many guests : ");

                guests = Convert.ToInt32(Console.ReadLine());
                if (guests > 4)
                {
                    Console.WriteLine("You can only have less then 4 guests booked within room " + roomNumber);
                }
            }
            while (guests > 4);
            rooms[roomNumber] = guests;
            Console.WriteLine("Room " + roomNumber + " booked for " + guests + " people");
            totalGuests += guests;
            roomsBooked++;
        }

        /// <summary>
        /// This method shows all the rooms in  the hotel and displays the number of people staying in each room
        /// </summary>
        public void ShowAllRooms()
        {
            Console.WriteLine("Bates Motel Room Status");
            Console.WriteLine("=======================");

            for (int i = 1; i < MAXN_ROOMS+1; i++)
            {
                Console.WriteLine("Room " + i + "\t " + rooms[i] + " Guests");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// This allows the user to vacate a room, so it sets the rooms guest count to 0 so it can be booked again
        /// </summary>
        public void VacateOneRoom()
        {
            Console.Write("Which Room would you like to vacate: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());
            totalGuests -= rooms[roomNumber];
            rooms[roomNumber] = 0;
            Console.Write("Room " + roomNumber + " has been vacated");
            roomsBooked -= 1;
            Console.ReadKey();
        }

        /// <summary>
        /// this method sets all the rooms in the motels guest count to zero
        /// </summary>
        public void VacateAllRooms()
        {
            for(int i = 1; i < MAXN_ROOMS+1; i++)
            {
                rooms[i] = 0;
            }
            roomsBooked = 0;
            totalGuests = 0;
            Console.ReadKey();
        }

        /// <summary>
        /// This is a method made for management where it displays information about the motel, including rooms currently booked, total number of guests and how many empty rooms there are
        /// </summary>
        public void ManagementInformation()
        {
            int emptyRooms = 20 - roomsBooked;
            Console.WriteLine("Currently " + roomsBooked + " Rooms have been booked");
            Console.WriteLine("Currently there are " + totalGuests + " Guests");
            Console.WriteLine("Currently there are " + emptyRooms + " empty Rooms");
            Console.ReadKey(); 
        }
    }
}
