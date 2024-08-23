using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOrObectInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            class1 w;
            w = new class1();
            w.I = 110; //set
            Console.WriteLine(w.I); //get
            Console.ReadLine();

        }
    }

    public class class1
    {
        private int i;
        public int I
        {
            set
            {
                if (value < 100)
                {
                    i = value;
                }
                else
                {
                    Console.WriteLine("you have entered wrong choice ");
                }
            }
            get
            {
                return i;
            }

            //automatic get set
           /**//*  public int P4
         {
             set;get;
         }*/
     }


}

