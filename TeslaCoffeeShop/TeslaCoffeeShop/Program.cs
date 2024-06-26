using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;
using TeslaCoffeeShop.UI;
using TeslaCoffeeShop.Menu;
using TeslaCoffeeShop.DL;


namespace TeslaCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItemDL.loadMenu();
            CoffeeShopDL.loadOrder();
            int op = 0;
            while (true)
            {
                Console.Clear();
                op =MenuUI.menuHeader();
                if (op == 1)
                {
                    MenuItemBL s =MenuItemUI.addMenu();
                    MenuItemDL.addIntoList(s);
                    MenuItemDL.addIntoFile(s);
                  //  CoffeeShopBL.menuList.Add(s);
                }
                else if (op == 2)
                {
                  int price = MenuItemDL.cheapestItem();
                    Console.WriteLine("the cheapest price of the product in the menu list is : " + price);
                    Console.ReadKey();
                }
                else if (op == 3)
                {
                    MenuItemUI.viewDrinksMenu();
                }
                else if (op == 4)
                {
                    MenuItemUI.viewFoodsMenu();
                }
                else if (op == 5)
                {
                    Console.WriteLine("how many order you want to enter");
                    int no = int.Parse(Console.ReadLine());
                    for (int x = 0; x < no; x++)
                    {

                     string name = CoffeeShopUI.addOrder();
                        if (name != null)
                        {
                            CoffeeShopDL.addIntoList(name);
                            CoffeeShopDL.addIntoFile(name);
                        }
                        else
                        {
                            Console.WriteLine("no find >>");
                            Console.ReadKey();
                        }
                    }
                }
                else if (op == 6)
                {
                  CoffeeShopUI.fulfillOrder();
                }
                else if (op == 7)
                {
                   CoffeeShopUI.viewOrderList();
                }
                else if (op == 8)
                {
                  int price =  CoffeeShopDL.payableAmount();
                    Console.WriteLine("the total amount of the orders is : " + price);
                    Console.ReadKey();
                }
                else if (op == 9)
                {
                    Console.WriteLine("thanks for using this application >> ");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("enter the valid option >>");
                    Console.ReadKey();
                }
            }
        }
       
       
        
        
       
        
       
        
       
       
    }
}
