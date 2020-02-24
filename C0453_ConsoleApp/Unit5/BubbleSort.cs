using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0453_ConsoleApp.Unit5
{
    /// <summary>
    /// Task 5.4 Bubble Sort
    /// This class will sort numbers or words entered, numbers from lowest to highest and words alphabetically
    /// Author: Shamial Rashid 21905385
    /// </summary>
        class Bubble
        {
        int[] numberArray;
        string[] namesArray;
        int MAX_SIZE = 20;

        /// <summary>
        /// This method asks the user the numbers they want to sort
        /// </summary>
        public void InputNumbers()
        {
            numberArray = new int[MAX_SIZE];
            for (int i = 0; i < MAX_SIZE; i++)
            {
                Console.Write("Enter number to sort: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        /// <summary>
        /// This method displays the numbers once they have been sorted
        /// </summary>
        public void Display()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAX_SIZE; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }

        /// <summary>
        /// This method uses the bubble sort method to sort the numbers entered above in the InputNumbers method
        /// </summary>
        public void SortNumbers()
        {
            int numberSwap;

            for (int i = 0; i < numberArray.Length; i++)
            {
                for (int j = 0; j < numberArray.Length - 1; j++)
                {
                    if (numberArray[j] > numberArray[j + 1])
                    {
                        numberSwap = numberArray[j];
                        numberArray[j] = numberArray[j + 1];
                        numberArray[j + 1] = numberSwap;
                    }
                }
            }
        }

        /// <summary>
        /// This method asks the user to input the names/words/letters they want to be sorted alphabetically
        /// </summary>
        public void InputNames()
        {
            namesArray = new string[MAX_SIZE];
            for (int i = 0; i < MAX_SIZE; i++)
            {
                Console.Write("Enter names to sort: ");
                namesArray[i] = Console.ReadLine();
            }
            
        }
        /// <summary>
        /// This method displays the names once they have been sorted by the SortNames method
        /// </summary>
        public void DisplayNames()
        {
            Console.Clear();
            Console.WriteLine("Names in Sorted Order: ");
            for (int i = 0; i < MAX_SIZE; i++)
            {
                Console.WriteLine(namesArray[i]);
            }
        }
        /// <summary>
        /// This method sorts the names alphabetically using the bubble sort method
        /// </summary>
        public void SortNames()
        {
            string nameSwap;
            for (int i = 0; i < namesArray.Length; i++) //loop N times (size of the Array)
            {
                for (int j = 0; j < namesArray.Length - 1; j++) // loop from 1 to N-1
                {
                    //if (namesArray[j] > namesArray[j + 1]) // swap values 
                    {
                        nameSwap = namesArray[j];
                        namesArray[j] = namesArray[j + 1];
                        namesArray[j + 1] = nameSwap;
                    }
                }
            }
        }
    }
    }