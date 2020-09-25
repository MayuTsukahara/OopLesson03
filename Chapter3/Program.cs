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

            var names = new List<string> {
                "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","Hong Kong",
            };


            //list.ForEach(s=> Console.WriteLine(s));
            //names.ConvertAll(s=>s.ToUpper()).ForEach(s => Console.WriteLine(s));

            var query = names.Where(s=> s.Length <=5).ToList();
            foreach (var s in query){
                Console.WriteLine(s);
	        }
            Console.WriteLine("--------------");

            names[0] = "Osaka";
            foreach (var item in query){
                Console.WriteLine(item);
	        }

            //var name = list.FindAll(s => s.Length <= 5);

            //foreach (var na in name) {
            //    Console.WriteLine(na);
            //}


        

        }
    }
}
