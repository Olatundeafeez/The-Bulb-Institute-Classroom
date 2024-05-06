using ExProject.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExProject.Models
{
    public class TaskItem
    {
        //Fields
        private string _name;
        private string _description;
        private DateTime _dueDate;
        private bool _completed;
      public TaskItem()
        {

        }

        //constructor
        public TaskItem(string name, string description, DateTime dueDate)
        {
            _name = name;
            _description = description;
            _dueDate = dueDate;
            _completed = false;
               
        }

        //Properties
        public string Name { get { return _name; } } 
        public string Description { get { return _description; } }
        public DateTime DueDate { get {return _dueDate; } }
        public bool Completed { get { return _completed; }  }


        public void MarkAsCompleted()
        {
            _completed = true;
        }

    }
}
