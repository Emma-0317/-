using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 序列倒置

{
    internal class Program
    {
        class MyData
        {
            public int Id
            { get; set; }
        }

        static void Main(string[] args)
        {
            var list = CreateList();
            var order1 = list.OrderByDescending((x) => x.Id);
            Display(order1);
            Console.ReadLine();
        }

        static void Display(IOrderedEnumerable<MyData>souce)
        {
            foreach (var item in souce)
            {
                Console.Write(item.Id + ",");
            }
        }
        static List<MyData> CreateList()
        {
            return new List<MyData>()
            {
                new MyData { Id = 12},
                new MyData { Id = 13},
                new MyData { Id = 18},
                new MyData { Id = 32},
                new MyData { Id = 23},
            };
        }
    }
}
