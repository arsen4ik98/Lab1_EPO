using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    class BonusFixed : IBonusStrategy
    {
        public BonusFixed(double percent)
        {
            this.percent = percent;
        }
        public int GetBonus(int _quantity, double _price)
        {
            int bonus = 0;
            return bonus = (int)(_quantity * _price * percent);
        }

        private double percent;
    }
}
