using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.TaxCalculations
{
    public class TaxCalculationFactory
    {
        private Dictionary<string, ITaxCalculation> taxCalculations;

        public TaxCalculationFactory()
        {
            taxCalculations = new Dictionary<string, ITaxCalculation>();
            RegisterInFactory("Local", new LocalTaxCalculation());
        }

        public void RegisterInFactory(string strategy, ITaxCalculation taxCalc)
        {
            taxCalculations.Add(strategy, taxCalc);
        }

        public ITaxCalculation GetTaxCalculation(string strategy)
        {
            ITaxCalculation taxCalc = (ITaxCalculation)taxCalculations[strategy];
            return taxCalc;
        }

        public int GetFactorySize()
        {
            return taxCalculations.Count;
        }
    }

}
