using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
namespace PointOfSale
{
    class Program
    {
        static List<PRODUCT> customerProductList = new List<PRODUCT>();
        static void Main(string[] args)
        {

            string  op = null;
            int option = 0;
            int opp =0;

            while (true)
            {
                Console.Clear();
                opp = menu();
                if (opp == 1)
                {
                    op = SignIn();
                    while (true)
                    {
                        Console.Clear();
                        if (op == "ADMIN")
                        {
                            option = admin();

                            if (option == 1)
                            {
                                PRODUCT s = addProduct();
                                addProductIntoList(s);
                            }
                            else if (option == 2)
                            {
                                viewAllProduct();
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("enter the category name :");
                                string categoryName = Console.ReadLine();
                                highestUnitPrice(categoryName);

                            }
                            else if (option == 4)
                            {
                                viewSaleTax();
                            }
                            else if (option == 5)
                            {
                                alaramProductOrder();
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
                            option = customer();
                            if (option == 1)
                            {
                                viewAllProduct();
                            }
                            else if (option == 2)
                            {
                                CUSTOMER s = buyProduct();
                                CUSTOMER.customerList.Add(s);
                            }
                            else if (option == 3)
                            {
                                Console.WriteLine("enter the customer name :");
                                string customerName = Console.ReadLine();
                                calculatePrice(customerName);
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
                    MUSER s = addUser();
                    AddUserIntoList(s);
                }
                else if (opp == 3)
                {
                    break;
                }
            }
        }
        static int menu()
        {
            Console.WriteLine("1. SIGN IN :");

            Console.WriteLine("2. SIGN UP :");

            Console.WriteLine("3. EXIXT :  ");

            int op;
            Console.WriteLine("enter the option :");

            op = int.Parse(Console.ReadLine());

            return op;
        }
        static string SignIn()
        {
            int count = 0;
            Console.WriteLine("enter the name of the user ");
            string userNmae = Console.ReadLine();
            Console.WriteLine("enter the password  of the user ");
            string userPassword = Console.ReadLine();
            MUSER s = new MUSER(userNmae , userPassword);
            foreach (MUSER a in MUSER.muserList)
            {
                if (s.userName == a.userName && s.userPassword == a.userPassword)
                {
                    return a.userRole;
                }
                else
                {
                    count++;
                }
            }
            if (count == MUSER.muserList.Count)
            {
                Console.WriteLine("THE USER DOES NOT EXIST >>");

            }
            Console.ReadKey();
            return null; 

        }
        static int admin()
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
        static int customer()
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
        static MUSER addUser()
        {
            string userNmae, userPassword, userRole;
            Console.WriteLine("enter the name of the user ");
             userNmae = Console.ReadLine();
            Console.WriteLine("enter the password  of the user ");
             userPassword = Console.ReadLine();
            Console.WriteLine("enter the role of the user ");
             userRole = Console.ReadLine();

            MUSER s = new MUSER(userNmae, userPassword , userRole);
            return s;
        }
        static void AddUserIntoList(MUSER s)
        {
            MUSER.muserList.Add(s);
        }
        static PRODUCT addProduct()
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
            thresholdQuantity= int.Parse(Console.ReadLine());
            PRODUCT s = new PRODUCT(name , category , price , quantity , thresholdQuantity);
            return s;
        }
        static void addProductIntoList(PRODUCT s)
        {
            PRODUCT.productList.Add(s);
        }
        static void viewAllProduct()
        {
            Console.WriteLine("product name\tproduct category\tproduct price\tproduct quantity\tproduct threshold quantity ");
            foreach(PRODUCT s in PRODUCT.productList)
            {
                Console.WriteLine(s.productName +"\t"+s.productCategory +"\t"+s.productPrice+"\t"+s.productQuantity+"\t"+s.thresholdproductQuantity);
            }
            Console.ReadKey();
        }
        static void viewSaleTax()
        {
            Console.WriteLine("ON ALL  GROCERY PRODUCTS SALE TAX IS  :: 10 %");

            Console.WriteLine("ON ALL FRUIT TYPE THE SALE TAX IS  :: 5 % ");

            Console.WriteLine("OR OTHER TYPE OF THE PRODUCT SALE TAX IS  :: 15 %");

            Console.ReadKey();

        }
        static void alaramProductOrder()
        {
            foreach (PRODUCT s in PRODUCT.productList)
            {
                if (s.productQuantity <= s.thresholdproductQuantity )
                {
                    Console.WriteLine("you have to add the product which name is ::" + s.productName + "and product category is "+ s.productCategory);
                }
            }
            Console.ReadKey();
        }
        static void highestUnitPrice(string categoryName)
        {
            int price = 0;
            string name = null;
            foreach(PRODUCT s in PRODUCT.productList)
            {
                if (categoryName == s.productCategory)
                {
                    if ( price < s.productPrice )
                    {
                      price = s.productPrice;
                        name = s.productName;
                    }
                }
            }
            Console.WriteLine("the highest unit price is {0} and it name is {1} and it category is {2} ", price ,name , categoryName );
            Console.ReadKey();
        }
        static CUSTOMER buyProduct()
        {
            string customerName;
            Console.WriteLine("ENTRE THE NAME OF THE CUSTOMER");
            customerName = Console.ReadLine();
            int no;
            Console.WriteLine("how many product you want to buy : ");
            no = int.Parse(Console.ReadLine());
            for (int x = 0; x< no; x++)
            {
                PRODUCT add =  addCustomerProduct();
                if (add != null)
                {
                    customerProductList.Add(add);
                }
            }
            CUSTOMER s = new CUSTOMER(customerName , customerProductList);
            return s;
        }
        static PRODUCT addCustomerProduct()
        {
            Console.WriteLine("enter the produc name ");
            string name = Console.ReadLine();
           
            foreach (PRODUCT s in PRODUCT.productList)
            {
                if (name == s.productName)
                {
                    Console.WriteLine("enter the produc quantity : ");
                    int quantity = int.Parse(Console.ReadLine());
                    if (quantity <= s.productQuantity)
                    {
                        string Category = s.productCategory;
                        int Price = s.productPrice;
                        s.productQuantity = s.productQuantity - quantity;
                        PRODUCT a = new PRODUCT(name, Category, Price, quantity);
                        return a;
                    }
                    else
                    {
                        Console.WriteLine("product is not enough   >>");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("product not find >>");
                    Console.ReadKey();
                }
            }
            return null;
        }
        static void calculatePrice(string customerName)
        {
            float price = 0;
            float discount = 0; 
            foreach(CUSTOMER s in CUSTOMER.customerList)
            {
                if (customerName == s.customerName)
                {
                    for(int x = 0; x < s.customerProduct.Count; x++)
                    {
                        if (s.customerProduct[x].productCategory == "fruit")
                        {
                            price = price + s.customerProduct[x].productPrice;
                            price = price * s.customerProduct[x].productQuantity;
                            discount = (price * (5 / 100.0F));
                            price = price - discount;
                        }
                        else if (s.customerProduct[x].productCategory == "grocery")
                        {
                            price = price + s.customerProduct[x].productPrice;
                            price = price * s.customerProduct[x].productQuantity;
                            discount = (price * (10 / 100.0F));
                            price = price - discount;
                        }
                        else 
                        {
                            price = price + s.customerProduct[x].productPrice;
                            price = price * s.customerProduct[x].productQuantity;
                            discount = (price * (15 / 100.0F));
                            price = price - discount;
                        }

                    }
                }
            }

            Console.WriteLine("the price of the product after the sale tax  : " + price);
            Console.ReadKey();
        }
    }
}
