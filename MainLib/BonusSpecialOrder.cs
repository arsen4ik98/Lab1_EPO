using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    class BonusSpecialOrder : IBonusStrategy
    {
        public int GetBonus(int _quantity, double _price)
        {
            return 0;
        }
    }
}
