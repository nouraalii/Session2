using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int X, int Y , int Z) : base (X,Y)
        {
            this.Z = Z;
        }

        //Override , Hide

        public void fun01()
        {
            Console.WriteLine("I am the Child");
        }
        public void fun02()
        {
            Console.WriteLine($"X: {X} , Y:{Y} , Z:{Z}");
        }

        public override string ToString()
        {
            return $"X: {X} , Y:{Y} , Z:{Z}";
        }
    }
}
