using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,\nplease enter a first number.");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Now, enter a second number.");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine("And now - third.");
            int thirdNum = int.Parse(Console.ReadLine());
            float Discr = (secondNum * secondNum) - (4 * firstNum * thirdNum);
            if (Discr < 0)
            {
                Console.WriteLine("Is no roots");
            }
            else
            {
                if (Discr == 0)
                {
                    int x = -secondNum / 2 * firstNum;
                    Console.WriteLine("Your root is " + x);
                }
            }
            else
            {
                if (Discr > 0)
                {double firstX = (-secondNum + Math.Sqrt(Discr)) / 2 * firstNum;
                    double secondX = (-secondNum - Math.Sqrt(Discr)) / 2 * firstNum;
                    Console.WriteLine("U have two roots: first is " + firstX + " and second is " +secondX); }            }
            Console.ReadLine();
        }
        
    }
}
