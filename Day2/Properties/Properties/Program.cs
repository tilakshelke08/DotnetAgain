using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Program
    {
       /*    static void Main(string[] args)
        {
            Program p;
            p = new Program();
            p.display();
        }
        public void display()
        {
            Console.WriteLine("IACSD PUNE ");
            Console.ReadLine();
        }    
       */
    

        static void Main(string[] args)
        {
            //  for class1
            class1 t;
            t = new class1();
            //   t.i();
            //   Console.WriteLine(x); // wrong type to write 
            t.Setx(120);
            Console.WriteLine(t.Getx());

            // for class2
            class2 m;
            m = new class2();
            m.Sety(80);
            Console.WriteLine(m.Gety());
            Console.ReadLine();

        }
    }
    public class class1
    {
       
        private int x;
        public void Setx(int value )
        {
            if(value < 100)
            {
                x = value;
            }
            else
            {
                //exceptions
                Console.WriteLine("you  havee raised exceptions");
            }
        }
        public int Getx()
        {
            Console.WriteLine("get method  class1");

            return x;
        }
    }

    public class class2
    {
        private int y;

        public void Sety(int value) {
        if(value < 100)
            {
                y = value;
                Console.WriteLine(" set method class 2");
            }
            else
            {
                //exceptions
                Console.WriteLine("you entered wrong choice ");
            }
        }
        public int Gety()
        {
            Console.WriteLine("get y method");
            return y;
        }
    }
}
