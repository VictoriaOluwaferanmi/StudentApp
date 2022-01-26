using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentApp
{
    public class Student : Persson
    {
        public string Registration { get; }
        public Levels StudentLevel { get; set; }

        private static int _numberOfRegistration = 0;

        public static List<Student> Students = new List<Student>();
        
     
        public Student(string firstName, string lastName, string email, string phone, string address, Levels studentLevel ):base(firstName, lastName, email, phone, address)

        {
            Registration= GetRegistrationNumber();
            StudentLevel = studentLevel;
            _numberOfRegistration++;
        }


        public void PrintRegistrationDetails()
        {
            // Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Dear {FirstName},You are welcome to the Learning Space, Your Registration Number is {Registration}");
           
        }

        private string GetRegistrationNumber()
        {
            return $"SD{_numberOfRegistration.ToString("000")}";
        }

        public void AddToStudent()
        {
            Students[_numberOfRegistration] = this;
        }


        public static  void PrintStudents()
        {
            for (var i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{Students[i].Registration}- {Students[i].FirstName}");
            }

        }
    }
}