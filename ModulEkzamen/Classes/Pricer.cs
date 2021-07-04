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
        public static int Discount(int x, int v)
        {
            int j = 0;
            int b = v%500;
            if(x> 3)
            {
               j = 5;
            }
            else if (x > 5)
            {
                j = 10;
            }
            else if (x > 10)
            {
                j = 15;
            }
            return b + j;
        }
    }
}
