using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Product : Sale
    {
        private double weight;

        public Product(string type, string name, double price, double weight) 
            : base(type, name, price)
        {
            this.weight = weight;
        }

        public double MyWeight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override void SaleInfo()
        {
            Console.WriteLine("Цена на товар \"{0}\" равняется {1}", MyName, MyPrice);
        }

        public override void FullInfo()
        {
            Console.WriteLine("Тип: {0}", MyType);
            Console.WriteLine("Наименование: {0}", MyName);
            Console.WriteLine("Цена: {0}", MyPrice);
            Console.WriteLine("Вес: {0}", MyWeight);
        }
    }
}
