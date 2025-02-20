using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void LietKeUocSo(int n_332)
        {
            for (int i_332 = 1; i_332 <= n_332; i_332++)
            {
                if (n_332 % i_332 == 0) // Kiểm tra nếu i_332 là ước số của n_332
                {
                    Console.Write(i_332 + " ");
                }
            }
        }
    }
}
