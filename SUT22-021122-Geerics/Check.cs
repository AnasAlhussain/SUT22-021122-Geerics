using System;
using System.Collections.Generic;
using System.Text;

namespace SUT22_021122_Geerics
{
    public class Check
    {

        //public static bool CheckEqualaty(int v1, int v2)
        //{
        //    return v1 == v2;
        //}


        public static bool CheckEqualaty <Undefinde>(Undefinde v1, Undefinde v2)
        {
            return v1.Equals(v2);
        }
    }
}
