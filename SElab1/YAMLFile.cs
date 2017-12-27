using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SElab1
{
    class YAMLFile : AbstractContentFile
    {
        public override StreamReader SetSource(string[] args)
        {
            string filename = "BillInfo.yaml";
            if (args.Length == 1)
                filename = args[0];
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            return sr;
        }
        public override string GetCustomer(StreamReader sr)
        {
            string line = GetNextLine(sr);
            string[] result = line.Split(':');
            string name = result[1].Trim();
            return name;
        }
        public override int GetBonus(StreamReader sr)
        {
            string line = GetNextLine(sr);
            string[] result = line.Split(':');
            int bonus = Convert.ToInt32(result[1].Trim());
            return bonus;
        }
        public override int GetGoodsCount(StreamReader sr)
        {
            string line = GetNextLine(sr);
            string[] result = line.Split(':');
            int goodsQty = Convert.ToInt32(result[1].Trim());
            return goodsQty;
        }
        public override void GetNextGood(Goods[] g, StreamReader sr)
        {
            string[] result;
            string line;
            for (int i = 0; i < g.Length; i++)
            {
                do
                {
                    line = GetNextLine(sr);
                } while (line.StartsWith("#"));
                result = line.Split(':');
                result = result[1].Trim().Split();
                string type = result[1].Trim();
                BillFactory factory = new BillFactory();
                g[i] = factory.Create(type, result[0]);
            }
        }
        public override int GetItemsCount(StreamReader sr)
        {
            string[] result;
            string line;
            do
            {
                line = GetNextLine(sr);
            } while (line.StartsWith("#"));
            result = line.Split(':');
            int itemsQty = Convert.ToInt32(result[1].Trim());
            return itemsQty;
        }
        public override void GetNextItem(int itemsQty, StreamReader sr, BillGenerator b, Goods[] g)
        {
            string[] result;
            string line;
            for (int i = 0; i < itemsQty; i++)
            {
                do
                {
                    line = GetNextLine(sr);
                } while (line.StartsWith("#"));
                result = line.Split(':');
                result = result[1].Trim().Split();
                int gid = Convert.ToInt32(result[0].Trim());
                double price = Convert.ToDouble(result[1].Trim());
                int qty = Convert.ToInt32(result[2].Trim());
                b.addGoods(new Item(g[gid - 1], qty, price));
            }
        }

        public string GetNextLine(StreamReader sr)
        {
            string line = sr.ReadLine();
            return line;
        }
    }
}
