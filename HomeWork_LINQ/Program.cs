using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Пункт A");

            List<int> listA = new List<int>() { 5, 3, 21, 111, 25, 53, 12, 9, 34, 22, 44 };

            listA.Sort();
            listA.Reverse();
            var listA1 = listA.Take(3).ToList();
            Console.WriteLine("Три максимальных значения:");
            Console.WriteLine(string.Join(", ", listA1));
            Console.WriteLine("========================================================");


            Console.WriteLine("Пункт B");
            List<int> listB = new List<int>() { 7, 9, 12, 11, 32, 25, 14 };
            listB.Sort();

            int min1 = listB[0];
            int min2 = listB[1];

            var listResults = listB.Where(listRes => listRes != min1 && listRes != min2).ToList();
            Console.WriteLine("Массив без двух минимальных значений:");
            Console.WriteLine(string.Join(", ", listResults));
            Console.WriteLine("========================================================");

            Console.WriteLine("Пункт C");

            List<int> listС = new List<int>() { 22, 55, 789, 466, 1088, 32, 1, 3, 57, 78, 99 };

            var list1С = listС.Where(l => l % 2 == 0).Sum();
            var list2С = listС.Where(l => l % 2 != 0).Sum();
            Console.WriteLine($"Сумма четных чисел равна:{list1С}\nCумма четных чисел равна:{list2С}");
            Console.WriteLine("========================================================");


            Console.WriteLine("Пункт D");

            List<int> listD = new List<int>() { 66, 88, 21, 6, 3, 97, 44 };

            listD.Sort();
            var l1 = listD.Max();
            var l2 = listD.Min();
            var sum = (l1 + l2);
            var res = listD.Sum() - sum;
            var result = res / listD.Count - 2;
            Console.WriteLine($"Среднее значение без максимального и минимального чисел равно:{result}");
            // Результат со всеми числами
            //Console.WriteLine(string.Join(", ", listD.Average()));
            Console.WriteLine("========================================================");


            Console.WriteLine("Пункт E");
            string _string = "В данном городе проживает большое количество граждан";
            string vowels = "аяыиуюэёо";
            _string = Regex.Replace(_string, "[ауоиюяеёыэ]", "");
            
            Console.WriteLine(_string);
            Console.WriteLine("========================================================");


            Console.WriteLine("Пункт F");

            List<int> listF = new List<int>() { 27, 15, 92, 61, 19, 32, 13, 4, 7, 22, 39 };
            List<double> listFResult = new List<double>();
            var list1F = listF.Where(l => l % 2 == 0).Select(l => Math.Pow(l, 2)).ToList();
            var list2F = listF.Where(l => l % 2 != 0).Select(l => Math.Pow(l, 3)).ToList();

            listFResult.AddRange(list1F);
            listFResult.AddRange(list2F);
            Console.WriteLine("Возведение в квадарат четных чисел и в куб нечетных:");
            Console.WriteLine(string.Join(", ", listFResult));
            Console.WriteLine("========================================================");
        }
    }
}
