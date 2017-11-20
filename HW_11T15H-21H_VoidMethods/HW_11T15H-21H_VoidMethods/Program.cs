using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11T15H_21H_VoidMethods
{
    class Program
    {
        public const int column = 10, row = 10;

        static void Main(string[] args)
        {
            int[,] filledArray = FillingTwoDimentionalArrays();
            PrintTwoDimentionalArrays(filledArray);

            //Console.WriteLine("\r\nMax value in two-dimantional array by rows:");
            int[] arrayWithMaxValuesInRows = MaxValueInRow(filledArray);

            MaxValueInRow(filledArray);
            PrintOneDimentionalArray(arrayWithMaxValuesInRows);


            Console.ReadLine();
        }

        public static int[,] FillingTwoDimentionalArrays()
        {
            int[,] exampleArray = new int[row, column];
            Random rand = new Random();

            for (int i = 0; i < row; i++)
                for (int j = 0; j < column; j++)
                    exampleArray[i, j] = rand.Next(-10, 10);
            return exampleArray;
        }

        public static void PrintTwoDimentionalArrays(int[,] exampleArray)
        {
            for (int i = 0; i < exampleArray.GetLength(0); i++)
                for (int j = 0; j < exampleArray.GetLength(1); j++)
                    Console.Write(exampleArray[i, j] + (i != exampleArray.GetLength(0) && j != exampleArray.GetLength(1) - 1 ? ", " : "\r\n"));
        }

        public static void PrintOneDimentionalArray(int[] exampleArray)
        {
            for (int i = 0; i < exampleArray.Length; i++)
                Console.Write(exampleArray[i] + (i != exampleArray.Length - 1 ? ", " : ""));
        }

        public static int[] MaxValueInRow(int[,] exampleArray)
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



        private void Second(int[] Arr, string Str) { }
        public static int Third(int[] frtArr, int[] secArr) { return 0; }
        public double Fourth(int[] Arr, double Num) { return 0; }
    }
}
