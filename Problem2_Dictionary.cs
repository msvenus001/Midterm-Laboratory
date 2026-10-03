using System;
using System.Collections.Generic;

class Problem2
{
    static void Main()
    {
        Dictionary<string, Student> studentDictionary = new Dictionary<string, Student>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(" STUDENT LOOKUP USING DICTIONARY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student");
            Console.WriteLine("3. Display All Students");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter Student Number: ");
                string number = Console.ReadLine();

                if (studentDictionary.ContainsKey(number))
                {
                    Console.WriteLine("Student Number already exists! Duplicate not allowed.");
                }
                else
                {
                    Student s = new Student();
                    s.StudentNumber = number;

                    Console.Write("Enter Name: ");
                    s.Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    s.Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    s.YearLevel = int.Parse(Console.ReadLine());

                    studentDictionary.Add(number, s);
                    Console.WriteLine("Student added successfully!");
                }
            }

            else if (choice == "2")
            {
                Console.Write("Enter Student Number to search: ");
                string key = Console.ReadLine();

                if (studentDictionary.ContainsKey(key))
                {
                    Student s = studentDictionary[key];
                    Console.WriteLine("Student Found!");
                    Console.WriteLine("Student Number: " + s.StudentNumber);
                    Console.WriteLine("Name: " + s.Name);
                    Console.WriteLine("Program: " + s.Program);
                    Console.WriteLine("Year Level: " + s.YearLevel);
                }
                else
                {
                    Console.WriteLine("Student Number does not exist!");
                }
            }

            else if (choice == "3")
            {
                Console.WriteLine("========================================");
                Console.WriteLine(" STUDENT RECORDS");
                Console.WriteLine("========================================");

                if (studentDictionary.Count == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    foreach (KeyValuePair<string, Student> pair in studentDictionary)
                    {
                        Student s = pair.Value;
                        Console.WriteLine("Student Number: " + s.StudentNumber);
                        Console.WriteLine("Name: " + s.Name);
                        Console.WriteLine("Program: " + s.Program);
                        Console.WriteLine("Year Level: " + s.YearLevel);
                        Console.WriteLine();
                    }
                }
            }

            else if (choice == "4")
            {
                Console.WriteLine("Program exited.");
                running = false;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }
}