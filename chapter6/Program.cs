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
            numbers.Take(2).ToList().ForEach(n=>Console.Write(n+" "));
            Console.WriteLine();

            //6.1.3
            numbers.ToList().ForEach(n=> Console.Write(n.ToString()+" "));
            Console.WriteLine();

            //6.1.4
            numbers.OrderBy(n => n).Take(3).ToList().ForEach(n=>Console.Write(n+" "));
            Console.WriteLine();

            #endregion
        }
    }
}
