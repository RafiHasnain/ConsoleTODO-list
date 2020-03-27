using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleTODO
{
    class Program
    {
        public static void Main(string[] args)
        {
            var taskList = new TaskList();

            // taskList.Add("Dishes", "Need to finish dishes after dinner.");
            Console.WriteLine("How many task do need to complete today?");
            String a = Console.ReadLine();
            int n = Int32.Parse(a);
            // Console.WriteLine(n);
            for (int i = 0; i < n; i++)
            {
                taskList.NewTaskItem();
            }
            Console.WriteLine("Do you want to display the task?(y/n)");
            string response = Console.ReadLine().ToUpper();

            if (response == "Y")
            {
                taskList.DisplayList();
            }
            else if (response == "N")
            {
                Console.WriteLine("Thankyou!");
            }
            else
            {

            }
        }
    }

    public class TaskItem
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem() { }

        public TaskItem(string title, string desc)
        {
            Title = title;
            Description = desc;
            IsCompleted = false;
        }
        public TaskItem(int number, string title, string desc)
        {
            Number = number;
            Title = title;
            Description = desc;
            IsCompleted = false;
        }
    }

    public class TaskList : List<TaskItem>
    {
        public TaskList()
        {
        }

        public void Add(string title, string desc)
        {
            int numberOfTasks = this.Count();
            int number = numberOfTasks++;

            this.Add(new TaskItem(number, title, desc));
        }



        public void NewTaskItem()
        {
            string title = String.Empty;
            string desc = String.Empty;

            Console.Write("Enter new task Title: ");
            title = Console.ReadLine().Trim();
           // Console.WriteLine("{0}\n", title);

            Console.Write("Enter new task Description: ");
            desc = Console.ReadLine();
           // Console.WriteLine("\"{0}\"", desc);

            this.Add(title, desc);
        }
        public void DisplayList()
        {
            //Console.CLear();
            //Console.WriteLine("\t Task List");
            Console.WriteLine();
            Console.WriteLine("Num |  Title  | Description");
            Console.WriteLine("---------------------------");
            foreach (var t in this)
            {
                Console.WriteLine("{0}     {1}\t{2}", t.Number.ToString(),
                                                     t.Title,
                                                     t.Description);

            }
        }
    }
}
