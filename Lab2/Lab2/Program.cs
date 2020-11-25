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

            Service saleService1 = new Service("Сборка", "Сборка кухонного гарнитура", 1450, 1, 30);
            Service saleService2 = new Service("Доставка", "Перевозка в другой регион", 3500, 2, 80);
            Service saleService3 = new Service("Сборка", "Сборка сантехники", 2100, 2, 0);
            Service saleService4 = new Service("Ремонт", "Устранение косметических дефектов", 5750, 18, 30);
            Service saleService5 = new Service("Консультация", "Поиск повреждений сантехники", 700, 1, 0);

            saleService2.FullInfo();
            Console.WriteLine("------------------------------");

            saleService3.SaleInfo();
            Console.WriteLine("------------------------------");
            
            saleProduct3.FullInfo();
            Console.WriteLine("------------------------------");
            
            saleProduct5.SaleInfo();

            Console.WriteLine("\nЗа один час услуга \"{0}\" стоит {1}", saleService1.MyName, saleService1.WorkHour());
            Console.WriteLine("\nИзменение цены услуги \"{0}\" на {1}", saleService4.MyName, saleService1.MyPrice = 1600);
            Console.WriteLine("\nУвеличение цены товара \"{0}\" на {1}", saleProduct2.MyName, saleProduct2.MyPrice = 1600);
            
            Console.WriteLine("------------------------------");
            saleProduct2.FullInfo();

            Console.WriteLine("------------------------------");
            saleService1.SaleInfo();
        }
    }
}
