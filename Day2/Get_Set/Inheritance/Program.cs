using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass o = new DerivedClass();
            //o.i 
        }
    }
    public class BaseClass
    {
        public int i;

    }
    public class DerivedClass:BaseClass
    {
        public int j;
    }
}
