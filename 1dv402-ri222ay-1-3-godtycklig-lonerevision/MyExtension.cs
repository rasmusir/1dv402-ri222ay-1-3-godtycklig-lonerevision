using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402_ri222ay_1_3_godtycklig_lonerevision
{
    static class MyExtension
    {
        public static int Dispersion(int[] source)
        {
            int[] values = source.OrderBy(i => i).ToArray();
            int smallest = values[0];
            int biggest = values[values.Length - 1];
            return biggest - smallest;
        }

        public static int Median(int[] source)
        {
            int[] values = source.OrderBy(i => i).ToArray();

            if (values.Length % 2 == 1)
            {
                return values[values.Length / 2];
            }
            else
            {
                return (values[values.Length / 2] + values[values.Length / 2 + 1])/2;
            }
        }
    }
}
