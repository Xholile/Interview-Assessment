using Assignment.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.TaxCalculations
{
    public class LocalTaxCalculation : ITaxCalculation
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;

            if (imported)
                tax += (price * 0.5);

            //rounds off to nearest 0.05;
            tax = TaxUtilities.RoundOff(tax);

            return tax;
        }
    }
}
