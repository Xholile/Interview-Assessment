using Assignment.Goods;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.GoodsFactory
{
    public class FoodGoodFactory : GoodFactory
    {
        public override Goods.Good CreateGood(string name, double price, bool imported, int quantity)
        {
            return new Food(name, price, imported, quantity);
        }
    }
}
