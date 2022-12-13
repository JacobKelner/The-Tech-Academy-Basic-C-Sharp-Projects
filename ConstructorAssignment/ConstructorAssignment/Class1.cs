using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class mySampleClass
    {
        public int _Age;//property/field called Age
        public string _Name;//property/field called Name

        public mySampleClass(): this(15, "Picasso")//no parameter constructor method 
        {

        }
        
        public mySampleClass(int Age, string Name)//constructor with parameters
        {
            this._Age = Age;
            this._Name = Name;
        }


    }
}
