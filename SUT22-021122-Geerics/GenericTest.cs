using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_021122_Geerics
{
    class GenericTest<T>
    {
        public bool Compare(T val1, T val2)
        {

            if (val1.Equals(val2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
