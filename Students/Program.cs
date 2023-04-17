using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections;

namespace Students
{
    class Program
    {

         
        public static void Main()
        {
            List<Student> StudentList = new();

            if (File.Exists("StudentList.txt"))
            {
                string[] lines = File.ReadAllLines("StudentList.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        StudentList.Add(new Student(parts[0], parts[1], parts[2]));
                    }
                }
            }

            bool repeat = true;

            do
            {  
                Console.WriteLine("(1) Add student");
                Console.WriteLine("(2) Remove student");
                Console.WriteLine("(3) List students");
                Console.WriteLine("(4) Save and exit");

                string choice = Console.ReadLine();
                if (choice == "1")
                {
                    Console.WriteLine("Enter Name, Course And Phone Number: ");
                    StudentList.Add(new(Console.ReadLine(), Console.ReadLine(), Console.ReadLine()));
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Enter the name of the student to remove: ");
                    string nameToRemove = Console.ReadLine();
                    Student studentToRemove = StudentList.Find(s => s.Name == nameToRemove);
                    if (studentToRemove != null)
                    {
                        StudentList.Remove(studentToRemove);
                        Console.WriteLine("Student removed.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Student not found.");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("- Students -");
                    foreach (var student in StudentList)
                    {
                        Console.WriteLine("{0},{1},{2}", "Name: " + student.Name, " Course: " + student.Course, " Phone Number: " + student.PhoneNum);
                    }
                    Console.WriteLine("\n(e) Exit");
                    if (Console.ReadLine() == "e")
                    {
                        Console.Clear();
                    }
                }
                else if (choice == "4")
                {
                    using (StreamWriter sw = new("StudentList.txt"))
                    {
                        foreach (var student in StudentList)
                        {
                            sw.WriteLine("{0},{1},{2}", student.Name, student.Course, student.PhoneNum);
                        }
                    }
                    Environment.Exit(0);
                }
            }while (repeat == true);
        }
    }
}