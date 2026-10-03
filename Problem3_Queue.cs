using System;
using System.Collections.Generic;

struct StudentRequest
{
    public string StudentNumber;
    public string StudentName;
    public string RequestType;
}

class Problem3
{
    static void Main()
    {
        Queue<StudentRequest> requestQueue = new Queue<StudentRequest>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("========================================");
            Console.WriteLine(" STUDENT REQUEST QUEUE");
            Console.WriteLine("========================================");
            Console.WriteLine("1. Add Request");
            Console.WriteLine("2. View Pending Requests");
            Console.WriteLine("3. Process Request");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                StudentRequest r = new StudentRequest();

                Console.Write("Enter Student Number: ");
                r.StudentNumber = Console.ReadLine();

                Console.Write("Enter Student Name: ");
                r.StudentName = Console.ReadLine();

                Console.Write("Enter Request Type: ");
                r.RequestType = Console.ReadLine();

                requestQueue.Enqueue(r);
                Console.WriteLine("Request added successfully!");
            }

            else if (choice == "2")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("There are no pending requests.");
                }
                else
                {
                    Console.WriteLine("REQUEST QUEUE");

                    StudentRequest[] list = requestQueue.ToArray();
                    for (int i = 0; i < list.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + list[i].StudentName + " - " + list[i].RequestType);
                    }
                }
            }

            else if (choice == "3")
            {
                if (requestQueue.Count == 0)
                {
                    Console.WriteLine("There are no pending requests to process.");
                }
                else
                {
                    StudentRequest r = requestQueue.Dequeue();
                    Console.WriteLine("Processing Request: " + r.StudentName + " - " + r.RequestType);
                    Console.WriteLine("Request processed successfully!");
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