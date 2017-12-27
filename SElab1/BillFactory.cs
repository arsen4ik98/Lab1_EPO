using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    class BillFactory
    {
        public Goods Create(string type, string name) //Factory method
        {
            Goods g1 = null;
            switch (type)
            {
                case "REG":
                    g1 = new RegularGoods(name);
                    break;
                case "SAL":
                    g1 = new SaleGoods(name);
                    break;
                case "SPO":
                    g1 = new SpecialOrderGoods(name);
                    break;
            }
            return g1;
        }
    }
}
