using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example_2
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            DerivedClass o = new DerivedClass();
           //overloading
            o.Display1();
            o.Display1(100);

            //hiding the method
            o.Display2();

            //override the method
            o.Display3();
            Console.ReadLine();      
        }
        static void Main(string[] args)
        {
            // Late binding 
            BaseClass o = new BaseClass();
            o.Display2(); //non-virtual ,early binding 
            o.Display3(); // virtual , late binding 

            Console.WriteLine("****************");

             o = new DerivedClass();
            o.Display2(); //non-virtual ,early binding 
           o.Display3(); // virtual , late binding 


            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public void Display1() {
            Console.WriteLine(" Base no para display1");
        }
        public void Display2()
        {
            Console.WriteLine(" Base para display2");

        }
        //override virtual method 
        //virtual keyword compulsory
        public virtual void Display3()
        {
            Console.WriteLine(" Base para display3");

        }

    }
    public class DerivedClass:BaseClass {
        //overloading... same method diff parameter 
        public void Display1(int i) {
            Console.WriteLine(" derived para display1");
        }
       /* hiding ..the baseclass method by
        derivedclass method  in derived class*/
        // same name same parameters
        public void Display2()
        {
            Console.WriteLine(" derievd  para display2");

        }
        /*override...the baseclass method by 
        DerivedClass method  in derived class*/
        public  override void Display3()
        {
            Console.WriteLine(" derievd  para display3");

        }

    }
}
