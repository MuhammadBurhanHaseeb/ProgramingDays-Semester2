using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaCoffeeShop.Menu
{
    class MenuUI
    {
        public static int menuHeader()
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
    }
}
