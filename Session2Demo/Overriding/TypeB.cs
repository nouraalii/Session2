using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2Demo.Overriding
{
    internal class TypeB : TypeA 
    {
        public int B { get; set; }

        //override or hide
        //Apply Override
        //1.Apply override using 'new' keyword
        //2.Apply overridr using 'override' keyword

        //Static Binding 
        //Compiler will bind Function call Based on Reference Type not The Object Type
        //At compilation Time


        public new void Fun01() //using 'new' keyword
        {
            Console.WriteLine("Fun01 From TypeB");
        }

        ////Must be not private and virtual
        //public override void Fun02() //using 'override' keyword
        //{
        //    Console.WriteLine($"B: {B}");
        //}

        //Dynamic Binding
        //CLR will bind based on object type not the reference type
        //Runtime 
        public override void Fun02() //using 'override' keyword
        {
            Console.WriteLine($"B: {B}");
        }
    }
}
