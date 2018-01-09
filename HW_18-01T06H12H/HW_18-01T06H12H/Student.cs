using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_18_01T06H12H
{
    internal class Student
    {
        internal string FirstName { get; set; }
        internal string LastName { get; set; }

        internal Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    internal class StudentComparator : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.LastName == y.LastName)
                return x.FirstName.CompareTo(y.FirstName);
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
