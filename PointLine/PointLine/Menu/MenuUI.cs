using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLine.Menu
{
    class MenuUI
    {
        public static int menuHeader()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            POINT LINE         ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1. MAKE A LINE :");
            Console.WriteLine("2. UPDATE THE BEGIN POINT  :");
            Console.WriteLine("3. UPDATE THE END POINT  :");
            Console.WriteLine("4. SHOW THE UPDATE begin POINT   :");
            Console.WriteLine("5. SHOW THE update END POINT :");
            Console.WriteLine("6. GET THE LENGTH OF THE LINE :");
            Console.WriteLine("7. GET THE GRADIENT OF THE LINE :");
            Console.WriteLine("8. FIND THE DISTANCE OF BEGIN POINT FROM ZERO COORDINATES  :");
            Console.WriteLine("9. FIND THE DISTANCE OF END POINT FROM ZERO COORDINATES :");
            Console.WriteLine("10. EXIT :");
            Console.WriteLine("ENTER THE OPTION  :");
            int option = 0;
            option = int.Parse(Console.ReadLine());
            return option;
        }
    }
}
