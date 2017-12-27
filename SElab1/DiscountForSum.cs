using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class DiscountForSum : IDiscountStrategy
    {
        double min;
        public DiscountForSum(double min, double percent)
        {
            this.min = min;
            this.percent = percent;
        }
        public double GetDiscount(int _quantity, double _price)
        {
            double discount = 0;
            if (_quantity * _price > min)
                discount = _quantity * _price * percent;
            return discount;
        }

        private double percent;
    }
}
