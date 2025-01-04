using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo
{
    class Animal 
    {
        protected string Name;
        
        public void setName(string name)
        {
            Name = name;
        }
    }

    class Dog : Animal 
    {
        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
}
