using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccessSpecifier
{
    public class BaseClass
    {
        public int PUBLIC;
        private int PRIVATE;
        private int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int  PRIVATE_PROTECTED;

    }
    public class DerivedClass :TestAccessSpecifier.   BaseClass
    {
    void Donothing()
        {
              
        }
    }

}
