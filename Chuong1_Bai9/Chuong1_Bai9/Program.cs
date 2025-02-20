using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương N: ");
            int n_332 = int.Parse(Console.ReadLine());

            int sumOdd_332 = TinhTongLe(n_332);
            Console.WriteLine($"Tổng các số lẻ nguyên dương nhỏ hơn {n_332} là: {sumOdd_332}");
            Console.ReadKey();
        }

        public static int TinhTongLe(int n_332)
        {
            int sum_332 = 0;
            for (int i_332 = 1; i_332 < n_332; i_332 += 2) // Duyệt qua các số lẻ
            {
                sum_332 += i_332;
            }
            return sum_332;
        }
    }
}
