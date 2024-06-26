using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;
namespace PointOfSale.DL
{
    class ProductDL
    {
        public static List<ProductBL> productList = new List<ProductBL>();

        public static void addProductIntoList(ProductBL s)
        {
            productList.Add(s);
        }
        public static void addIntoFile(ProductBL s)
        {
            string path = "product.txt";
            StreamWriter f = new StreamWriter(path,true);
            f.WriteLine(s.getProductName() +","+s.getProductCategory()+","+s.getProductPrice()+","+s.getProductQuantity()+","+s.getThresholdProductQuantity());
            f.Flush();
            f.Close();
        }
        public static int  highestUnitPrice(string categoryName)
        {
            int price = 0;
            string name = null;
            foreach (ProductBL s in productList)
            {
                if (categoryName == s.getProductCategory())
                {
                    if (price < s.getProductPrice())
                    {
                        price = s.getProductPrice();
                        name = s.getProductName();
                    }
                }
            }
            return price;
           // Console.WriteLine("the highest unit price is {0} and it name is {1} and it category is {2} ", price, name, categoryName);
            //Console.ReadKey();
        }
        public static void loadProduct()
        {
            string path = "product.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    string category = load[1];
                    int price = int.Parse(load[2]);
                    int quantity = int.Parse(load[3]);
                    int thresholdQuantity = int.Parse(load[4]);
                    ProductBL s = new ProductBL(name, category, price, quantity, thresholdQuantity);
                   productList.Add(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
        public static ProductBL isProductExist(string name)
        {
            foreach(ProductBL s  in productList)
            {
                if (name == s.getProductName())
                {
                    return s;
                }
            }
            return null;

        }
    }
}
