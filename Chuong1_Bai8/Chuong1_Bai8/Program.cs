using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong1_Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số nguyên dương n: ");
            int n_332 = int.Parse(Console.ReadLine());

            int count_332 = DemSoChuSo(n_332);
            Console.WriteLine($"Số lượng chữ số của {n_332} là: {count_332}");
            Console.ReadKey();
        }

        public static int DemSoChuSo(int n_332)
        {
            int count_332 = 0;
            while (n_332 > 0)
            {
                count_332++;
                n_332 /= 10; // Loại bỏ chữ số cuối cùng
            }
            return count_332;
        }
    }
}
