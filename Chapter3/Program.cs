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
            #region 演習3-1
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
            Console.WriteLine();Console.WriteLine();
            //先生の書き方↓
            //numbers.Select(x=> x*2).ToList().ForEach(Console.WriteLine);
            #endregion

            #region 演習3-2
            var names = new List<String>{
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };

            string search = Console.ReadLine();
            var Snum = names.FindIndex(s=> s == search);
            Console.WriteLine(Snum == null ? -1 : Snum);
            Console.WriteLine();

            do{
                var line = Console.ReadLine();
                if(string.IsNullOrEmpty(line)){
                    break;
                }
                var index = names.FindIndex(s=> s==line);
                Console.WriteLine(index);
            }while(true);
           

            Console.WriteLine(names.Count(s=> s.Contains('o')));
            Console.WriteLine();

            var list2 = names.Where(s=>s.Contains('o')).ToList();
            list2.ForEach(s=> Console.WriteLine(s));
            Console.WriteLine();

            var list3 = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var item in list3){
                Console.WriteLine(item);
	        }

            #endregion

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
