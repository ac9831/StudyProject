using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1
{
    public class Product
    {
        public int Code { get; private set; }
        public string Name { get; private set; }
        public int Price { get; private set; }

        public Product(int code, string name, int price)
        {
            this.Code = code;
            this.Name = name;
            this.Price = price; 
        }

        public int GetTax()
        {
            return (int)(Price * 0.08);
        }

        public int GetPriceIncludingTax()
        {
            return Price + GetTax();
        }
    }
}
