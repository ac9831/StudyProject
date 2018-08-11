using System;
using System.Collections.Generic;
using System.Text;

namespace StudyProject.Sutdy_1
{
    public class Bread
    {
        private Product bread;

        public Bread()
        {
            bread = new Product(2, "빵", 600);
        }

        public void GetPrice()
        {
            Console.WriteLine("{0}", bread.GetPriceIncludingTax());
        }
    }
}
