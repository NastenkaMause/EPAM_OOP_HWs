using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsGoToTheShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Let's start shopping together\nFirst, How much money u have for now?\n\n\nTips: enter only a numbers, please.");
            int MoneyHave = int.Parse(Console.ReadLine());
            if (MoneyHave > 0)
            {
                Console.WriteLine("So, Do u need a milk?\nHow much it cost?");
                int MilkCost = int.Parse(Console.ReadLine());
                Console.WriteLine("Oh, And how many packs of milk do u need?");
                int MilkNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Ok, Do u need a butter?\nHow much it cost?");
                int ButterCost = int.Parse(Console.ReadLine());
                Console.WriteLine("And how many packs of butter do u need?");
                int ButterNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Hmm, Do u need a bread?\nHow much it cost?");
                int BreadCost = int.Parse(Console.ReadLine());
                Console.WriteLine("How many packs of bread do u need?");
                int BreadNum = int.Parse(Console.ReadLine());
                int MoneyUNeed = (MilkNum * MilkCost) + (ButterNum * ButterCost) + (BreadNum * BreadCost);
                Console.WriteLine("Thus, you need " + MoneyUNeed + ", but you have " + MoneyHave);
                if (MoneyHave > MoneyUNeed)
                {
                    int EndBalance = MoneyHave - MoneyUNeed;
                    Console.WriteLine("U can buy all you need. U have enoght money.\nBut your balance will be " + EndBalance + " after shopping.");
                }
                else
                {
                    if (MoneyHave < MoneyUNeed)
                    {
                        int EndBalance = MoneyHave - MoneyUNeed;
                        Console.WriteLine("U can't buy all you need. U haven't enoght money.\nU need " + EndBalance + " for shopping.");
                    }
                }
            }
            else { Console.WriteLine("\nI think, u have a bit little.\nHa-ha... U realy? It's not funny. I don't understand u... Sorry...\n\nPress Enter"); }

            Console.ReadLine();
        }
    }
}
