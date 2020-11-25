using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2
{
    class Service : Sale
    {
        private int timeHour;
        private int timeMin;
        public Service(string type, string name, double price, int timeHour, int timeMin)
            : base(type, name, price)
        {
            int hour = timeHour;
            int min = timeMin;
            
            if (timeMin > 59) // 60 мин = 1 часу
            {
                hour += timeMin / 60;
                min = timeMin % 60;
            }
            
            this.timeHour = Math.Abs(hour);
            this.timeMin = Math.Abs(min);
        }

        public int MyTimeHour
        {
            get { return timeHour; }
            set { timeHour = value; }
        }

        public int MyTimeMin
        {
            get { return timeMin; }
            set { timeMin = value < 60 ? value : 0 ; }
        }

        public double WorkHour()  //Цена услуги за 1 час
        {
            double price = MyPrice * 60 / (timeHour * 60 + timeMin);
            return Math.Round(price, 2);
        }

        public override void SaleInfo()
        {
            Console.WriteLine("Один час за услугу \"{0}\" будет стоить {1}", MyName, WorkHour());
        }


        public override void FullInfo()
        {
            Console.WriteLine("Тип: {0}", MyType);
            Console.WriteLine("Наименование: {0}", MyName);
            Console.WriteLine("Цена: {0}", MyPrice);
            Console.WriteLine("Время: {0}:{1}", MyTimeHour, MyTimeMin);
        }
    }
}

