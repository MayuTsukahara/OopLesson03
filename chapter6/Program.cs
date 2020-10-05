using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6 {
    class Program {
        static void Main(string[] args) {
            //var numbers = Enumerable.Repeat("(unknown)", 20).ToList();

            var numbers = new List<int> { 9,7,-5,4,2,5,4,2,-4,8,-1,4};
            Console.WriteLine($"平均値：{numbers.Average()}");
            Console.WriteLine($"合計　：{numbers.Sum()}");
            Console.WriteLine($"最小値：{numbers.Where(x=>x>=0).Min()}");
            Console.WriteLine($"最大値　：{numbers.Max()}");


            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{books.Average(p => p.Price)}");
            Console.WriteLine($"本の合計価格：{books.Sum(p => p.Price)}");
            Console.WriteLine($"ページ数の最大値：{books.Max(p=>p.Pages)}");
            Console.WriteLine($"高価な本：{books.Max(p => p.Price)}");
        }
    }
}
