using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public interface IDiscountStrategy
    {
        double GetDiscount(int _quantity, double _price);
    }
}
