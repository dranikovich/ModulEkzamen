using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModulEkzamen.Classes
{
    class Pricer
    {
        public static string Price1(int x, int c)
        {
            int b = x + c;
            return Convert.ToString(b);
        }
        public static string Price2(int x, int c)
        {
            int b = x + c;
            return Convert.ToString(b);
        }
        public static string Discount(int x, int v)
        {
            int j = 0;
            int b = x%500;
            if(v> 3)
            {
               j = 5;
            }
            else if (v > 5)
            {
                j = 10;
            }
            else if (v > 10)
            {
                j = 15;
            }
            return Convert.ToString(b + j) + "%";
        }
    }
}
