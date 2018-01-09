using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18_01T06H12H
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            DictionaryStudents ds = new DictionaryStudents();

            ds.AddStudents(n);
            ds.ListStudents();

            Console.ReadLine();
        }
    }
}
