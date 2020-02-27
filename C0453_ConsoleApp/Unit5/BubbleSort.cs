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
        private const int MAXN_SIZE = 20;
        public int[] numberArray;
        public string[] namesArray;

        /// <summary>
        /// This method asks the user the numbers they want to sort
        /// </summary>
        public void InputNumbers()
        {
            numberArray = new int[MAXN_SIZE];
            for (int i = 0; i < MAXN_SIZE; i++)
            {
                Console.Write("Enter number to sort: ");
                numberArray[i] = Convert.ToInt32(Console.ReadLine());
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
        /// This method displays the numbers once they have been sorted
        /// </summary>
        public void DisplayNumbers()
        {
            Console.Clear();
            Console.WriteLine("Numbers in Sorted Order: ");
            for (int i = 0; i < MAXN_SIZE; i++)
            {
                Console.WriteLine(numberArray[i]);
            }
        }

        /// <summary>
        /// This method asks the user to input the names/words/letters they want to be sorted alphabetically
        /// </summary>
        public void InputNames()
        {
            namesArray = new string[MAXN_SIZE];
            for (int i = 0; i < MAXN_SIZE; i++)
            {
                Console.Write("Enter names to sort: ");
                namesArray[i] = Console.ReadLine();
            }
        }

        /// <summary>
        /// This method sorts the names alphabetically using the bubble sort method
        /// </summary>
        public void SortNames()
        {
            string nameSwap;
            for (int I = 0; I < MAXN_SIZE; I++)
            {
                for (int J = 0; J < MAXN_SIZE - 1; J++)
                {
                    if (namesArray[J].CompareTo(namesArray[J + 1]) > 0)
                    {
                        nameSwap = namesArray[J];
                        namesArray[J] = namesArray[J + 1];
                        namesArray[J + 1] = nameSwap;
                    }
                }
            }
        }

        /// <summary>
        /// This method displays the names once they have been sorted by the SortNames method
        /// </summary>
        public void DisplayNames()
        {
            Console.Clear();
            Console.WriteLine("Names in Sorted Order: ");
            for (int i = 0; i < MAXN_SIZE; i++)
            {
                Console.WriteLine(namesArray[i]);
            }
        }
    }
}