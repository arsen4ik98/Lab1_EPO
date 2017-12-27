using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class BonusForSum : IBonusStrategy
    {
        double min;
        public BonusForSum(double min, double percent)
        {
            this.min = min;
            this.percent = percent;
        }

        public int GetBonus(int _quantity, double _price)
        {
            int bonus = 0;
            if (_quantity * _price > min)
            {
                bonus = (int)(_quantity * _price * percent);
            }
            return bonus;
        }

        private double percent;
    }
}
