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

        public abstract void SaleInfo();

        public abstract void FullInfo();
    }
}
