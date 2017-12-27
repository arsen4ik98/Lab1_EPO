using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    class DiscountSpecialOrderGoods : IDiscountStrategy
    {
        public double GetDiscount(int _quantity, double _price)
        {
            double discount = 0;
            if (_quantity * _price > 5000)
                discount = _quantity * _price * 0.05; // 5%
            else if (_quantity > 10)
                discount = _quantity * _price * 0.005; // 0.5%
            return discount;
        }
    }
}
