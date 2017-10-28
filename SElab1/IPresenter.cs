using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public interface IPresenter
    {
        string GetHeader(Customer _customer);
        string GetFooter(double totalAmount, int totalBonus);
        string GetItemString(double thisAmount, double discount, int bonus, Item each);
    }
}
