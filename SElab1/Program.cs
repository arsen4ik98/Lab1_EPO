using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SElab1
{
    class Program
    {
        static void Main(string[] args)
        {
            YAMLFile file = new YAMLFile();
            string bill = file.CreateBill(args);
            Console.WriteLine(bill);
            Console.ReadKey();
        }
    }
}
