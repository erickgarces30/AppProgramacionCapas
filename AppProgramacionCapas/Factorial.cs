using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProgramacionCapas
{
    public static class Factorial
    {
        public static long fact(int num)
        {
            long f = 1;
            if(num==0 || num==1)
                return f;

            for (int i = 1; i <= num; i++)
                f = f * i;

        }
    }
}
