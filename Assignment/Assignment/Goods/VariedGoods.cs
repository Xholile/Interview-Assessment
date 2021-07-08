using Assignment.GoodsFactory;
using Assignment.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Goods
{
    public class VariedGood : Good
    {
        public VariedGood()
            : base()
        {
        }

        public VariedGood(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }
        public override GoodFactory GetFactory()
        {
            return new VariedGoodsFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MISC_TAX;
            else
                return 0;
        }
    }
}
