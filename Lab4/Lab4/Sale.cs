using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    abstract class Sale
    {
        private string name;
        private double price;
        private string type;
        public Sale(string type, string name, double price)
        {
            this.type = type;
            this.name = name;
            this.price = price;           
        }

        public string MyType 
        {
            get { return type; }
            set { type = value; }
        }

        public string MyName
        {
            get { return name; }
            set { name = value; }
        }

        public double MyPrice
        {
            get { return price; }
            set { price = value; }
        }
        public static void WriteList(List<Sale> list) 
        {
            foreach (Sale el in list)
            {
                Console.WriteLine("{0}, {1}, {2}", el.MyType, el.MyName, el.MyPrice);
            }
        }
        public static void SinglList(List<Sale> list, int index) 
        {
            try
            {
                Console.WriteLine(list[index]);
            }
            catch (ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine("Error! {0}", ex.Message);
            }
        }
        public abstract void SaleInfo();

        public abstract void FullInfo();
    }
}
