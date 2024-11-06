using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lb
{
    internal class Amebs
    {
        public int CountTime(int am)
        {
            int i = 0;
            while (am > 1) 
            {
                am /= 2;
                i++;
            }
            return 60 - i;
        }
    }
}
