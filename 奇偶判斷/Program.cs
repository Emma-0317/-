using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 奇偶判斷
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> number = new List<int>() { 5, 2, 1, 32, 8 };
            var answer = number.Where(x => x % 2 == 0); 
            //Console.WriteLine("偶數 : " + (answer +",")  );
            var answer1 = number.Where(x => x % 2 != 0);
            //Console.WriteLine("奇數 : " + (answer1 +",") );
            //foreach (var x in number)
            //{
                Console.WriteLine($"偶數: {string.Join(", ", answer)}");
                Console.WriteLine($"奇數: {string.Join(", ", answer1)}");
            //}
        }
    }
}
