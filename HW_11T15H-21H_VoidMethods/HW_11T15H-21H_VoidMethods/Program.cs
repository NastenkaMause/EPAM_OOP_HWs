using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11T15H_21H_VoidMethods
{
    public class Program
    {

        static void Main(string[] args)
        {
            int index = 0, element = 5, x = 10, y = 10, min = -10, max = 10;

            Console.WriteLine("\r\n\r\nInitial two dimentional array:\r\n");
            int[,] twoDimArray = FillingArrayWithRandomValues(x, y, min, max);
            PrintOutArray(twoDimArray);

            Console.WriteLine("\r\n\r\nInitial one dimentional array:\r\n");
            int[] oneDimArray = FillingArrayWithRandomValues(x, min, max);
            PrintOutArray(oneDimArray);

            Console.WriteLine("\r\n\r\nFinding maximum value in each row of the array:\r\n");
            int[] arrayWithMaxValuesInRows = MaxValueByRow(twoDimArray);
            PrintOutArray(arrayWithMaxValuesInRows);

            Console.WriteLine("\r\n\r\nFinding given element in the array:\r\n");
            FindElement(oneDimArray, element, out index);
            Console.WriteLine($"Element {element} found in given array {index} times");

            Console.WriteLine("\r\n\r\nJoining two arrays with distinct values only:\r\n");
            int[] distinctArray = JoinArraysDistinct(FillingArrayWithRandomValues(x, min, max), FillingArrayWithRandomValues(x, min, max));
            PrintOutArray(distinctArray);

            Console.ReadLine();
        }

        /// <summary>
        /// Creates an array with given length and fills it with random values in given range
        /// </summary>
        /// <param name="lengthX">Length of the array by X asix</param>
        /// <param name="lengthY">Length of the array by Y asix</param>
        /// <param name="minThreshold">minimal value in the range of random values</param>
        /// <param name="maxThreshold">maximum value in the range of random values</param>
        /// <returns>Two dimentional array</returns>
        static int[,] FillingArrayWithRandomValues(int lengthX, int lengthY, int minThreshold, int maxThreshold)
        {
            int[,] array = new int[lengthX, lengthY];
            Random rand = new Random();

            for (int i = 0; i < lengthX; i++)
                for (int j = 0; j < lengthY; j++)
                    array[i, j] = rand.Next(minThreshold, maxThreshold);
            return array;
        }

        /// <summary>
        /// Creates an array with given length and fills it with random values in given range
        /// </summary>
        /// <param name="length">Length of the array</param>
        /// <param name="minThreshold">minimal value in the range of random values</param>
        /// <param name="maxThreshold">maximum value in the range of random values</param>
        /// <returns>One dimentional array</returns>
        static int[] FillingArrayWithRandomValues(int length, int minThreshold, int maxThreshold)
        {
            int[] array = new int[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
                array[i] = rand.Next(minThreshold, maxThreshold);
            return array;
        }

        static void PrintOutArray(int[,] exampleArray)
        {
            for (int i = 0; i < exampleArray.GetLength(0); i++)
                for (int j = 0; j < exampleArray.GetLength(1); j++)
                    Console.Write(exampleArray[i, j] + (i != exampleArray.GetLength(0) && j != exampleArray.GetLength(1) - 1 ? ", " : "\r\n"));
        }

        static void PrintOutArray(int[] exampleArray)
        {
            for (int i = 0; i < exampleArray.Length; i++)
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : "\r\n"));
        }

        static int[] MaxValueByRow(int[,] exampleArray)
        {
            int maxValue = int.MinValue;
            int[] arrayWithMaxValuesInRows = new int[exampleArray.GetLength(0)];

            for (int i = 0; i < exampleArray.GetLength(0); i++)
            {
                maxValue = int.MinValue;
                for (int j = 0; j < exampleArray.GetLength(1); j++)
                    maxValue = maxValue < exampleArray[i, j] ? exampleArray[i, j] : maxValue;
                arrayWithMaxValuesInRows[i] = maxValue;
            }
            return arrayWithMaxValuesInRows;
        }

        static bool FindElement(int[] exampleArray, int element, out int index)
        {
            int number = 0;
            for (int i = 0; i < exampleArray.Length; i++)
            {
                if (exampleArray[i] == element)
                {
                    number++;
                }
            }
            index = number;
            return number > 0;
        }

        public static int[] JoinArraysDistinct(int[] firstExampleArray, int[] secondExampleArray)
        {
            int[] resultArray = new int[firstExampleArray.Length + secondExampleArray.Length];
            for (int i = 0; i < resultArray.Length; i++)
                resultArray[i] = int.MinValue;

            int count = 0;
            for (int i = 0; i < firstExampleArray.Length; i++)
            {
                bool exist = false;
                for (int j = 0; j < resultArray.Length; j++)
                {
                    if (resultArray[j] == int.MinValue)
                        break;
                    if (firstExampleArray[i] == resultArray[j])
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    resultArray[count] = firstExampleArray[i];
                    count++;
                }
            }
            for (int i = 0; i < secondExampleArray.Length; i++)
            {
                bool exist = false;
                for (int j = 0; j < resultArray.Length; j++)
                {
                    if (resultArray[j] == int.MinValue)
                        break;
                    if (secondExampleArray[i] == resultArray[j])
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    resultArray[count] = secondExampleArray[i];
                    count++;
                }
            }
            int[] finalArray = new int[count];
            for (int i = 0; i < finalArray.Length; i++)
                finalArray[i] = resultArray[i];
            return finalArray;
        }
    }
}
