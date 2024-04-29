using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    public class User
    {
      //fields 
      private int _id;
      private string _name;
       
      // Constructor
      public User (int id , string name)
        {
            _id = id;
            _name = name;
        }

        //Properties
        public int Id { get { return _id; } }
        public string Name { get { return _name;} }
    }
}
