using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_332 = int.Parse(Console.ReadLine());

            int sum_332 = TinhTongUocSo(n_332);
            Console.WriteLine($"Tổng các ước số của {n_332} là: {sum_332}");
            Console.ReadKey();
        }

        public static int TinhTongUocSo(int n_332)
        {
            int sum_332 = 0;
            for (int i_332 = 1; i_332 <= n_332; i_332++)
            {
                if (n_332 % i_332 == 0) // Kiểm tra nếu i_332 là ước số của n_332
                {
                    sum_332 += i_332;
                }
            }
            return sum_332;
        }
    }
}
