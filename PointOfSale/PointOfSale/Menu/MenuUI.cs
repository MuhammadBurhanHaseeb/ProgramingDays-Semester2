using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;
namespace PointOfSale.Menu
{
    class MenuUI
    {
      public static int menu()
        {
            Console.WriteLine("1. SIGN IN :");

            Console.WriteLine("2. SIGN UP :");

            Console.WriteLine("3. EXIXT :  ");

            int op;
            Console.WriteLine("enter the option :");

            op = int.Parse(Console.ReadLine());

            return op;
        }
       public  static string SignIn()
        {
            int count = 0;
            Console.WriteLine("enter the name of the user ");
            string userNmae = Console.ReadLine();
            Console.WriteLine("enter the password  of the user ");
            string userPassword = Console.ReadLine();
            MuserBL s = new MuserBL(userNmae, userPassword);
            foreach (MuserBL a in MuserDL.muserList)
            {
                if (s.getUserName() == a.getUserName() && s.getUserPassword() == a.getUserPassword())
                {
                    return a.getUserRole();
                }
                else
                {
                    count++;
                }
            }
            if (count == MuserDL.muserList.Count)
            {
                Console.WriteLine("THE USER DOES NOT EXIST >>");

            }
            Console.ReadKey();
            return null;

        }
       public  static int admin()
        {

            Console.WriteLine("1.Add the Product :");

            Console.WriteLine("2.View all product :  ");

            Console.WriteLine("3.Find product with highest unit price :");

            Console.WriteLine("4.View sale tax of all products :");

            Console.WriteLine("5.Products to be ordered :");

            Console.WriteLine("6.Exist :");
            int op;
            Console.WriteLine("enter the option :");

            op = int.Parse(Console.ReadLine());

            return op;
        }
       public  static int customer()
        {
            Console.WriteLine("1.View all product :  ");

            Console.WriteLine("2.Buy the  product :  ");

            Console.WriteLine("3.Generate the invoice  :  ");

            Console.WriteLine("4.Exist :  ");

            int op;
            Console.WriteLine("enter the option :");

            op = int.Parse(Console.ReadLine());

            return op;
        }
    }
}
