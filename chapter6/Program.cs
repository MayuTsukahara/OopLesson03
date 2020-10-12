using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;

namespace chapter6 {
    class Program {
        static void Main(string[] args) {
            #region 教科書
            ////整数の例
            //var numbers = new List<int> { 19, 17, 15, 24, 12, 25, 14, 20, 12, 28, 19, 30, 24 };
            //numbers.Select(n => n.ToString("0000")).Distinct().ToList().ForEach(n=>Console.Write( n +" "));
            //Console.WriteLine();

            //var sortedNumbers = numbers.OrderBy(n=> n).Distinct();
            //foreach (var number in sortedNumbers) {
            //    Console.Write(number + " ");
            //}

            //Console.WriteLine();

            ////文字列
            //var words = new List<string> {"Microsoft", "Apple", "Google", "Oracle", "Facebook",  };
            ////リストから新たなリストを作成の例
            //var lower = words.Select(name => name.ToLower()).ToArray();

            ////オブジェクトの例
            //var books = Books.GetBooks();

            ////タイトルリスト
            //var titles = books.Select(t => t.Title);
            //foreach (var title in titles) {
            //    Console.Write(title + " ");
            //}

            //Console.WriteLine();

            //books.OrderByDescending(p => p.Pages ).ToList().ForEach(p=>Console.Write(p.Title+" "+p.Pages+" /"));
            #endregion

            #region 演習６-１
            var numbers = new int[] {5,10,17,9,3,21,10,40,21,3,35 };
            
            //6.1.1
            Console.WriteLine("最大値は"+numbers.Max(n => n));

            //6.1.2
            for (int i = numbers.Length-1; i > numbers.Length -3 ; i--) {
                Console.Write(numbers[i]+ " ");
            }
            Console.WriteLine();
            var q = numbers.Length - 2;
            var nu = numbers.Skip(q).Take(2);
            foreach (var item in nu) {
                Console.Write(item + "/ ");
            }
            Console.WriteLine();

            //6.1.3
            numbers.ToList().ForEach(n=> Console.Write(n.ToString()+" "));
            Console.WriteLine();

            //6.1.4
            numbers.OrderBy(n => n).Take(3).ToList().ForEach(n=>Console.Write(n+" "));
            Console.WriteLine();

            //6.1.5
            Console.WriteLine(numbers.Distinct().Count(n => n > 10).ToString());



            #endregion

            #region 演習６‐２
            var books = new List<Book> {
            new Book { Title = "C#プログラミングの新常識", Price = 3800, Pages = 378 },
            new Book { Title = "ラムダ式とLINQの極意", Price = 2500, Pages = 312 },
            new Book { Title = "ワンダフル・C#ライフ", Price = 2900, Pages = 385 },
            new Book { Title = "一人で学ぶ並列処理プログラミング", Price = 4800, Pages = 464 },
            new Book { Title = "フレーズで覚えるC#入門", Price = 5300, Pages = 604 },
            new Book { Title = "私でも分かったASP.NET MVC", Price = 3200, Pages = 453 },
            new Book { Title = "楽しいC#プログラミング教室", Price = 2540, Pages = 348 },
            };

            //6.2.1
            books.Where(b => b.Title == "ワンダフル・C#ライフ").ToList().ForEach(b=>Console.Write(b.Price +"円　"+ b.Pages+"ページ"));
            Console.WriteLine();

            //6.2.2
            Console.WriteLine("C#を含む本は"+books.Where(b => b.Title.Contains("C#")).Count()+"冊");

            //6.2.3
            Console.WriteLine("C#を含む本の平均ページ数は"+books.Where(b => b.Title.Contains("C#")).Average(b => b.Pages));

            //6.2.4
            Console.WriteLine(books.Where(b => b.Price > 4000).FirstOrDefault().Title);

            //6.2.5
            Console.WriteLine(books.Where(b=>b.Pages<4000).Max(b=>b.Pages));

            //6.2.6
            books.Where(b => b.Pages >= 400).OrderByDescending(b => b.Price).ToList().ForEach(b=>Console.Write(b.Title + " "));
            Console.WriteLine();

            //6.2.7
            books.Where(b => b.Title.Contains("C#") && b.Pages < 500).ToList().ForEach(b => Console.Write(b.Title+" "));
            Console.WriteLine();



            int count = 0;
            foreach (var book in books.Where(b=>b.Title.Contains("C#"))) {
                for (int i = 0; i < book.Title.Length-1; i++) {
                    if (book.Title[i] == 'C' && book.Title[i + 1] == '#') {
                        count++;
                    }
                }
            }
            Console.WriteLine($"[C#]の数は{count}");

            #endregion
        }
    }
}
