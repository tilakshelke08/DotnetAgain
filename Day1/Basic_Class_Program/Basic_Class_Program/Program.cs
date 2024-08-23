// using System;
using Basic_Class_Program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Class_Program
{
    internal class Program
    {
        
       
        static void Main1(string[] args)
        {

            System.Console.WriteLine("done");


        }
        public int add(int n, int m)
        {
            return n + m;
        }
        public int add1(int v, int w, int x, int y, int z)
        {
            return v + w + x + y + z;
        }
    }
}
namespace Senior
{
    class junior
    {
       

        static void Main(string[] args)
        {
            int total;
            Program  e;
            e = new Program();

            total = e.add1(2, 3, 4, 5, 1);

            Console.WriteLine("the total is :- " + total);
            

            int result;
           
            result = e.add(1, 2);
            System.Console.WriteLine("result:" + result);
            System.Console.ReadLine();

        }

    }
}
