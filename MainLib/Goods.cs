using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Goods
    {
        private IBonusStrategy _BonusStrategy;
        private IDiscountStrategy _DiscountStrategy;
        public string _title;
        public Goods(string title, IBonusStrategy BonusStrategy, IDiscountStrategy DiscountStrategy)
        {
            _title = title;
            _BonusStrategy = BonusStrategy;
            _DiscountStrategy = DiscountStrategy;
        }
        public string getTitle()
        {
            return _title;
        }

        public void SetBonusStrategy(IBonusStrategy BonusStrategy)
        {
            _BonusStrategy = BonusStrategy;
        }

        public void SetDiscountStrategy(IDiscountStrategy DiscountStrategy)
        {
            _DiscountStrategy = DiscountStrategy;
        }

        public int ExecuteOperationBonus(int _quantity, double _price)
        {
            return _BonusStrategy.GetBonus(_quantity, _price);
        }

        public double ExecuteOperationDiscount(int _quantity, double _price)
        {
            return _DiscountStrategy.GetDiscount(_quantity, _price);
        }

    }
}
