using Assignment.GoodsFactory;
using Assignment.TaxCalculations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Goods
{
    public class Medical : Good
    {

        public Medical()
            : base()
        {

        }

        public Medical(string name, double price, bool imported, int quantity)
            : base(name, price, imported, quantity)
        {
        }

        public override GoodFactory GetFactory()
        {
            return new MedicalGoodFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.MEDICAL_TAX;
            else
                return 0;
        }
    }
}
