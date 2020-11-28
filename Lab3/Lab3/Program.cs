using System;

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

            Console.WriteLine(saleProduct1.ToString());
            Console.WriteLine("------------------------------");

            Console.WriteLine("Проверка на равенсто продуктов: {0}\n", saleProduct3.Equals(saleProduct2));
            
            Console.WriteLine("------------------------------");
            saleService1.FullInfo();
            
            Console.WriteLine("------------------------------");
            saleService2.FullInfo();
        }
    }
}
