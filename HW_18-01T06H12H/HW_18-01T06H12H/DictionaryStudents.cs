using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HW_18_01T06H12H
{
    internal class DictionaryStudents
    {
        private SortedDictionary<Student, int> dictionary;

        internal DictionaryStudents()
        {
            dictionary = new SortedDictionary<Student, int>(new StudentComparator());
        }

        private void AddStudent(Student st, int mark)
        {
            try
            {
                if (dictionary.Any(x => x.Key.FirstName == st.FirstName && x.Key.LastName == st.LastName))
                    throw new ExistException($"Student {st.FirstName} {st.LastName} already exists in the list");

                if (mark < 0 || mark > 100)
                    throw new RangeException($"Student's mark should be in range of 0...100");

                dictionary.Add(st, mark);
            }
            catch (ExistException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (RangeException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal void AddStudents(int n)
        {
            var regex = @"^[A-Z][-a-zA-Z]+$";
            while (n > 0)
            {
                Console.WriteLine("Enter information about a student");
                Console.WriteLine("Enter first name");
                var firstName = VerifiedOutput(regex);

                Console.WriteLine("Enter last name");
                var lastName = VerifiedOutput(regex);

                Console.WriteLine("Enter student's mark");
                int grade;
                while (true)
                {
                    var grademark = Console.ReadLine();

                    if (!int.TryParse(grademark, out grade))
                    {
                        Console.WriteLine($"Cannot cast {grademark} to Int32");
                        continue;
                    } break;
                }

                AddStudent(new Student(firstName, lastName), grade);
                n--;
            }
        }

        private string VerifiedOutput(string regex)
        {
            while (true)
            {
                var userInput = Console.ReadLine();

                if (!Regex.Match(userInput, regex).Success)
                {
                    Console.WriteLine($"Input cannot be {userInput}");
                    continue;
                }
                return userInput;
            }
        }

        internal void ListStudents()
        {
            int counter = 1;
            foreach (var item in dictionary)
            {
                Console.WriteLine($"{counter}. {item.Key.LastName} {item.Key.FirstName} - {item.Value}");
                counter++;
            }
        }
    }
}
