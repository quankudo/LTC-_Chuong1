using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_332 = int.Parse(Console.ReadLine());

            if (KiemTraSoNguyenTo(n_332))
            {
                Console.WriteLine($"{n_332} là số nguyên tố.");
            }
            else
            {
                Console.WriteLine($"{n_332} không phải là số nguyên tố.");
            }
            Console.ReadKey();
        }

        public static bool KiemTraSoNguyenTo(int n_332)
        {
            if (n_332 < 2) return false;
            for (int i_332 = 2; i_332 <= Math.Sqrt(n_332); i_332++) 
            {
                if (n_332 % i_332 == 0)
                    return false; 
            }
            return true;
        }
    }
}
