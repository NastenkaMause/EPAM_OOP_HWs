using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11T8H_14H_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ReplasingMinAndMaxInArray();
            SortingArray();
            TwoDimentionArray();

            Console.ReadLine();
        }

        private static void ReplasingMinAndMaxInArray()
        {
            int[] exampleArray = new int [10];
            Random rand = new Random();
            int minValue = int.MaxValue, maxValue = int.MinValue;

            Console.WriteLine("Initial Array: ");

            for (int i = 0; i < exampleArray.Length; i++)
            {
                exampleArray[i] = rand.Next(-3, 3);

                maxValue = exampleArray[i] > maxValue ? exampleArray[i] : maxValue;
                minValue = (exampleArray[i] < minValue) ? exampleArray[i] : minValue;
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : ""));
            }

            for(int i = 0; i < exampleArray.Length; i++)
                exampleArray[i] = exampleArray[i] == maxValue ? minValue : exampleArray[i] == minValue ? maxValue : exampleArray[i];

            Console.WriteLine("\r\nUpdated Array: ");

            for (int i = 0; i < exampleArray.Length; i++)
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : ""));
        }
        private static void SortingArray()
        {
            int[] exampleArray = new int[10];
            Random rand = new Random();

            Console.WriteLine("\r\n\r\nInitial Array: ");

            for (int i = 0; i < exampleArray.Length; i++)
            {
                exampleArray[i] = rand.Next(-3, 3);
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : ""));
            }

            int temp;
            for (int i = 0; i < exampleArray.Length-1; i++)
            {
                for (int j = i + 1; j < exampleArray.Length; j++)
                {
                    if (exampleArray[i] > exampleArray[j])
                    {
                        temp = exampleArray[i];
                        exampleArray[i] = exampleArray[j];
                        exampleArray[j] = temp;
                    }
                }
            }

            Console.WriteLine("\r\nSorted Array: ");

            for (int i = 0; i < exampleArray.Length; i++)
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : ""));

        }
        private static void TwoDimentionArray()
        {
            const int column = 10, row = 10;
            int[,] exampleArray = new int[column,row];
            Random rand = new Random();

            Console.WriteLine("\r\n\r\nInitial Array: ");

            for (int i = 0; i < column; i++)
                for (int j = 0; j < row; j++)
                {
                    exampleArray[i, j] = rand.Next(-10, 10);
                    Console.Write(exampleArray[i, j] + ((i != column) && (j != row - 1) ? ", " : "\r\n"));
                }

            int maxValue = int.MinValue;
            for (int i = 0, temp = 0; i < column; i++, temp++)
                for (int j = temp; j < row; j++)
                {
                    maxValue = maxValue < exampleArray[i, j] ? exampleArray[i, j] : maxValue;
                }

            Console.WriteLine("Max element in upper-right triangle is: " + maxValue);

            maxValue = 0;
            for (int i = 0, temp = 0; i < column; i++, temp++)
                for (int j = 0; j <= temp; j++)
                {
                    if (exampleArray[i, j] > 0)
                        maxValue++;
                }
            Console.WriteLine("Number of positive elements in lower-left triangle is: " + maxValue);
        }
    }
}
