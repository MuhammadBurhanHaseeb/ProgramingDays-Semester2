using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanVersion2.Menu
{
    class MenuUI
    {
        public static int DriverMenu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            SHIP              ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1] ADD SHIP:");
            Console.WriteLine("2] VIEW SHIP POSITION :");
            Console.WriteLine("3] VIEW SHIP SERIAL NUMBER :");
            Console.WriteLine("4] CHANGE SHIP POSITION :");
            Console.WriteLine("5] EXIT:");
            Console.Write("  ENTER OPTION:");
            int option = 0;
            option = int.Parse(Console.ReadLine());
            return option;



        }
    }
}
