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

            //ひとつでも見つけたらtrueで終了する
            bool exists = numbers.Any(n=> n%7 ==0);

            var results = numbers.Where(n => n > 0).Take(3);
            results.ToList().ForEach(n=> Console.Write(n+" ")) ;

            Console.WriteLine();
            Console.WriteLine();


            var books = Books.GetBooks();
            Console.WriteLine($"本の平均価格：{books.Average(p => p.Price)}");
            Console.WriteLine($"本の合計価格：{books.Sum(p => p.Price)}");
            Console.WriteLine($"ページ数の最大値：{books.Max(p=>p.Pages)}");
            Console.WriteLine($"高価な本：{books.Max(p => p.Price)}");
            Console.WriteLine($"タイトルに物語がある冊数：{books.Count(x=>x.Title.Contains("物語"))}");

            //600ページを超える書籍があるか？
            Console.WriteLine($"600ページ越えは{books.Any(x => x.Pages > 600)}");
            Console.WriteLine(books.Any(x=> x.Pages>600)? "600ページ越えはある" : "600ページ越えはない");

            //すべてが２００ページ以上の書籍か？
            Console.WriteLine(books.All(x=> x.Pages >200)?"すべて200ページ以上である":"すべて200ページ以上でない");

            //400ページを超える本は何冊目か
            Console.WriteLine($"400ページを超える本は{books.FindIndex(x=>x.Pages>400)+1}冊目");

            var book = books.FirstOrDefault(x=> x.Pages>400);
            var index = books.FindIndex(x=> x==book) + 1;

            int count;
            for ( count = 0; count < books.Count; count++) {
                if (books[count].Title.Contains(book.Title)) break;
            }
            Console.WriteLine($"400ページ超える本は{index}冊目");

            //本の値段が400円以上
            books.Where(p => p.Price >= 400).Take(3).ToList().ForEach(p=>Console.Write(p.Title + " "));
        }
    }
}
