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
        int[] sort; 
        int MAX = 20;
        /// <summary>
        /// This method asks the user the numbers they want to sort
        /// </summary>
        public void InputNumbers()
        {
            sort = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter number to sort: ");
                sort[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method displays the numbers once they have been sorted
        /// </summary>
        public void DisplaySorted()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAX; i++)
            {
                Console.WriteLine(sort[i]);
            }
        }
        /// <summary>
        /// This method uses the bubble sort method to sort the numbers entered above in the InputNumbers method
        /// </summary>
        public void SortNumbers()
        {
            int numberSwap;
            for (int i = 0; i < sort.Length; i++)
            {
                for (int j = 0; j < sort.Length - 1; j++)
                {
                    if (sort[j] > sort[j + 1])
                    {
                        numberSwap = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = numberSwap;
                    }
                }
            }
        }
        /// <summary>
        /// This method asks the user to input the names/words/letters they want to be sorted alphabetically
        /// </summary>
        public void InputNames()
        {
            sort = new int[MAX];
            for (int i = 0; i < MAX; i++)
            {
                Console.Write("Enter number to sort: ");
                sort[i] = Convert.ToInt32(Console.ReadLine());
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
                Console.WriteLine(sort[i]);
            }
        }
        /// <summary>
        /// This method sorts the names alphabetically using the bubble sort method
        /// </summary>
        public void SortNames()
        {
            int nameSwap;
            for (int i = 0; i < sort.Length; i++) //loop N times (size of the Array)
            {
                for (int j = 0; j < sort.Length - 1; j++) // loop from 1 to N-1
                {
                    if (sort[j] > sort[j + 1]) // swap values 
                    {
                        nameSwap = sort[j];
                        sort[j] = sort[j + 1];
                        sort[j + 1] = nameSwap;
                    }
                }
            }
        }
    }
    }