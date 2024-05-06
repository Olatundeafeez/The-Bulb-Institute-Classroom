using ExProject.Actions;
using ExProject.Models;
using System;
using System.Threading;

namespace ExProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true){

            Console.WriteLine("Hello World!");
            var choice =Menu.StartupMenu();

            Menu.SelectChoice(choice);
            Console.Clear();
            }

        }
    }
}
