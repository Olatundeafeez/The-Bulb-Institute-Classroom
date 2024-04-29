using System;
using System.Collections.Generic;
using System.Text;

namespace SampleClass
{
    //Classes are like blue prints used to create objects
    //structure : Access Modifier, Datatype/Return type, Name of the class
    public class Car
    {

        //  Contructor
        public Car(string name, int price)
        {
            _name = name;
            _price = price;
        }

        //Data Types : Defines the type of a data or resource
        //string
        //decimal
        //int
        //float
        //double
        //object

        //Access modifier: Access mmodifiers help to define protection level of a resource
        //protected
        //protected internal
        //private 
        //internal



        //Properties: Properties have a get and a set
        //Structure: Access Modifier, Datatype/Return type, Name of property, {get; set;}
        public string Name { get { return _name; } }
        public int Price { get; set; }
        public string Color { get; set; }

        //Fields: Are also like properties... but without a get and a set;
        //Structure: Access Modifier, Datatype/Return type, Name of field
        public string _name;
        public string _color;
        public int _price;
        string _age; // This automatically becomes private

        //Methods: A block of code that contains series of statement that does something
        //Structure: Access Modifier, Datatype/Return type , Name of the method


        public string Fish()
        {
            return "I am a baboo..I live in the zoo... Zazoooooooooooooooooooo";
        }

        public int CalculateFootBallAge(int age)
        {
            if(age < 18)
            {
                age += 10;
                return age;
            }
            else
            {
                return age;

            }

        }

        
    }
}
