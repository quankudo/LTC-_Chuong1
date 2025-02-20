using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương a: ");
            int a_332 = int.Parse(Console.ReadLine());

            Console.Write("Nhập số nguyên dương b: ");
            int b_332 = int.Parse(Console.ReadLine());

            int ucln_332 = TimUCLN(a_332, b_332);
            Console.WriteLine($"Ước chung lớn nhất của {a_332} và {b_332} là: {ucln_332}");
            Console.ReadKey();
        }

        public static int TimUCLN(int a_332, int b_332)
        {
            while (b_332 != 0)
            {
                int temp_332 = b_332;
                b_332 = a_332 % b_332;
                a_332 = temp_332;
            }
            return a_332;
        }
    }
}
