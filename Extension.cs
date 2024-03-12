using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Extension
{
    public static class Extension
    {
       public static int Faktorial(this int x)
        {
            int ia = 1;
            for (int i = 1; i < x; i++)
            {
                ia=ia*i;

            }
            return ia;
        }
    }
}
