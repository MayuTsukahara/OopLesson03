using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) 
            
            
            {
            var ymArray = new YearMonth[] {
                new YearMonth(1996,3),
                new YearMonth(2001,1),
                new YearMonth(1999,5),
                new YearMonth(2011,9),
                new YearMonth(2019,4)
            };

            foreach (var ym in ymArray) {
                Console.WriteLine(ym.ToString());
            }
            Console.WriteLine();


            var ymSerch = ReyearMonth(ymArray);
            if (ymSerch == null)
                Console.WriteLine("21世紀のデータはありません");
            else
                Console.WriteLine(ReyearMonth(ymArray).ToString());
            Console.WriteLine();



            var ymArrayPlus = ymArray.Select(ym=> ym.AddOneMonth()).OrderBy(ym=> ym.Month).OrderBy(ym=> ym.Year);
            foreach (var ym in ymArrayPlus) {
                Console.WriteLine(ym.ToString());
            }



        }
        static YearMonth ReyearMonth(YearMonth[] ym) {
            foreach (var y in ym) {
                if(y.Is21Century)
                    return y;
            }
            return null;
            
        }
        private static string GetProduct() {
            Sale sale = new Sale {
                ShopName = "pet store",
                Product = "food"
            };
            sale = null;    //saleがnullだとnullが返ってくる
            return sale?.Product;   //nullじゃないからProductの値が返ってくる
        }
    }
    class Sale {
        //店舗名
        public string ShopName { get; set; }
        //売上高
        public int Amount { get; set; } = 1000000;
        public　string Product { get; set; }
    }
}
