using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class HTMLPresenter : IPresenter
    {
        public string GetHeader(Customer _customer)
        {
            return "";
        }

        public string GetFooter(double totalAmount, int totalBonus)
        {
            string continuum = "Сумма счета составляет " + totalAmount.ToString() + "\n" + "Вы заработали " + totalBonus.ToString() + " бонусных балов";
            return continuum;
        }

        public string GetItemString(double thisAmount, double discount, int bonus, Item each)
        {
            string getitem = " " + each.getGoods().getTitle() + " " +
                " " + each.getPrice() + " " + each.getQuantity() +
                " " + each.GetSum().ToString() +
                " " + discount.ToString() + " " + thisAmount.ToString() +
                " " + bonus.ToString() + "\n";
            return getitem;
        }
    }
}
