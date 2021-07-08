using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.GoodsFactory
{
    public class MedicalGoodFactory : GoodFactory
    {
        public override Goods.Good CreateGood(string name, double price, bool imported, int quantity)
        {
            return new Medical(name, price, imported, quantity);
        }
    }
}
