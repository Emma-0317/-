using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶判斷02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("2.(奇偶判斷)輸入一串有逗號的數字序列");
            string[] input2= Console.ReadLine().Split(',');
            var odd = input2.Where(x => int.Parse(x) % 2 != 0);
            var even = input2.Where(x => int.Parse(x) % 2 == 0);
            Console.WriteLine($"奇數: {string.Join(", ", odd)}");
            Console.WriteLine($"偶數: {string.Join(", ", even)}");

        }
    }
}
