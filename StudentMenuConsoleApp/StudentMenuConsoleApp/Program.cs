using System;
using System.Linq;

namespace StudentMenuConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            

            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        public static bool MainMenu()
        {
            Student studentOne = new Student();
            Student studentTwo = new Student();
            studentOne.firstName = "John";
            studentOne.lastName = "Smith";
            studentOne.studentNumber = "1234";
            Student[] studentArray = new Student[2];
            studentArray[0] = studentOne;

            Console.Clear();
            Console.WriteLine("Choose an option by typing the number of the option you wish to select.");
            Console.WriteLine("1) Enter a student");
            Console.WriteLine("2) Display a student");
            Console.WriteLine("3) Display all students");
            Console.WriteLine("4) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("What is the student's first name?");
                    studentTwo.firstName = Console.ReadLine();
                    Console.WriteLine("What is the student's last name?");
                    studentTwo.lastName = Console.ReadLine();
                    Console.WriteLine("What is the student's number?");
                    studentTwo.studentNumber = Console.ReadLine();
                    studentArray[1] = studentTwo;
                    Console.WriteLine("Student Entered.");
                    Console.ReadLine();
                    return true;
                case "2":
                    Console.WriteLine("What is the student's number?");
                    string num = Console.ReadLine();
                    foreach(Student value in studentArray)
                    {
                        if(value.studentNumber == num)
                        {
                            Console.WriteLine("Here is the student: " + value.firstName + " " + value.lastName);
                        }
                        else
                        {
                            Console.WriteLine("I'm sorry. The student doesn't exist in our database.");
                        }
                        Console.ReadLine();
                    }
                    return true;
                case "3":
                    Console.WriteLine("Here is a list of all the students:");
                    foreach(Student student in studentArray)
                    {
                        Console.WriteLine("     " + student.firstName + " " + student.lastName + " - " + student.studentNumber);
                    }
                    Console.ReadLine();
                    return true;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return false;
                default:
                    return true;
            }
        }
    }
    public struct Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string studentNumber { get; set; }
    }
}
