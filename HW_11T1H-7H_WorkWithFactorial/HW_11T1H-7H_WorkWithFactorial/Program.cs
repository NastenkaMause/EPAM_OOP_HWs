using System;

namespace HW_11T1H_7H_WorkWithFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalculateSumOfDigitsInNumber();
            //CalculateNumberOfPositiveBitsInNumberBinary();
            CalculateSumOfDigitsInNumberFactorial();
        }

        private static void CalculateSumOfDigitsInNumber()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer from 0 to 1,000,000,000");
                Console.WriteLine("Or hit 'Q' for exit");
                string input = Console.ReadLine();
                if (input == null || input == "") continue;
                if (input == "Q" || input == "q") return;
                int number = int.Parse(input);
                if (number < 0 || number > 1000000000) continue;
                int temp = 0;
                string message = "Sum of digits in the number " + input;
                while (number > 0)
                {
                    temp += number % 10;
                    number = number / 10;
                }
                Console.WriteLine(message + " is " + temp);
                Console.WriteLine("Hit 'Y' to continue");
                Console.WriteLine();
                input = Console.ReadLine();
                if (input == "Y" || input == "y") continue;
                return;
            }
        }

        private static void CalculateNumberOfPositiveBitsInNumberBinary()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer from 0 to 1,000,000,000");
                Console.WriteLine("Or hit 'Q' for exit");
                string input = Console.ReadLine();
                if (input == null || input == "") continue;
                if (input == "Q" || input == "q") return;
                int number = int.Parse(input);
                if (number < 0 || number > 1000000000) continue;
                int temp = 0;
                string message = "Sum of positive bits in the number " + input + " binary is ";
                while (number > 0)
                {
                    if (number % 2 == 1)
                        temp++;
                    number = number / 2;
                }
                Console.WriteLine(message + temp);
                Console.WriteLine("Hit 'Y' to continue");
                Console.WriteLine();
                input = Console.ReadLine();
                if (input == "Y" || input == "y") continue;
                return;
            }
        }

        private static void CalculateSumOfDigitsInNumberFactorial()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer from 0 to 1,000,000,000");
                Console.WriteLine("Or hit 'Q' for exit");
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) continue;
                if (input == "Q" || input == "q") return;
                int number;
                if (int.TryParse(input, out number))
                {
                    if (number <= 0 || number > 1000000000) continue;
                    int result = 1;
                    if (number > 1)
                    {
                        int i = 2;
                        while (i <= number)
                        {
                            result *= i;
                            if (result > 9)
                                result = (result / 10) + (result % 10);
                            if (result == 9)
                                break;
                            i++;
                        }
                    }
                    Console.WriteLine("Sum of digits of the number " + input + " factorial is " + result);
                }
                else
                    Console.WriteLine("Couldn't parse input into a number");
                Console.WriteLine("Hit 'Y' to continue");
                input = Console.ReadLine();
                Console.WriteLine();
                if (input == "Y" || input == "y") continue;
                return;
            }
        }
    }
}
