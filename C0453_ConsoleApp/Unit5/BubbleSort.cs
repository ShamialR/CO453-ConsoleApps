using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.4 Bubble Sort
    /// This class will sort numbers or words entered, numbers from lowest to highest and words alphabetically
    /// Author: Shamial Rashid 21905385
    /// </summary>
    class Bubble
        {
        int[] Array; 
        int MAX = 20;
        /// <summary>
        /// This method asks the user the numbers they want to sort
        /// </summary>
        public void InputNumbers()
        {
            Array = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter number to sort: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method displays the numbers once they have been sorted
        /// </summary>
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
        /// <summary>
        /// This method uses the bubble sort method to sort the numbers entered above in the InputNumbers method
        /// </summary>
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
        /// <summary>
        /// This method asks the user to input the names/words/letters they want to be sorted alphabetically
        /// </summary>
        public void InputNames()
        {
            Array = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter number to sort: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method displays the names once they have been sorted by the SortNames method
        /// </summary>
        public void DisplayNames()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(Array[i]);
            }
        }
        /// <summary>
        /// This method sorts the names alphabetically using the bubble sort method
        /// </summary>
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