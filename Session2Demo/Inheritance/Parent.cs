using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Inheritance
{
    internal class Parent
    {
        public int X {  get; set; }
        public int Y { get; set; }

        public void fun01()
        {
            Console.WriteLine("I am the parent");
        }
        public void fun02()
        {
            Console.WriteLine($"X: {X} , Y:{Y}");
        }
        //public Parent()
        //{

        //}

        public Parent(int X , int Y) {
            this.X = X;
            this.Y = Y;
        }

        public override string ToString()
        {
            return $"X : {X} , Y : {Y}";
        }
    }
}
