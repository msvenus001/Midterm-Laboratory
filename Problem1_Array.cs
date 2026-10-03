using System;

struct Student
{
    public string StudentNumber;
    public string Name;
    public string Program;
    public int YearLevel;
}

class Problem1
{
    static void Main()
    {
        Student[] students = new Student[10];
        int studentCount = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(" STUDENT RECORD MANAGEMENT");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Display All Students");
            Console.WriteLine("3. Search Student");
            Console.WriteLine("4. Update Student");
            Console.WriteLine("5. Delete Student");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (studentCount == 10)
                {
                    Console.WriteLine("Cannot add. The list is already full.");
                }
                else
                {
                    Console.Write("Enter Student Number: ");
                    students[studentCount].StudentNumber = Console.ReadLine();

                    Console.Write("Enter Name: ");
                    students[studentCount].Name = Console.ReadLine();

                    Console.Write("Enter Program: ");
                    students[studentCount].Program = Console.ReadLine();

                    Console.Write("Enter Year Level: ");
                    students[studentCount].YearLevel = int.Parse(Console.ReadLine());

                    studentCount++;
                    Console.WriteLine("Student added successfully!");
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("========================================");
                Console.WriteLine(" STUDENT RECORDS");
                Console.WriteLine("========================================");

                if (studentCount == 0)
                {
                    Console.WriteLine("No student records found.");
                }
                else
                {
                    for (int i = 0; i < studentCount; i++)
                    {
                        Console.WriteLine("Student Number: " + students[i].StudentNumber);
                        Console.WriteLine("Name: " + students[i].Name);
                        Console.WriteLine("Program: " + students[i].Program);
                        Console.WriteLine("Year Level: " + students[i].YearLevel);
                        Console.WriteLine();
                    }
                }
            }

            else if (choice == "3")
            {
                Console.Write("Enter Student Number to search: ");
                string key = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == key)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Student not found!");
                }
                else
                {
                    Console.WriteLine("Student Found!");
                    Console.WriteLine("Student Number: " + students[index].StudentNumber);
                    Console.WriteLine("Name: " + students[index].Name);
                    Console.WriteLine("Program: " + students[index].Program);
                    Console.WriteLine("Year Level: " + students[index].YearLevel);
                }
            }

            else if (choice == "4")
            {
                Console.Write("Enter Student Number to update: ");
                string key = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == key)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Student not found!");
                }
                else
                {
                    Console.Write("Enter new Name: ");
                    students[index].Name = Console.ReadLine();

                    Console.Write("Enter new Program: ");
                    students[index].Program = Console.ReadLine();

                    Console.Write("Enter new Year Level: ");
                    students[index].YearLevel = int.Parse(Console.ReadLine());

                    Console.WriteLine("Student updated successfully!");
                }
            }

            else if (choice == "5")
            {
                Console.Write("Enter Student Number to delete: ");
                string key = Console.ReadLine();

                int index = -1;
                for (int i = 0; i < studentCount; i++)
                {
                    if (students[i].StudentNumber == key)
                    {
                        index = i;
                        break;
                    }
                }

                if (index == -1)
                {
                    Console.WriteLine("Student not found!");
                }
                else
                {
                    students[studentCount - 1] = default(Student);
                    studentCount--;

                    Console.WriteLine("Student deleted successfully!");
                }
            }

            else if (choice == "6")
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