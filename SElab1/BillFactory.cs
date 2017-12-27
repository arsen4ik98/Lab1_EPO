using System;
using System.Configuration;

namespace SElab1
{
    class BillFactory
    {
        public Goods Create(string type, string name) //Factory method
        {
            double min_sum;
            double percent;
            IBonusStrategy bonus = null;
            IDiscountStrategy discount = null;
            Goods g1 = null;
            switch (type)
            {
                case "REG":
                    {
                        min_sum = Convert.ToDouble(ConfigurationManager.AppSettings["BonusRegularGoodsSum"]);
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["BonusRegularGoodsNewYearPercent"]);
                        bonus = new BonusForSum(min_sum, percent);
                        min_sum = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountRegularGoodsQuantity"]);
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountRegularGoodsPercent"]);
                        discount = new DiscountForQuantity(min_sum, percent);
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
                case "SAL":
                    {
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["BonusSalePercent"]);
                        bonus = new BonusFixed(percent);
                        min_sum = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountSaleGoodsNewYearSum"]);
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountSaleGoodsNewYearPercent"]);
                        discount = new DiscountForSum(min_sum, percent);
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
                case "SPO":
                    {
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["BonusSpecialOrderGoodsPercent"]);
                        bonus = new BonusFixed(percent);
                        min_sum = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountSpecialOrderGoodsNewYearSum"]);
                        percent = Convert.ToDouble(ConfigurationManager.AppSettings["DiscountSpecialOrderGoodsNewYearPercent"]);
                        discount = new DiscountForSum(min_sum, percent);
                        g1 = new Goods(name, bonus, discount);
                    }
                    break;
            }
            return g1;
        }
    }
}
