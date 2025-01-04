using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Overriding
{
    internal class TypeA
    {
        public int A {get; set; }

        public void Fun01()
        {
            Console.WriteLine("Fun01 From TypeA");
        }

        public virtual void Fun02()
        {
            Console.WriteLine($"A: {A}");
        }
    }
}
