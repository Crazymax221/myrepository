
using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<TaskItem> tasks = new List<TaskItem>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n list menu:");
            Console.WriteLine("1. Add case");
            Console.WriteLine("2. Remove all cases");
            Console.WriteLine("3. Mark task as completed");
            Console.WriteLine("4. Delete the case");
            Console.WriteLine("5. exit");

            Console.Write("\nChoose an action: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskAsDone();
                    break;
                case "4":
                    DeleteTask();
                    break;
                case "5":
                    Console.WriteLine(" end!");
                    return;
                default:
                    Console.WriteLine(" Incorrect choice, try again.");
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.Write(" Enter the name of the case: ");
        string taskName = Console.ReadLine();
        tasks.Add(new TaskItem(taskName));
        Console.WriteLine(" Case added!");
    }

    static void ShowTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine(" The to-do list is empty.!");
            return;
        }

        Console.WriteLine("\n Your business:");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. [{(tasks[i].IsDone ? "cor" : " ")}] {tasks[i].Name}");
        }
    }

    static void MarkTaskAsDone()
    {
        ShowTasks();
        Console.Write(" Enter the case number for the mark.: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks[index - 1].IsDone = true;
            Console.WriteLine(" The task has been marked as completed.!");
        }
        else
        {
            Console.WriteLine(" Incorrect number!");
        }
    }

    static void DeleteTask()
    {
        ShowTasks();
        Console.Write(" Enter the case number to delete: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= tasks.Count)
        {
            tasks.RemoveAt(index - 1);
            Console.WriteLine(" Case deleted!");
        }
        else
        {
            Console.WriteLine("  Incorrect number!");
        }
    }
}

class TaskItem
{
    public string Name { get; }
    public bool IsDone { get; set; }

    public TaskItem(string name)
    {
        Name = name;
        IsDone = false;
    }
}