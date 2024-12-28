using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<string> tasks = new List<string>();

        static void Main(string[] args)
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("\nChoose an action:");
                Console.WriteLine("1. Add task");
                Console.WriteLine("2. View tasks");
                Console.WriteLine("3. Mark task as complete");
                Console.WriteLine("4. Remove task");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine() ?? "";

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        MarkTaskAsComplete();
                        break;
                    case "4":
                        RemoveTask();
                        break;
                    case "5":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        static void AddTask()
        {
            Console.Write("Enter task description: ");
            string task = Console.ReadLine() ?? "";
            tasks.Add(task);
            Console.WriteLine("Task added!");
        }

        static void ViewTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }

        static void MarkTaskAsComplete()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            ViewTasks(); 

            Console.Write("Enter the number of the task to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks[taskNumber - 1] += " (Done)"; 
                Console.WriteLine("Task marked as complete!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void RemoveTask()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks in the list.");
                return;
            }

            ViewTasks(); 

            Console.Write("Enter the number of the task to remove: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
            {
                tasks.RemoveAt(taskNumber - 1); 
                Console.WriteLine("Task removed!");
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }
    }
}