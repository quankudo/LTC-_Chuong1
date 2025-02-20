using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_332 = int.Parse(Console.ReadLine());

            int minDigit_332 = TimChuSoNhoNhat(n_332);
            Console.WriteLine($"Chữ số nhỏ nhất của {n_332} là: {minDigit_332}");
            Console.ReadKey();
        }

        public static int TimChuSoNhoNhat(int n_332)
        {
            int minDigit_332 = 9; 
            while (n_332 > 0)
            {
                int digit_332 = n_332 % 10;
                if (digit_332 < minDigit_332)
                {
                    minDigit_332 = digit_332; 
                }
                n_332 /= 10;
            }
            return minDigit_332;
        }
    }
}
