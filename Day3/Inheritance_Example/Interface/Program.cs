using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // by thr used of this you can access all method 
            class2 o = new class2();
            o.Display();

            // 1st way to write method 
            o.insert();
            o.update();
            o.delete();

            // by the used of this you can
            // access only interface methods 

            // 2nd  way to to write method 

            // create the interface reference
            IDFunction Idb;
            // making point towars obj
            Idb = o;
            Idb.insert();
            // No  Display method show

            // 3rd  way to to write method
            ((IDFunction) o).insert();

            // 4th  way to to write method
            (o as IDFunction).insert();


            // for the add() method
            IFileFunction IFile;
           
            IFile = o;
            IFile.add();

            Console.WriteLine();
            Console.ReadLine();

        }
    }
    public interface IDFunction
    {//interface starts with capital "I...." 
     // with any name

        // do not write access specifier in method like 
        // public etc.

        // all interface method have implicitly "public"
        // i.e deafult " public "
       
        // all are abstract method 

       // only with signature
        void insert();
        void update();
        void delete();
    }

    public class class2 : IDFunction , IFileFunction
    {
     // Display method Not the part of  the interface 
        public void Display()
        {
            Console.WriteLine("display");
        }

        // from 1st Ineterface 
        public void delete()
        {
            Console.WriteLine("delete");
        }

        public void insert()
        {
            Console.WriteLine("insert");
        }

        public void update()
        {
            Console.WriteLine("upadte");
        }



        // from 2nd Ineterface 
        /*public void add()
        {
            Console.WriteLine("add");
        }*/

        // this is the another way to write 
        void IFileFunction.add()
        {
            Console.WriteLine("add");
        }
    }

    internal interface IFileFunction
    {
        void add();
    }
}
