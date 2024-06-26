using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.Menu;
using PointOfSale.UI;
using PointOfSale.DL;
namespace PointOfSale
{
    class Program
    {
        static void Main(string[] args)
        {
            MuserDL.loadUser();
            ProductDL.loadProduct();
            CustomerDL.loadCustomer();
            string  op = null;
            int option = 0;
            int opp =0;

            while (true)
            {
                Console.Clear();
                opp =MenuUI.menu();
                if (opp == 1)
                {
                    op =MenuUI.SignIn();
                    while (true)
                   {
                        Console.Clear();
                        if (op == "ADMIN")
                        {
                            option =MenuUI.admin();

                            if (option == 1)
                            {
                                ProductBL s =ProductUI.addProduct();
                               ProductDL.addProductIntoList(s);
                                ProductDL.addIntoFile(s);
                            }
                            else if (option == 2)
                            {
                               ProductUI.viewAllProduct();
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("enter the category name :");
                                string categoryName = Console.ReadLine();
                                ProductUI.displayPrice(categoryName, ProductDL.highestUnitPrice(categoryName));

                            }
                            else if (option == 4)
                            {
                              ProductUI.viewSaleTax();
                            }
                            else if (option == 5)
                            {
                              ProductUI.alaramProductOrder();
                            }
                            else if (option == 6)
                            {
                                Console.WriteLine("thanks for using sale of point application ");
                                Console.ReadKey();
                                break;

                            }
                            else
                            {
                                Console.WriteLine("return i think null >>");
                                Console.ReadKey();

                            }
                        }
                        else if (op == "USER")
                        {
                            Console.Clear();
                            option =MenuUI.customer();
                            if (option == 1)
                            {
                                ProductUI.viewAllProduct();
                            }
                            else if (option == 2)
                            {
                                CustomerBL s =CustomerUI.buyProduct();
                                CustomerDL.addIntoList(s);
                                CustomerDL.addIntoFile(s);
                                
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("enter the customer name :");
                                string customerName = Console.ReadLine();
                                float price = CustomerDL.calculatePrice(customerName);
                                CustomerUI.display(price);
                            }
                            else if (option == 4)
                            {

                                Console.WriteLine("thanks for using sale of point application ");
                                Console.ReadKey();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("return i think null >>");
                                Console.ReadKey();

                            }

                        }
                    }
                }
                else if (opp == 2)
                {
                    MuserBL s =MuserUI.addUser();
                   MuserDL.AddUserIntoList(s);
                   MuserDL.addIntoFile(s);
                }
                else if (opp == 3)
                {
                    break;
                }
            }
        }
       
       
      
       
       
       
        
       
       
      
    }
}
