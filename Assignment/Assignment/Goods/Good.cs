using Assignment.GoodsFactory;
using System;
using System.Collections.Generic;
using System.Text;


namespace Assignment.Goods
{
    public abstract class Good
    {
        protected string Name { get; set; }

        private double _price;
        public double Price
        {
            set { _price = value; }
            get { return _price * Quantity; }
        }

        public bool Imported { get; set; }

        public int Quantity { get; set; }

        public double TaxedCost { get; set; }

        public Good()
        {
            this.Name = string.Empty;
            this.Price = 0.0;
            this.Imported = false;
            this.Quantity = 0;
            this.TaxedCost = 0.0;
        }

        public Good(string name, double price, bool imported, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Imported = imported;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return (Quantity + " " + ImportedToString(Imported) + " " + Name + " : " + TaxedCost);
        }

        public String ImportedToString(bool imported)
        {
            if (!imported)
                return string.Empty;
            else
                return "imported";
        }

        public abstract GoodFactory GetFactory();

        public abstract double GetTaxValue(string country);

    }
}
