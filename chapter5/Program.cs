﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter5 {
    class Program {
        static void Main(string[] args) {

            #region 演習5.1
            //Console.Write("文字を入力してください：");
            //var str1 = Console.ReadLine();
            //Console.Write("文字を入力してください：");
            //var str2 = Console.ReadLine();

            //if (string.Compare(str1, str2, true) == 0)
            //    Console.WriteLine("等しい");
            //else
            //    Console.WriteLine("等しくない");
            
            
            //Console.WriteLine();
            #endregion


            #region 演習5.2
            //Console.Write("数字を入力してください：");
            //var str3 = Console.ReadLine();
            //int num1;
            //if (int.TryParse(str3, out num1)) {
            //    Console.WriteLine("{0:#,#}", num1);
            //} else {
            //    Console.WriteLine("数値文字列でありません");
            //}
            #endregion


            #region 演習5.3

            //var str4 = "Jackdaws love my big sphinx of quartz";

            //int kuhaku = str4.Count(s => s == ' ');
            //Console.WriteLine(kuhaku + "個の空白");

            //var replaced = str4.Replace("big", "small");
            //Console.WriteLine(str4);

            //int tango = str4.Split(' ').Length;
            //Console.WriteLine(tango + "個の単語");

            //var tango2 = str4.Split(' ').Where(s => s.Length <= 4);
            //tango2.ToList().ForEach(s => Console.WriteLine(s));

            //var tango3 = str4.Split(' ');
            //var sb = new StringBuilder();
            //foreach (var s in tango3) {
            //    sb.Append(s + " ");
            //}
            //var text = sb.ToString();
            //Console.WriteLine(text); text.Split(';');
            #endregion

            #region 演習5.4
            var text = "Novelist=谷崎潤一郎;Bestwork=春琴抄;Born=1886";
            //var t = text.Replace("Novelist=", "作家　：").Replace("Bestwork=", "代表作：").Replace("Born=","誕生年：").Split(';');
            //foreach (var tango in t) {
            //    Console.WriteLine(tango);

            //}
            foreach (var item in text.Split(';')) {
                var word = item.Split('=');
                Console.WriteLine("{0}{1}", ToJapanese(word[0]), word[1]);
            }

            #endregion

        }
        static string ToJapanese(string key) {
            switch (key) {
                case "Novelist":
                return "作家　：";

                case "Bestwork":
                return "代表作：";

                case "Born":
                return "誕生年：";

                default:
                return "　　　　　";

            }
        }
    }
}
