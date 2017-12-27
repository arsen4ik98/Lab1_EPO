using System;
using System.Configuration;

namespace SElab1
{
    class BillFactory
    {
        public Goods Create(string type, string name) //Factory method
        {
            IBonusStrategy bonus = null;
            IDiscountStrategy discount = null;
            Goods g1 = null;
            switch (type)
            {
                case "REG":
                    {
                        bonus = new BonusRegularGoods();
                        discount = new DiscountRegularGoods();
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
                case "SAL":
                    {
                        bonus = new BonusSaleGoods();
                        discount = new DiscountSaleGoods();
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
                case "SPO":
                    {
                        bonus = new BonusSpecialOrderGoods();
                        discount = new DiscountSpecialOrderGoods();
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
            }
            return g1;
        }
    }
}
