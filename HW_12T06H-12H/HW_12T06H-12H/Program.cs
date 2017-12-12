using System;
using System.Text.RegularExpressions;

namespace HW_12T06H_12H
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentsGroup group_001 = new StudentsGroup("No. 001", 3);
            Teacher examiner = new Teacher("Kajiura", "Yuki", "Spesial computer systems");
            Exam exam1 = new Exam("Technologies of secure programming", examiner, group_001);
            Exam exam2 = new Exam("Web Technologies", examiner, group_001);

            for (var i = 0; i < group_001.ListOfStudents.Length; i++)
                group_001.AddStudent();

            exam1.ProcessExam();
            exam1.ResultExam();

            group_001.AddStudent();
            group_001.RemoveStudent();
            group_001.AddStudent();
            exam2.ProcessExam();
            exam2.ResultExam();

            Console.ReadLine();
        }
    }

    abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    internal class Student : Person
    {
        public int Grade { get; set; }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }

    internal class Teacher : Person
    {
        public string Department { get; set; }

        public Teacher(string firstName, string lastName, string department)
        {
            FirstName = firstName;
            LastName = lastName;
            Department = department;
        }
    }

    internal class StudentsGroup
    {
        public string GroupNumber { get; set; }
        public Student[] ListOfStudents { get; set; }

        public StudentsGroup(string groupNumber, int count)
        {
            GroupNumber = groupNumber;
            ListOfStudents = new Student[count];
        }

        internal void AddStudent()
        {
            Console.WriteLine("Enter information about a student");
            var newStudentFirstName = AddName("First name");
            var newStudentLastName = AddName("Last name");
            for (var i = 0; i < ListOfStudents.Length; i++)
            {
                if (ListOfStudents[i] == null)
                {
                    ListOfStudents[i] = new Student(newStudentFirstName, newStudentLastName);
                    Console.WriteLine("Student " + newStudentFirstName + " " + newStudentLastName + " has been added to group " + GroupNumber);
                    break;
                }
                if (i == ListOfStudents.Length - 1)
                {
                    Console.WriteLine("There are no free places in the group " + GroupNumber + ". You cannot add more students");
                }
            }
        }

        private string AddName(string nameType)
        {
            var regex = @"^[A-Z][-a-zA-Z]+$";
            while (true)
            {
                Console.WriteLine(nameType + ": ");
                var input = Console.ReadLine();
                if (Regex.Match(input, regex).Success)
                    return input;
                Console.WriteLine(nameType + " cannot be " + input);
            }
        }

        internal void RemoveStudent()
        {
            Console.WriteLine("Enter information about a student you want to remove");
            var removedStudentFirstName = AddName("First name");
            var removedStudentLastName = AddName("Last name");
            for (var i = 0; i < ListOfStudents.Length; i++)
            {
                if (ListOfStudents[i].LastName == removedStudentLastName && ListOfStudents[i].FirstName == removedStudentFirstName)
                {
                    ListOfStudents[i] = null;
                    Console.WriteLine("Student " + removedStudentFirstName + " " + removedStudentLastName + " has been removed from group " + GroupNumber);
                    break;
                }
                if (i == ListOfStudents.Length - 1)
                {
                    Console.WriteLine("There are no student " + removedStudentFirstName + " " + removedStudentLastName + " in the group " + GroupNumber);
                }
            }

        }
    }

    internal class Exam
    {
        string academicDiscipline;
        Teacher examiner;
        StudentsGroup studentsGroup;

        public Exam(string academicDiscipline, Teacher examiner, StudentsGroup studentsGroup)
        {
            this.academicDiscipline = academicDiscipline;
            this.examiner = examiner;
            this.studentsGroup = studentsGroup;
        }

        public void ProcessExam()
        {
            var randomGrade = new Random();
            foreach (var student in studentsGroup.ListOfStudents)
                if (student != null)
                    student.Grade = randomGrade.Next(60, 100);
        }

        public void ResultExam()
        {
            Console.WriteLine("\r\nDiscipline: {0}\r\nGroup number: {1}", academicDiscipline, studentsGroup.GroupNumber);
            Console.WriteLine("Student name | Grade");
            foreach (var student in studentsGroup.ListOfStudents)
                if (student != null)
                    Console.WriteLine(student.FirstName + " " + student.LastName + " | " + student.Grade);
            Console.WriteLine("Examiner: {0} {1}, {2}", examiner.FirstName, examiner.LastName, examiner.Department);
        }
    }
}