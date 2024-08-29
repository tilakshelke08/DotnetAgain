using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass o = new DerivedClass();
            // firstly they called derived class no parameter const. then they go to 
            //base class no parameter .
            // why base claass no parameter .bcoz we could instructed to choose specific one .
            // they choose default  const  i.e no parameter const.

            /* ---------------------------------------------*/
            DerivedClass o2 = new DerivedClass(476, 234);
            // in this case total 4 const done.
            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {

            i = 10;
            Console.WriteLine("Base class no parameters const");
        }
        public BaseClass(int i)
        {
            this.i = i;
            Console.WriteLine("Base class parameter const");
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            /*i = 100;*/ // this value alraedy intialsed in above class so no need to write again 
            // it create duplicate copy 
            j = 10;
            Console.WriteLine("Derived class no parameter const");
        }
        public DerivedClass(int i, int j) : base(i)
        {
            /*this.i = i;*/
            this.j = j;
            Console.WriteLine("Derived class parameter const");
        }
    }
}
