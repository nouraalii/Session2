using System.Reflection;
using System.Security.AccessControl;
using Session2Demo.Binding;
using Session2Demo.Inheritance;
using Session2Demo.Overriding;

namespace Session2Demo
{
    internal class Program
    {

        #region Polymarphism
        static int sum(int X, int Y)
        {
            return X + Y;
        }

        static double sum(double X, double Y)
        {
            return X + Y;
        }

        static int sum(int X, int Y, int Z)
        {
            return X + Y + Z;
        }

        static double sum(double X, int Y)
        {
            return X + Y;
        }

        static double sum(int X, double Y)
        {
            return X + Y;
        }
        #endregion


        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.Fun01();
        //        employee.Fun02();
        //    }
        //}

        static void EmployeeProcess(Employee employee)
        {
            if (employee is not null)
            {
                employee.Fun01();
                employee.Fun02();
            }
        }


        static void Main(string[] args)
        {
            #region Class VS Struct
            //Class VS Struct 
            #endregion

            #region Inheritance
            ////2.Inheritance : 
            ////X --> Y
            ////DRY

            //Parent parent = new Parent(1,2);
            //Console.WriteLine(parent);

            //parent.fun01();
            //parent.fun02();


            //Child child = new Child(1, 2, 3);
            //child.fun01();
            //child.fun02(); 
            #endregion

            #region Relationships between Classes
            //Relationships between Classes
            //1.Inheritance:is a relationship
            //FullTimeEmployee ----> Employee
            //FullTimeEmployee is a  Employee
            //Child ----> Parent
            //Child is a parent 

            //Child child = new  Child (1,2,3);

            //2.Association : has  a Relationship
            //Book has a Author
            //Library Has A books

            //2.1 composition : has a relationship
            //2.2 aggregation : has a relationship

            //Author author = new Author();

            //Book book = new Book(author); 
            #endregion


            #region Polymarphism overview
            //3.Polymarphism
            //3.1overloading
            //3.2overriding 
            #endregion

            #region Polymarphism Methods(Fumctions)Overloading
            //3.1Polymarphism Methods(Fumctions)Overloading 
            //there are more than one  function(in the same scope [class - struct])
            //these have the same Name but with different signature
            //(coount - type  - order)parameter

            //sum(1, 2);
            //sum(1.3, 2.4);

            //sum(1.3, 3.4); 
            #endregion


            #region Polymarphism Methids(Functions)overriding
            ////3.2.Polymarphism Methids(Functions)overriding
            ////there are more than one functions [in diffrenent classes] these have the same name and
            ////the same signature but with behaviour

            //TypeB typeB = new TypeB() {A=12 ,B=13 }; //Property Initializer

            ////typeB.A = 12;
            ////typeB.B = 13;

            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.Fun01();
            //typeB.Fun02(); 
            #endregion

            //Binding
            #region What is Binding
            ////What is Binding

            ////Refernece from parent -> ObjectChild 

            //TypeA Ref;

            //Ref = new TypeA();
            ////Ref = new TypeB();

            ////Child is a parent

            ////TypeB is a TypeA

            //Ref = new TypeB();
            //Ref.A = 12;
            ////Ref.B = 13;

            //Ref.Fun01();//Static Binded Method
            //Ref.Fun02(); 
            #endregion

            #region Not Binding
            //Not Binding
            //Reference ---->ObjectChild

            //TypeA Ref = new TypeA();

            //Ref = new TypeB();//Binding

            //TypeB Ref = new TypeB();

            //Ref = new TypeA(); 

            //Child is A Parent

            //Animal --> Dog : Dog is  an animal 
            //Dog --> (Dog)Animal : Animal is a dog 

            //TypeA Ref = new TypeA();
            ////Ref = new TypeB();

            //TypeB typeB = (TypeB) Ref; //Not Binding 
            #endregion


            #region When U need Binding
            //When U need Binding??

            //FullTimeEmployee:Id , Name , Address , Email , Salary

            //FullTimeEmployee fullTime = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Noura",
            //    Address = "Giza",
            //    Email = "N@g.c",
            //    Salary = 20000
            //};

            ////PartTimeEmployee:Id , Name , Address , Email , HoursRate , NumberOfHours
            //PartTimeEmployee partTime = new PartTimeEmployee()
            //{
            //    Id = 1,
            //    Name="Noura",
            //    Address="Alex",
            //    Email="N@g.c",
            //    HourRate=300,
            //    NumberOfHours=200
            //};


            //EmployeeProcess(partTime);
            //NullReferenceException 
            #endregion

            #region BindingExample
            //TypeA typeA;

            //typeA = new TypeA();
            //typeA = new TypeB();//TypeA is a parent of TypeB
            //typeA = new TypeC();//TypeA is a parent of TypeC
            //typeA = new TypeD();//TypeA is a parent of TypeD

            //typeA.A = 12;
            ////typeA.B = 12;
            ////typeA.C = 12;
            ////typeA.D = 12;

            //typeA.Fun01();
            //typeA.Fun02(); 
            #endregion


            #region Task2
            //Task02 :
            //1.protected

            //Dog dog = new Dog();
            //dog.setName("Dog");
            //dog.Display();

            //Same Class: Accessible because it’s part of the class (like private).
            //Same Assembly, Non-Derived Class: Not accessible because protected allows access only to derived classes.
            //Same Assembly, Derived Class: Accessible because protected allows access in derived classes within the same assembly.
            //Different Assembly: Accessible only in derived classes within a different assembly, as protected allows access to derived classes across assemblies.
            //=================================================

            //2.internal protected
            //Same Class: Always accessible because the member belongs to the class itself.
            //Same Assembly, Non-Derived Class: Accessible because the internal part allows access within the same assembly, even for non-derived classes.
            //Same Assembly, Derived Class: Accessible because of both internal (same assembly) and protected (inheritance).
            //Different Assembly, Non-Derived Class: Not accessible because internal limits access to the same assembly.
            //Different Assembly, Derived Class: Accessible because of the protected part, which allows access in derived classes regardless of assembly

            //===================================================

            //3.Private protected
            //Same Class: Accessible because it’s part of the class.
            //Same Assembly, Non-Derived Class: Not accessible because private protected restricts access to derived classes only.
            //Same Assembly, Derived Class: Accessible because it’s derived within the same assembly.
            //Different Assembly: Not accessible, even if it’s a derived class, because private protected limits access to the same assembly. 
            #endregion

        }
    }
}
