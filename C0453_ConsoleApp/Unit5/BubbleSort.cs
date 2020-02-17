using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit5
{
        class Bubble
        {
            int[] Array;
            int MAX = 20;

            public void InputNumbers()
            {
                Array = new int[MAX];
                for (int i = 0; i < MAX; i++)
                {
                    Console.Write("Enter number to sort: ");
                    Array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void Display()
            {
                Console.Clear();
                Console.WriteLine("Numbers in Sorted Order: ");
                for (int i = 0; i < MAX; i++)
                {
                    Console.WriteLine(Array[i]);
                }
            }

            public void SortNumbers()
            {
                int TempNum;
                for (int i = 0; i < Array.Length; i++) //loop N times (size of the Array)
                {
                    for (int j = 0; j < Array.Length - 1; j++) // loop from 1 to N-1
                    {
                        if (Array[j] > Array[j + 1]) // swap values 
                        {
                            TempNum = Array[j];
                            Array[j] = Array[j + 1];
                            Array[j + 1] = TempNum;
                        }
                    }
                }
            }
        public void InputNames()
        {
            Array = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter number to sort: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayNames()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }

        public void SortNames()
        {
            int TempNum;
            for (int i = 0; i < Array.Length; i++) //loop N times (size of the Array)
            {
                for (int j = 0; j < Array.Length - 1; j++) // loop from 1 to N-1
                {
                    if (Array[j] > Array[j + 1]) // swap values 
                    {
                        TempNum = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = TempNum;
                    }
                }
            }
        }
    }
    }