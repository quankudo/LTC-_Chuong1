using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_332 = int.Parse(Console.ReadLine());

            int sum_332 = TinhTongChuSo(n_332);
            Console.WriteLine($"Tổng các chữ số của {n_332} là: {sum_332}");
            Console.ReadKey();
        }

        public static int TinhTongChuSo(int n_332)
        {
            int sum_332 = 0;
            while (n_332 > 0)
            {
                sum_332 += n_332 % 10; 
                n_332 /= 10; 
            }
            return sum_332;
        }
    }
}
