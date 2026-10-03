using System;
using System.Collections.Generic;

struct Operation
{
    public string Action;
    public string StudentNumber;
    public string StudentName;
}


class Problem4
{
    static void Main()
    {
        Student[] students = new Student[10];
        int studentCount = 0;

        Stack<Operation> operationHistory = new Stack<Operation>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(" OPERATION HISTORY");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Update Student");
            Console.WriteLine("3. Delete Student");
            Console.WriteLine("4. View Operation History");
            Console.WriteLine("5. View Last Operation");
            Console.WriteLine("6. Remove Last Operation");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                if (studentCount == 10)
                {
                    Console.WriteLine("Cannot add. The list is already full (10 students).");
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

                    Operation op = new Operation();
                    op.Action = "Added";
                    op.StudentNumber = students[studentCount].StudentNumber;
                    op.StudentName = students[studentCount].Name;
                    operationHistory.Push(op);

                    studentCount++;
                    Console.WriteLine("Student added successfully!");
                }
            }

            else if (choice == "2")
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

                    Operation op = new Operation();
                    op.Action = "Updated";
                    op.StudentNumber = students[index].StudentNumber;
                    op.StudentName = students[index].Name;
                    operationHistory.Push(op);

                    Console.WriteLine("Student updated successfully!");
                }
            }

            else if (choice == "3")
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
                    Operation op = new Operation();
                    op.Action = "Deleted";
                    op.StudentNumber = students[index].StudentNumber;
                    op.StudentName = students[index].Name;
                    operationHistory.Push(op);

                    for (int i = index; i < studentCount - 1; i++)
                    {
                        students[i] = students[i + 1];
                    }
                    students[studentCount - 1] = default(Student);
                    studentCount--;

                    Console.WriteLine("Student deleted successfully!");
                }
            }

            else if (choice == "4")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("There are no recorded operations.");
                }
                else
                {
                    Console.WriteLine("OPERATION HISTORY");


                    Operation[] list = operationHistory.ToArray();
                    int number = 1;
                    for (int i = list.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(number + ". " + list[i].Action + " " + list[i].StudentName);
                        number++;
                    }
                }
            }

            else if (choice == "5")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("There are no recorded operations.");
                }
                else
                {
                    Operation last = operationHistory.Peek();
                    Console.WriteLine("Last Operation: " + last.Action + " " + last.StudentName);
                }
            }

            else if (choice == "6")
            {
                if (operationHistory.Count == 0)
                {
                    Console.WriteLine("There are no recorded operations.");
                }
                else
                {
                    operationHistory.Pop();
                    Console.WriteLine("Last operation removed successfully!");
                }
            }

            else if (choice == "7")
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