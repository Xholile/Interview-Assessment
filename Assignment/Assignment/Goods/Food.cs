using Assignment.GoodsFactory;
using Assignment.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Goods
{
    public class Food : Good
    {
        public Food()
            : base()
        {

        }

        public Food(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override GoodFactory GetFactory()
        {
            return new FoodGoodFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.FOOD_TAX;
            else
                return 0;
        }
    }
}
