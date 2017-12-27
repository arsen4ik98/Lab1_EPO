﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    public class Item
    {
        private Goods _Goods;
        private int _quantity;
        private double _price;
        public Item(Goods Goods, int quantity, double price)
        {
            _Goods = Goods;
            _quantity = quantity;
            _price = price;
        }
        public int getQuantity()
        {
            return _quantity;
        }
        public double getPrice()
        {
            return _price;
        }
        public Goods getGoods()
        {
            return _Goods;
        }
        public void setGoods(Goods arg)
        {
            _Goods = arg;
        }
        public void setGoodsType(Goods arg)
        {
            _Goods = arg;
        }
        // прокси-метод GetBonus()
        public int ExecuteOperationBonus()
        {
            return _Goods.ExecuteOperationBonus(_quantity, _price);
        }
        // прокси-метод GetDiscount()
        public double ExecuteOperationDiscount()
        {
            return _Goods.ExecuteOperationDiscount(_quantity, _price);
        }
        public double GetSum()
        {
            double getsum = getQuantity() * getPrice();
            return getsum;
        }
    }
}
