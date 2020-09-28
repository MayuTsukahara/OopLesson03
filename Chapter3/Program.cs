using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chapter3 {
    class Program {
        //デリゲートの宣言（int型の引数を受け取ってboolを値を返すメソッド）
        public delegate bool Judgement(int value);
        static void Main(string[] args) {

            var numbers = new List<int> {
                12,87,94,14,53,20,40,35,76,91,31,17,48
            };

            //★3.1 練習問題

            
            var query = numbers.Exists(s=> s%8 == 0 || s%9 == 0);
            Console.WriteLine(query);
            Console.WriteLine();
            


            numbers.ForEach(s=> Console.WriteLine(s/2.0));
            
            Console.WriteLine();
            

            var query3 = numbers.Where(s=> s>=50);
            foreach (var item in query3){
                Console.WriteLine(item);
	        }
            Console.WriteLine();


            var list = numbers.Select(s=> s*2).ToList();
            foreach (var item in list){
                Console.WriteLine(item);
	        }

            //query2.ForEach(s=> Console.WriteLine(s));
	        

            //list.ForEach(s=> Console.WriteLine(s));
            //names.ConvertAll(s=>s.ToUpper()).ForEach(s => Console.WriteLine(s));

            //var query = names.Where(s=> s.Length <=5).ToList();
            //foreach (var s in query){
            //    Console.WriteLine(s);
	        //}
            //Console.WriteLine("--------------");

            //names[0] = "Osaka";
            //foreach (var item in query){
            //    Console.WriteLine(item);
	        //}

            //var name = list.FindAll(s => s.Length <= 5);

            //foreach (var na in name) {
            //    Console.WriteLine(na);
            //}


        

        }
    }
}
