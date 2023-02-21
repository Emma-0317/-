using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 序列倒置02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.(序列反轉)輸入一串帶有逗號的數字序列 :");
            string[] input = Console.ReadLine().Split(',');
            var result = input.Reverse();
            Console.WriteLine(string.Join(",", result));
            Console.WriteLine("\n");
        }
    }
}
