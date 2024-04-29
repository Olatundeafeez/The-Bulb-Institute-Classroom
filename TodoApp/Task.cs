using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class Task
    {
        private string _name;
        private string _description;
        private DateTime _dueDate;
        private bool _completed;

        public Task(string name, string description, DateTime dueDate, bool completed)
        {
            _name = name;
            _description = description;
            _dueDate = dueDate;
            _completed = completed;
        }

        public string Name { get { return _name; } }
        public string Description { get { return _description; } }

        public DateTime DateTime { get { return _dueDate; }  }
        }
       
    }
}
