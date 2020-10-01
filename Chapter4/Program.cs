using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Chapter4 {
    class Program {
        static void Main(string[] args) {
            YearMonth ym = new YearMonth(2011,3);
            if (ym.Is21Century)
                Console.WriteLine("２１世紀ではない");
            else
                Console.WriteLine("２１世紀である");

            Console.WriteLine("１ヶ月後は"+ym.AddOneMonth());
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
