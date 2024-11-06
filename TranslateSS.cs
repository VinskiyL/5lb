using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lb
{
    internal class TranslateSS
    {
        public string Translate(double num, int ss, int prec)
        {
            string binary1 = "";
            int d = (int)num;
            while(d > 0)
            {
                binary1 = (d % ss).ToString() + binary1;
                d /= ss;
            }
            double k = num - (int)num;
            if (k == 0)
            {
                return binary1;
            }
            string binary2 = "";
            while(binary2.Length < prec)
            {
                binary2 += ((int)(k * ss)).ToString();
                k = k * ss - (int)(k * ss);
            }
            return binary1 + "," + binary2;
        }
    }
}
