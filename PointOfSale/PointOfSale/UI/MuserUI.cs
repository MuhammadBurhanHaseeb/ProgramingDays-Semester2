using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
namespace PointOfSale.UI
{
    class MuserUI
    {
        public static MuserBL addUser()
        {
            string userNmae, userPassword, userRole;
            Console.WriteLine("enter the name of the user ");
            userNmae = Console.ReadLine();
            Console.WriteLine("enter the password  of the user ");
            userPassword = Console.ReadLine();
            Console.WriteLine("enter the role of the user ");
            userRole = Console.ReadLine();

            MuserBL s = new MuserBL(userNmae, userPassword, userRole);
            return s;
        }
    }
}
