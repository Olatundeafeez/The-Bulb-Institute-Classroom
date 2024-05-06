using ExProject.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExProject.Models
{
    public class TodoItems
    {
        public TodoItems()
        {
            _taskNumber = 0;
            _task = null;
        }
        private int _taskNumber;
        private TaskItem _task;
        public int TaskNumber { get { return _taskNumber; } }
        public TaskItem Task { get { return _task; } }


        public void AddTask()
        {

            try
            {

                Thread.Sleep(500);
                Console.WriteLine("Please enter the task name!");
                var name = Console.ReadLine();
                Console.WriteLine("Please enter the task description!");
                var description = Console.ReadLine();
                Console.WriteLine("Please enter the date!");
                DateTime dueDate = DateTime.Parse(Console.ReadLine());

                _task = new TaskItem(name, description, dueDate);
                _taskNumber += 1;
                Thread.Sleep(200);
                Console.WriteLine("Please wait.........................................");
                Thread.Sleep(1000);
                Console.WriteLine($"TaskName: { _task.Name}\n\nDescription: {_task.Description}\n\nDueDate: {_task.DueDate}\n\n You have {_taskNumber} amount of tasks");
                Thread.Sleep(200);
                Menu.ReturnToMenuOrExit();
                 
            }
            catch (Exception ex)
            {
                throw new ArgumentNullException(ex.Message);
            }
        }

        public void RemoveTask()
        {
         
                Console.WriteLine($"Enter the task number to remove {_taskNumber}:");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == _taskNumber)
                {
                    _task = null;
                    Console.WriteLine("Task removed successfully.");
                }
                else
                {
                    Console.WriteLine("Invalid task number. No task removed.");
                }
            
        }

        public void MarkTaskAsCompleted()
        {
                Console.WriteLine($"Enter the task number: {_taskNumber}):");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput == _taskNumber)
                {
                    _task.MarkAsCompleted();
                    Console.WriteLine("You don finish am.");
                }
                else
                {
                    Console.WriteLine("Rubish number.");
                }
          
        }

        public void DisplayTasks()
        {
            if (_task != null)
            {
                Console.WriteLine($"Task Name: {_task.Name}");
                Console.WriteLine($"Description: {_task.Description}");
                Console.WriteLine($"Due Date: {_task.DueDate}");
                Console.WriteLine($"Completed: {_task.Completed}");
            }
            else
            {
                Console.WriteLine("Nothing dey here akanbi.");
            }
        }
    }
}
