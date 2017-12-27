using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public abstract class AbstractContentFile
    {
        public string CreateBill(string[] args)
        {
            StreamReader sr = SetSource(args);
            string name = GetCustomer(sr);
            int bonus = GetBonus(sr);
            Customer customer = new Customer(name, bonus);
            IPresenter p = new TXTPresenter();
            BillGenerator b = new BillGenerator(customer, p);
            int goodsQty = GetGoodsCount(sr);
            Goods[] g = new Goods[goodsQty];
            GetNextGood(g, sr);
            int itemsQty = GetItemsCount(sr);
            GetNextItem(itemsQty, sr, b, g);
            string bill = b.GetBill();
            return bill;
        }

        public abstract StreamReader SetSource(string[] args);
        public abstract string GetCustomer(StreamReader sr);
        public abstract int GetBonus(StreamReader sr);
        public abstract int GetGoodsCount(StreamReader sr);
        public abstract void GetNextGood(Goods[] g, StreamReader sr);
        public abstract int GetItemsCount(StreamReader sr);
        public abstract void GetNextItem(int itemsQty, StreamReader sr, BillGenerator b, Goods[] g);
    }
}

