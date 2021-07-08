using Assignment.GoodsFactory;
using Assignment.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Goods
{
    public class Book : Good
    {

        public Book()
            : base()
        {
        }

        public Book(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {

        }

        public override GoodFactory GetFactory()
        {
            return new BookGoodFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.BOOK_TAX;
            else
                return 0;
        }
    }
}
