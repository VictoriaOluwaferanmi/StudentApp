using System;

namespace StudentApp

{
    class Program
    {
        static void Main(string[] args)
        {
           // Random rand = new Random();
            
           // var c = (char) ('A' + rand.Next(0, 26));
            
                //Console.WriteLine(c);
                
                Console.WriteLine("-----------------STUDENT REGISTRATION");
                Console.Write("How many students do you want to register");
                for (int i= int.Parse(Console.ReadLine()); i>0; i--)
                {

                    Console.Write("Enter your first Name:");
                    var firstName = Console.ReadLine();

                    Console.Write("Enter your LastName:");
                    var lastName = Console.ReadLine();

                    Console.Write("Enter your Email");
                    var email = Console.ReadLine();

                    Console.Write("Enter your Phone Number:");
                    var phone = Console.ReadLine();

                    Console.Write("Enter your address");
                    var address = Console.ReadLine();

                    Console.Write("Choose your level");
                    Console.Write("/t1. SS1");
                    Console.Write("/t2. SS2");
                    Console.Write("/t3. SS3");
                    var level = (Levels) int.Parse(Console.ReadLine());

                    Student student = new Student(firstName, lastName, email, phone, address, level);

                    student.PrintRegistrationDetails();
                }
                
                Console.WriteLine();
                Console.WriteLine("------------------ALL STUDENTS");
                Student.PrintStudents();

        }
    }
}