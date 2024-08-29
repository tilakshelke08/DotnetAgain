using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*you can"t instantionated abstract class */
            // abstractclass obj1 = new abstractclass();

            Derivedclass obj1 = new Derivedclass();
            obj1 = new Derivedclass();
            Console.ReadLine();
        }
    }

    public abstract class abstractclass {
    
        // no abstaarct method 
        public void Display()
        {
            Console.WriteLine("displlay");
        }
    }
    // abstarct class inheritence 
    public  class Derivedclass : abstractclass
    {

        public void Show()
        {
            Console.WriteLine("show ");
        }
    }

    public abstract class abstractclass2
    {
        // abstarct is pure virtual function 
        public abstract void Display();
        public abstract void Show();

    }

    /*In below  code you write down abstract keyword
        i.e the abstarct class contain abstract method 
        they abstarct class dont need any method they 
        just looking for abstarct method . & they found 
            abstarct method i.why they dissmisseed the error 
            without mentioning the all method .*/
    public abstract class class2 : abstractclass2
    {


        /*In .Net virtual function is handled by 
         which word i.e " overriide "  */
        public override void Display()
        {
            Console.WriteLine("display");
        }

       /* public override void Show()
        {
            Console.WriteLine("show");
        } */
    }


}
