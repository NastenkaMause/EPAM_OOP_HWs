using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_11T22H_28H_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle with no parameters. Width = 3, Height = 4");
            var rectangle = new Rectangle();
            Console.WriteLine("Square = " + rectangle.Square());
            Console.WriteLine("Perimeter = " + rectangle.Perimeter());
            Console.WriteLine("Diagonal = " + rectangle.Diagonal());
            Console.WriteLine("IsQuadrate = " + rectangle.IsQuadrate());

            Console.WriteLine("\r\nEnter width for the rectangle. Height is 5");
            int width;
            while (!Int32.TryParse(Console.ReadLine(),out width))
            {
                Console.WriteLine("Please entr valid integer");
            }
            var rectangle2 = new Rectangle(width);
            Console.WriteLine("Square = " + rectangle2.Square());
            Console.WriteLine("Perimeter = " + rectangle2.Perimeter());
            Console.WriteLine("Diagonal = " + rectangle2.Diagonal());
            Console.WriteLine("IsQuadrate = " + rectangle2.IsQuadrate());

            Console.WriteLine("\r\nEnter width for the rectangle.");
            while (!Int32.TryParse(Console.ReadLine(), out width))
            {
                Console.WriteLine("Please entr valid integer");
            }

            Console.WriteLine("\r\nEnter height for the rectangle.");
            int height;
            while (!Int32.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Please entr valid integer");
            }

            var rectangle3 = new Rectangle(height, width);
            Console.WriteLine("Square = " + rectangle3.Square());
            Console.WriteLine("Perimeter = " + rectangle3.Perimeter());
            Console.WriteLine("Diagonal = " + rectangle3.Diagonal());
            Console.WriteLine("IsQuadrate = " + rectangle3.IsQuadrate());

            Console.ReadLine();
        }
    }

    class Rectangle
    {
        int height, width;

        public Rectangle()
        {
            height = 4;
            width = 3;
        }

        public Rectangle(int width)
        {
            height = 5;
            this.width = width;
        }

        public Rectangle(int height, int width)
        {
            this.height = height;
            this.width = width;
        }

        public int Square()
        {
            return height * width;
        }

        public int Perimeter()
        {
            return 2 * (height + width);
        }

        public bool IsQuadrate()
        {
            return height == width;
        }

        public double Diagonal()
        {
            var d =Math.Sqrt(height * height + width * width);
            return d;
        }
    }
}
