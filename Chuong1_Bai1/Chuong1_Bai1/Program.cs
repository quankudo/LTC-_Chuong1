using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int TinhTong(int n_332)
        {
            int sum_332 = 0;
            for (int i_332 = 1; i_332 <= n_332; i_332++)
            {
                sum_332 += i_332;
            }
            return sum_332;
        }
    }
}
