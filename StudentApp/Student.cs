using System;
using System.ComponentModel.DataAnnotations;

namespace StudentApp
{
    public class Student : Persson
    {
        public string Registration { get; }
        public Levels StudentLevel { get; set; }

        private static int _numberOfRegistration = 0;

        private static Student[] _students = new Student[10];
        
     
        public Student(string firstName, string lastName, string email, string phone, string address, Levels studentLevel ):base(firstName, lastName, email, phone, address)

        {
            Registration= GetRegistrationNumber();
            StudentLevel = studentLevel;
            _numberOfRegistration++;
        }


        public void PrintRegistrationDetails()
        {
            Console.WriteLine($"Dear {FirstName},You are welcome to the Learning Space, Your Registration Number is {Registration}");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }

        private string GetRegistrationNumber()
        {
            return $"SD{_numberOfRegistration.ToString(format: "000")}";
        }

        public void AddToStudent()
        {
            _students[_numberOfRegistration] = this;
        }


        public void PrintStudents()
        {
            for (var i = 0; i < _numberOfRegistration; i++)
            {
                Console.WriteLine($"{i + 1}.{_students[i].Registration}- {_students[i].FirstName}");
            }

        }
    }
}