using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Session2Demo.Overriding;

namespace Session2Demo
{

    class TypeA
    {
        public int A { get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeA");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }

        public new void Fun01() 
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        public override void Fun02() 
        {
            Console.WriteLine($"B: {B}");
        }
    }

    class TypeC : TypeB
    {
        public int C { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeC");
        }

        public override void Fun02()
        {
            Console.WriteLine($"C: {C}");
        }
    }

    class TypeD : TypeC
    {
        public int D { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeD");
        }

        public override void Fun02()
        {
            Console.WriteLine($"D: {D}");
        }
    }

    class TypeE : TypeD
    {
        public int E { get; set; }

        public new void Fun01()
        {
            Console.WriteLine("Fun01 From TypeE");
        }

        public override void Fun02()
        {
            Console.WriteLine($"D: {E}");
        }
    }
}
