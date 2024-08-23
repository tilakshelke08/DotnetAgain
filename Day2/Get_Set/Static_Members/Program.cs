using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Members
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 o1 = new class1();
            o1.i = 100;
            // called method with the help of object 
             o1.Display();
            class1 o2 = new class1();
            o2.i = 200;
            // called static method with the help of object 
            
            class1.static_Display();
            Console.WriteLine(class1.static_i);
            class1.static_i = 2000;  
            
            class1.P2 = 100;
            Console.WriteLine("");
             
            Console.ReadLine();
        }  

    }
    public class class1
    {
        public class1()
        {
            Console.WriteLine("ststic constructor");
            static_i = 1000;
            
        }
        public int i;
        // static variable -why?- single(shared copy for the class
        public static int static_i;

        public void Display()
        {
            Console.WriteLine("Display");
        }

        // static function - can be called directly classname methodname  without creatiing an object 
        public static void static_Display()
        {
            Console.WriteLine("Static Display");
        }

        private static int p2;//make static
        public static int P2 {
            //make static 
            set
            {
                p2 = value;
            }
            get
            {
                return p2;
            }
        }
    }
}
 