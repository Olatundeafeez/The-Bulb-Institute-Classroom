using ExProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace ExProject.Actions
{
    public static class Menu
    {
        
      
        
    
        public static int StartupMenu()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Welcome to Akanbi's fake government\n\n\n");
            Console.WriteLine("-------------------------------------------------------------------------------");
            
            Console.WriteLine("Menu\n\n1) Add task\n2) Delete task\n3) Mark Task as completed\n4) Display task\n8) Exit the application\n\n");
            
            var choice = int.Parse(Console.ReadLine());
           

            
            return choice;
        }


      


        public static void SelectChoice(int choice)
        {
            TodoItems items = new TodoItems();
            
            switch (choice)
            {
                case 1:
                Console.WriteLine("You have chosen to add task");
               items.AddTask();
                break;
                case 2:
                Console.WriteLine("You have chosen to delete task");
                items.RemoveTask(); 
                break;
                case 3:
                items.MarkTaskAsCompleted();
                break;
                case 4:
                items.DisplayTasks();
                break;
               
                case 8:                
                Console.WriteLine("bye bye oooooo...");
                break;
                default:
                Console.WriteLine("Invalid choice. Please try again.");        
                break;

            }
            
        }

        public static void ReturnToMenuOrExit()
        {
            Console.WriteLine("Would you like to do something else ");
            Console.WriteLine("Enter 5 to go back to the main menu\n\n");
            var choice = int.Parse(Console.ReadLine());
            if(choice == 5)
            {
                StartupMenu();
            }
            else
            {
                Console.WriteLine("No be wetin i send you to press be that dawg");
            }
        }

        
    }
}
