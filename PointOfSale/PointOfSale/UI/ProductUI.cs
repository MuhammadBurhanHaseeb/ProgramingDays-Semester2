using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;
namespace PointOfSale.UI
{
    class ProductUI
    {
        public static ProductBL addProduct()
        {
            string name, category;
            int price, quantity, thresholdQuantity;
            Console.WriteLine("enter the name of the product :");
            name = Console.ReadLine();
            Console.WriteLine("enter the category of the product :  ");
            category = Console.ReadLine();
            Console.WriteLine("enter the price of the product :  ");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the quantity of the product :");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the threshold quantity of the product :");
            thresholdQuantity = int.Parse(Console.ReadLine());
            ProductBL s = new ProductBL(name, category, price, quantity, thresholdQuantity);
            return s;
        }
        public static void viewAllProduct()
        {
            Console.WriteLine("product name\tproduct category\tproduct price\tproduct quantity\tproduct threshold quantity ");
            foreach (ProductBL s in ProductDL.productList)
            {
                Console.WriteLine(s.getProductName() + "\t" + s.getProductCategory() + "\t" + s.getProductPrice() + "\t" + s.getProductQuantity() + "\t" + s.getThresholdProductQuantity());
            }
            Console.ReadKey();
        }
        public static void displayPrice(string name , int price )
            {
            Console.WriteLine("the highest price in this category name of "+ name +" is " +price);
            Console.ReadKey();
            }
        public static void viewSaleTax()
        {
            Console.WriteLine("ON ALL  GROCERY PRODUCTS SALE TAX IS  :: 10 %");

            Console.WriteLine("ON ALL FRUIT TYPE THE SALE TAX IS  :: 5 % ");

            Console.WriteLine("OR OTHER TYPE OF THE PRODUCT SALE TAX IS  :: 15 %");

            Console.ReadKey();

        }
        public static void alaramProductOrder()
        {
            foreach (ProductBL s in ProductDL.productList)
            {
                if (s.getProductQuantity() <= s.getThresholdProductQuantity())
                {
                    Console.WriteLine("you have to add the product which name is ::" + s.getProductName() + "and product category is " + s.getProductCategory());
                }
            }
            Console.ReadKey();
        }


    }
}
