using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.UI;
namespace PointOfSale.DL
{
    class CustomerDL
    {
        public static List<CustomerBL> customerList = new List<CustomerBL>();

        public static void addCustomerProductList(ProductBL a , List<ProductBL> list)
        {
            list.Add(a);
        }
        public static void addIntoList(CustomerBL s)
        {
            customerList.Add(s);
        }
        public static void addIntoFile(CustomerBL s)
        {
            string path = "customer.txt";
            string productName = "";
            StreamWriter f = new StreamWriter(path,true);
            for(int x = 0 ; x<s.getCustomerProduct().Count -1 ;  x++) 
            {
                productName = productName + s.getCustomerProduct()[x].getProductName() + ";";

            }
            productName = productName + s.getCustomerProduct()[s.getCustomerProduct().Count - 1].getProductName();
            f.WriteLine(s.getCustomerName() + "," + productName);
            f.Flush();
            f.Close();
        }
        public static void loadCustomer()
        {

            string path = "customer.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    string[] load1 = load[0].Split(';');
                    List<ProductBL> customerProduct = new List<ProductBL>();
                    for(int x = 0; x< load1.Length;x++)
                    {
                        ProductBL a = ProductDL.isProductExist(load1[x]);
                        if (a != null)
                        {
                            customerProduct.Add(a);
                        }
                    }
                   
                    CustomerBL s = new CustomerBL(name, customerProduct);
                    customerList.Add(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
        public static float calculatePrice(string customerName)
        {
            float price = 0;
            float discount = 0;
            foreach (CustomerBL s in customerList)
            {
                if (customerName == s.getCustomerName())
                {
                    for (int x = 0; x < s.getCustomerProduct().Count; x++)
                    {
                        if (s.getCustomerProduct()[x].getProductCategory() == "fruit")
                        {
                            price = price + s.getCustomerProduct()[x].getProductPrice();
                            price = price * s.getCustomerProduct()[x].getProductQuantity();
                            discount = (price * (5 / 100.0F));
                            price = price - discount;
                        }
                        else if (s.getCustomerProduct()[x].getProductCategory() == "grocery")
                        {
                            price = price + s.getCustomerProduct()[x].getProductPrice();
                            price = price * s.getCustomerProduct()[x].getProductQuantity();
                            discount = (price * (10 / 100.0F));
                            price = price - discount;
                        }
                        else
                        {
                            price = price + s.getCustomerProduct()[x].getProductPrice();
                            price = price * s.getCustomerProduct()[x].getProductQuantity();
                            discount = (price * (15 / 100.0F));
                            price = price - discount;
                        }

                    }
                }
            }
            return price;
           
        }
    }
}
