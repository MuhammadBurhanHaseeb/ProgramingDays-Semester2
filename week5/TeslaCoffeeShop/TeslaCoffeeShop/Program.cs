using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeslaCoffeeShop.BL;

namespace TeslaCoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            while (true)
            {
                Console.Clear();
                op = menuHeader();
                if (op == 1)
                {
                    MenuItem s = addMenu();
                    CoffeeShop.menuList.Add(s);
                }
                else if (op == 2)
                {
                    cheapestItem();
                }
                else if (op == 3)
                {
                    viewDrinksMenu();
                }
                else if (op == 4)
                {
                    viewFoodsMenu();
                }
                else if (op == 5)
                {
                    Console.WriteLine("how many order you want to enter");
                    int no = int.Parse(Console.ReadLine());
                    for (int x = 0; x < no; x++)
                    {
                        addOrder();
                    }
                }
                else if (op == 6)
                {
                    fulfillOrder();
                }
                else if (op == 7)
                {
                    viewOrderList();
                }
                else if (op == 8)
                {
                    payableAmount();
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
        static int menuHeader()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-        TESLA COFFE SHOP     -");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("1. ADD A MENU ITEM  :");
            Console.WriteLine("2. VIEW THE CHEAPEST ITEM IN THE MENU   :");
            Console.WriteLine("3. VIEW THE DRINK'S MENU   :");
            Console.WriteLine("4. VIEW THE FOOD'S MENU    :");
            Console.WriteLine("5. ADD THE ORDER  :");
            Console.WriteLine("6. FULFILL THE ORDER :");
            Console.WriteLine("7. VIEW THE ORDER LIST :");
            Console.WriteLine("8. TOTAL PAYABLE AMOUNT  :");
            Console.WriteLine("9. EXIT :");
            Console.WriteLine("ENTER THE OPTION  :");
            int option = 0;
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static MenuItem addMenu()
        {
            string name, type;
            int price;
            Console.WriteLine("enter the name of the product :");
            name = Console.ReadLine();
            Console.WriteLine("enter the type of the product :");
            type = Console.ReadLine();
            Console.WriteLine("enter the price of the product :");
            price = int.Parse(Console.ReadLine());
            MenuItem add = new MenuItem(name, type, price);
            return add;

        }
        static void cheapestItem()
        {
            int price = CoffeeShop.menuList[0].itemPrice;
            for (int x = 1; x < CoffeeShop.menuList.Count; x++)
            {
                if (price > CoffeeShop.menuList[x].itemPrice)
                {
                    price = CoffeeShop.menuList[x].itemPrice;
                }
            }
            Console.WriteLine("the cheapest price of the product in the menu list is : "+ price);
            Console.ReadKey();
        }
        static void viewDrinksMenu()
        {
            Console.WriteLine("name \t type \t price");
            foreach (MenuItem s in CoffeeShop.menuList)
            {
                if (s.itemType == "drinks")
                {
                    Console.WriteLine(s.itemName + "\t" + s.itemType + "\t" + s.itemPrice);
                }
            }
            Console.ReadKey();
        }
        static void viewFoodsMenu()
        {
            Console.WriteLine("name \t type \t price");
            foreach (MenuItem s in CoffeeShop.menuList)
            {
                if (s.itemType == "foods")
                {
                    Console.WriteLine(s.itemName + "\t" + s.itemType + "\t" + s.itemPrice);
                }
            }
            Console.ReadKey();
        }
        static void addOrder()
        {
            string name;
            Console.WriteLine("enter the name of the product ");
            name = Console.ReadLine();
            foreach (MenuItem s in CoffeeShop.menuList)
            {
                if (name == s.itemName)
                {
                    CoffeeShop.orders.Add(name);
                }
            }
        }
        static void viewOrderList()
        {
            for(int x= 0; x<CoffeeShop.orders.Count; x++)
            {
                Console.WriteLine(CoffeeShop.orders[x]);
            }
            Console.ReadKey();
        }
        static void payableAmount()
        {
            int price = 0;
            for(int x = 0; x< CoffeeShop.orders.Count; x++)
            {
                foreach(MenuItem s in CoffeeShop.menuList)
                {
                    if (CoffeeShop.orders[x] == s.itemName)
                    {
                        price = price + s.itemPrice;
                    }
                }
            }
            Console.WriteLine("the total amount of the orders is : " + price );
            Console.ReadKey();
        }
        static void fulfillOrder()
        {
            for (int x = 0; x < CoffeeShop.orders.Count; x++)
            {
                Console.WriteLine("the order of " +CoffeeShop.orders[x]+" is ready");
            }
            Console.WriteLine("the all oredrs are delivered >>");
            Console.ReadKey();
            CoffeeShop.orders.Clear();
        }
    }
}
