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
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            //Judgement judge = IsEven;
            //Judgement fo = FiveOver;

            //匿名メソッドを利用した例
            //int count = Count(numbers,
            //    delegate(int n) { 
            //        return (n>=5); 
            //    });

            //ラムダ式
            int count = Count(numbers, (int n) =>  5 <= n && n <= 8);
            //int f5 = Count(numbers,fo);

            Console.WriteLine(count);
        }

        //nが偶数かどうかを調べるメソッド
        public static bool IsEven(int n) {
            //if (n % 2 == 0) {
            //    return true;
            //} else {
            //    return false;
            //}
            return (n%2 == 0);
        }
        //nが5以上かどうかを調べる
        public static bool FiveOver(int n) {
            return (n >= 5);
        }

        public static int Count(int[] numbers,Judgement judge) {
            
            int count = 0;
            foreach (var n in numbers) {
                if (judge(n)==true)
                    count++;
            }
            return count;
        }
    }
}
