using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;
namespace PointOfSale.UI
{
    class CustomerUI
    {
        

        public static CustomerBL buyProduct()
        {
            List<ProductBL> customerProductList = new List<ProductBL>();
            string customerName;
            Console.WriteLine("ENTRE THE NAME OF THE CUSTOMER");
            customerName = Console.ReadLine();
            int no;
            Console.WriteLine("how many product you want to buy : ");
            no = int.Parse(Console.ReadLine());
            for (int x = 0; x < no; x++)
            {
                ProductBL add = addCustomerProduct();
                if (add != null)
                {
                    CustomerDL.addCustomerProductList(add ,customerProductList);
                   // customerProductList.Add(add);
                }
            }
            CustomerBL s = new CustomerBL(customerName, customerProductList);
            return s;
        }
      public   static ProductBL addCustomerProduct()
        {
            Console.WriteLine("enter the produc name ");
            string name = Console.ReadLine();
            int count = 0;
            foreach (ProductBL s in ProductDL.productList)
            {
                if (name == s.getProductName())
                {
                    Console.WriteLine("enter the produc quantity : ");
                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity <= s.getProductQuantity())
                    {
                        string Category = s.getProductCategory();
                        int Price = s.getProductPrice();
                        int no  = s.getProductQuantity() - quantity;
                        s.setProductQuantity(no);

                        ProductBL a = new ProductBL(name, Category, Price, quantity);
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("product is not enough   >>");
                        Console.ReadKey();
                    }
                    count++;
                }
               if (count == ProductDL.productList.Count)
                {
                    Console.WriteLine("product not find >>");
                    Console.ReadKey();
                }
            }
            return null;
        }
        public static void display(float price )
        {
            Console.WriteLine("the price of the product after the sale tax  : " + price);
            Console.ReadKey();
        }
       
    }
}
