using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        { 
           
            Product saleProduct1 = new Product("Кухонная мебель", "Стол", 3758.8, 4);
            Product saleProduct2 = new Product("Сантехника", "Раковина", 1270, 2.3);
            Product saleProduct3 = new Product("Кухонная мебель", "Кухонный уголок", 13758.8, 12);
            Product saleProduct4 = new Product("Мебель для улицы", "Садовой гном", 2500.8, 1.2);
            Product saleProduct5 = new Product("Кухонная мебель", "Холодильник", 25780, 14);

            Service<long> saleService1 = new Service<long>(125546481, "Сборка", "Сборка кухонного гарнитура", 1450, 1, 30);
            Service<string> saleService2 = new Service<string>("ald00i9", "Доставка", "Перевозка в другой регион", 3500, 2, 80);
            Service<double> saleService3 = new Service<double>(5.2, "Сборка", "Сборка сантехники", 2100, 2, 0);
            Service<int> saleService4 = new Service<int>(6, "Ремонт", "Устранение косметических дефектов", 5750, 18, 30);
            Service<string> saleService5 = new Service<string>("asd7M5", "Консультация", "Поиск повреждений сантехники", 700, 1, 0);

            List<Sale> saleList = new List<Sale>() { saleProduct1, saleProduct2, saleProduct3, saleProduct4, saleProduct5, saleService1, 
                saleService2, saleService3, saleService4, saleService5};

            List<Sale> tempList = saleList.OrderBy(x => x.MyType).ToList();

            Console.WriteLine("Не отсортированные продажи: ");
            Sale.WriteList(saleList);
            Console.WriteLine("\nПродажи, отсортированные по типу: ");
            Sale.WriteList(tempList);

            List<Sale> emptyList = new List<Sale>();

            Console.WriteLine("\nПопытка вывести 4 элемента из saleList");
            Sale.SinglList(saleList, 3);

            Console.WriteLine("\nПопытка вывести 1 элемент из emptyList");
            Sale.SinglList(emptyList, 0);
            
            Console.WriteLine("\nПопытка вывести 12 элемента из saleList");
            Sale.SinglList(saleList, 11);
        }
    }
}
