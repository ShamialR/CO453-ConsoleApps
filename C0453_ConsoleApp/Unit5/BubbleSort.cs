using System;
using System.Collections.Generic;
using System.Text;

namespace C0453_ConsoleApp.Unit5
{
        class Bubble
        {
            int[] array;
            int MAX = 20;

            public void InputNumbers()
            {
                array = new int[MAX];
                for (int i = 0; i < MAX; i++)
                {
                    Console.Write("Enter number to sort: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void Display()
            {
                Console.Clear();
                Console.WriteLine("Numbers in Sorted Order: ");
                for (int i = 0; i < MAX; i++)
                {
                    Console.WriteLine(array[i]);
                }
            }

            public void SortNumbers()
            {
                int TempNum;
                for (int i = 0; i < array.Length; i++) //loop N times (size of the array)
                {
                    for (int j = 0; j < array.Length - 1; j++) // loop from 1 to N-1
                    {
                        if (array[j] > array[j + 1]) // swap values 
                        {
                            TempNum = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = TempNum;
                        }
                    }
                }
            }
        }
    }