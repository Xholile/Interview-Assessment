using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.TaxCalculations
{
    public interface ITaxCalculation
    {
        double CalculateTax(double price, double tax, bool imported);
    }
}
