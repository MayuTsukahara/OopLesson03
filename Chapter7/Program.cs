using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter7 {
    class Program {
        static void Main(string[] args) {
            //var flowerDict = new Dictionary<string, int>() {
            //    ["sunflower"] = 400,
            //    ["pansy"] = 300,
            //    ["tulip"] = 350,
            //    ["tose"] = 500,
            //    ["dahlia"] = 450
            //};
            //flowerDict["violet"] = 600;
            ////flowerDict.Add("violet", 600);

            //foreach (var flower in flowerDict) {
            //    Console.WriteLine($"{flower.Key}={flower.Value}");
            //}




            //var employeeDict = new Dictionary<int, Employee> {
            //    { 100,new Employee(100,"清水遼久")},
            //    { 112,new Employee(112,"芦沢洋和")},
            //    { 125,new Employee(125,"岩瀬奈央子")}
            //};

            ////偶数
            //var num = employeeDict.Where(emp=>emp.Value.Id%2 == 0).ToList();
            //foreach (var item in num) {
            //    Console.WriteLine(item.Value.Name);
            //}
            //Console.WriteLine();

            ////合計
            //Console.WriteLine( employeeDict.Sum(emp=>emp.Value.Id));
            //Console.WriteLine();

            //int sum = 0;
            //foreach (KeyValuePair<int,Employee> item in employeeDict) {
            //    Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //    sum += item.Value.Id;
            //}
            //Console.WriteLine(sum);







            //var employee = new List<Employee>() {
            //    new Employee(100,"清水遼久"),
            //    new Employee(112,"芦沢洋和"),
            //    new Employee(125,"岩瀬奈央子"),
            //    new Employee(143,"山田太郎"),
            //    new Employee(148,"池田次郎"),
            //    new Employee(152,"高田三郎"),
            //    new Employee(155,"石川幸也"),
            //    new Employee(161,"中沢信也"),
            //};

            //var employeeDict = employee.Where(emp=>emp.Id%2 == 0).ToDictionary(emp=>emp.Id).ToList();

            //foreach (KeyValuePair<int, Employee> item in employeeDict) {
            //    Console.WriteLine($"{item.Value.Id} = {item.Value.Name}");
            //}
            //Console.WriteLine();






            var dict = new Dictionary<MonthDay,string>() {
                {new MonthDay(3,5) ,"珊瑚の日"},
                {new MonthDay(8,4) ,"箸の日"},
                {new MonthDay(10,3) ,"登山の日"},
            };

            var md = new MonthDay(8, 4);
            var s = dict[md];
            Console.WriteLine(s);








        }
        }
}
