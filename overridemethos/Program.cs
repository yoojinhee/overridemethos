using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        
        int Power(int input)
        {
            return input * input;
        }
        int Power(int input, int count)
        {
            double re= Math.Pow(input, count);
            return Convert.ToInt32(re);
        }
        
        int SumAll(int end)
        {
            int total = 0;
            for (int i = 0; i <= end; i++)
            {
                total += i;
            }
            return total;
        }

        int SumAll(int end, int start)
        {
            int total = 0;
            for (int i = start; i <= end; i++)
            {
                total += i;
            }
            return total;
        }
        
        static void Main(string[] args)
        {
        }
    }
}
