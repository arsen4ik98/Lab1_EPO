using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class TXTPresenter : IPresenter
    {
        public string GetHeader(Customer _customer)
        {
            string caption = "Счет для " + _customer.getName() + "\n" + "\t" + "Название" + "\t" + "Цена" +
            "\t" + "Кол-во" + "Стоимость" + "\t" + "Скидка" +
            "\t" + "Сумма" + "\t" + "Бонус" + "\n";
            return caption;
        }

        public string GetFooter(double totalAmount, int totalBonus)
        {
            string continuum = "Сумма счета составляет " + totalAmount.ToString() + "\n" + "Вы заработали " + totalBonus.ToString() + " бонусных балов";
            return continuum;
        }

        public string GetItemString(double thisAmount, double discount, int bonus, Item each)
        {
            string getitem = "\t" + each.getGoods().getTitle() + "\t" +
                "\t" + each.getPrice() + "\t" + each.getQuantity() +
                "\t" + each.GetSum().ToString() +
                "\t" + discount.ToString() + "\t" + thisAmount.ToString() +
                "\t" + bonus.ToString() + "\n";
            return getitem;
        }
    }
}
