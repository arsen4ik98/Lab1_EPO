using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class BillGenerator
    {
        private List<Item> _items;
        private Customer _customer;
        private IPresenter p;
        public IPresenter Preseter
              {
            get
            {
                return p;
            }
            set
            {
                p = value;

            }
        }
        public BillGenerator(Customer customer, IPresenter p)
        {
            this._customer = customer;
            this._items = new List<Item>();
            this.p = p;
        }

        public void addGoods(Item arg)
        {
            _items.Add(arg);
        }

        public double GetUsedBonus(Item each, double thisAmount, double discount)
        {
            double usedBonus = 0;
            if (each.getGoods().GetType() == typeof(Goods) && each.getQuantity() > 5)
            {
                usedBonus += _customer.useBonus((int)(thisAmount - discount));
            }
            if (each.getGoods().GetType() == typeof(BonusSpecialOrder) && each.getQuantity() > 1)
            {
                usedBonus += _customer.useBonus((int)(thisAmount - discount));
            }
            return usedBonus;
        }

        public String GetBill()
        {
            double totalAmount = 0;
            int totalBonus = 0;
            List<Item>.Enumerator items = _items.GetEnumerator();
            string result = p.GetHeader(_customer);
            while (items.MoveNext())
            {
                double sumWithDiscount = 0;
                double usedBonus = 0;
                double thisAmount = 0;
                Item each = (Item)items.Current;
                //определить сумму для каждой строки
                double discount = each.ExecuteOperationDiscount();
                int bonus = each.ExecuteOperationBonus();
                // сумма
                sumWithDiscount = each.GetSum() - discount;
                usedBonus = GetUsedBonus(each, sumWithDiscount, discount);
                thisAmount = sumWithDiscount - usedBonus;
                //показать результаты
                result += p.GetItemString(thisAmount, discount, bonus, each);
                totalAmount += thisAmount;
                totalBonus += bonus;
            }
            //добавить нижний колонтитул
            result += p.GetFooter(totalAmount, totalBonus);
            //Запомнить бонус клиента
            _customer.receiveBonus(totalBonus);
            return result;
        }
    }
}
