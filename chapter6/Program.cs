using Chapter06;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter6 {
    class Program {
        static void Main(string[] args) {
            //整数の例
            var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };
            numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(n=>Console.Write( n +" "));
            Console.WriteLine();

            var sortedNumbers = numbers.OrderBy(n=> n).Distinct();
            foreach (var number in sortedNumbers) {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            //文字列
            var words = new List<string> {"Microsoft", "Apple", "Google", "Oracle", "Facebook",  };
            //リストから新たなリストを作成の例
            var lower = words.Select(name => name.ToLower()).ToArray();

            //オブジェクトの例
            var books = Books.GetBooks();

            //タイトルリスト
            var titles = books.Select(t => t.Title);
            foreach (var title in titles) {
                Console.Write(title + " ");
            }

            Console.WriteLine();

            books.OrderByDescending(p => p.Pages ).ToList().ForEach(p=>Console.Write(p.Title+" "+p.Pages+" /"));
            
        }
    }
}
