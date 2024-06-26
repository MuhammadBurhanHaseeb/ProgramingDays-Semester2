using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanVersion2.Menu;
using OceanVersion2.UI;
using OceanVersion2.DL;
namespace OceanNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
            ShipDL.loadShip();
           
            int op = 0;
            while (true)
            {
                Console.Clear();
                op =MenuUI.DriverMenu();
                if (op == 1)
                {
                    SHIP s =ShipUI.addShip();
                    ShipDL.addIntoList(s);
                    ShipDL.addIntoFile(s);

                }
                else if (op == 2)
                {
                   ShipUI.viewShipPosition(ShipDL.shipList);
                }
                else if (op == 3)
                {
                   ShipUI.viewShipSerialNumber(ShipDL.shipList);
                }
                else if (op == 4)
                {
                   ShipUI.changeShipPosition(ShipDL.shipList);
                }
                else if (op == 5)
                {
                    break;
                }
            }

        }
        

       
       
      
       
    }
}
