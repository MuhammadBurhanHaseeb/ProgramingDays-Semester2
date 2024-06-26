using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PointOfSaleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] roles = new string[5];
            string[] names = new string[5];
            string[] pass = new string[5];
            int usersCount = 0;

            string[] product = new string[5];
            int[] price = new int[5];
            int[] quantity = new int[5];
            int productCount = 0;

            string[] buyProduct = new string[5];
            int[] buyProductQuantity = new int[5];
            int[] buyProductPrice = new int[5];
            int buyProductCount = 0;

            char choice;
            string inventoryPath = "inventory.txt";
            string usersPath = "users.txt";

            readUserData(usersPath, names, pass, roles, ref usersCount);
            readProductData(inventoryPath, product, price, quantity, ref productCount);
            
            do
            {
                choice = menu();
                clearScreen();
                if (choice == '1')
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    string who = logIn(n, p, names, pass, roles, usersCount);
                    
                    if (who == "admin")
                    {
                        char adminOption;
                        do
                        {
                            clearScreen();
                            adminOption = admin_menu();
                            clearScreen();
                            if (adminOption == '1')
                            {
                                Console.WriteLine("Enter Name: ");
                                string newUser = Console.ReadLine();
                                Console.WriteLine("Enter Password: ");
                                string newPass = Console.ReadLine();
                                Console.WriteLine("Enter Role: ");
                                string newRole = Console.ReadLine();
                                addUser(newUser, newPass, newRole, names, pass, roles, ref usersCount);
                            }
                            else if (adminOption == '2')
                            {
                                Console.WriteLine("Enter Product Name: ");
                                string newProduct = Console.ReadLine();
                                Console.WriteLine("Enter Price: ");
                                int newPrice = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Quantity: ");
                                int newQuantity = int.Parse(Console.ReadLine());
                                addItem(newProduct, newPrice, newQuantity, product, price, quantity, ref productCount);
                            }
                            else if (adminOption == '3')
                            {
                                viewProducts(product, price, quantity, productCount);
                                Console.WriteLine("Enter Product Name you want to Update: ");
                                string newProduct = Console.ReadLine();
                                updateItem(newProduct, product, price, quantity, ref productCount);
                            }
                            else if (adminOption == '4')
                            {
                                viewProducts(product, price, quantity, productCount);
                                Console.WriteLine("Enter Product Name you want to Delete: ");
                                string newProduct = Console.ReadLine();
                                deleteItem(newProduct, product, price, quantity, ref productCount);
                            }
                        }
                        while (adminOption != '5');
                        clearScreen();

                    }
                    else if (who == "customer")
                    {
                        char userOption;
                        do
                        {
                            userOption = user_menu();
                            clearScreen();
                            if (userOption == '1')
                            {
                                viewProducts(product, price, quantity, productCount);
                                Console.WriteLine("Enter the Product you want to Buy");
                                buyProduct[buyProductCount] = Console.ReadLine();
                                Console.WriteLine("Enter the quantity you want to Buy");
                                buyProductQuantity[buyProductCount] = int.Parse(Console.ReadLine());
                                for (int x = 0; x < productCount; x++)
                                {
                                    if (buyProduct[buyProductCount] == product[x])
                                    {
                                        Console.WriteLine("Product Available");
                                        if (buyProductQuantity[buyProductCount] < quantity[x])
                                        {
                                            Console.WriteLine("Quantity also Available");
                                            buyProductPrice[buyProductCount] = buyProductQuantity[buyProductCount] * price[x];
                                            quantity[x] = quantity[x] - buyProductQuantity[buyProductCount];
                                            buyProductCount = buyProductCount + 1;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Quantity not Available");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Product Not Available");
                                    }
                                }
                                
                            }
                            else if (userOption == '2')
                            {
                                int total = 0;
                                viewProducts(buyProduct, buyProductPrice, buyProductQuantity, buyProductCount);
                                for (int x = 0; x < buyProductCount; x++)
                                {
                                    total = total + buyProductPrice[x];
                                }
                                Console.WriteLine("Total Price: " + total);
                            }
                            clearScreen();
                        }
                        while (userOption != '3');
                    }
                    else
                    {
                        Console.WriteLine("Invalid User");
                        clearScreen();
                    }
                }
                saveUserData(usersPath,names,pass,roles, usersCount);
                saveProductData(inventoryPath, product,price,quantity, productCount);
            } while (choice != '2');
           
        }


        static void saveUserData(string usersPath , string[] names, string[] pass, string[] roles, int usersCount)
        {
            StreamWriter f1 = new StreamWriter(usersPath, false);
            for (int x = 0; x < usersCount; x++)
            {
                f1.WriteLine(names[x] + "," + pass[x] + "," + roles[x]);
            }
            f1.Flush();
            f1.Close();
        }

        static void saveProductData(string inventoryPath, string[] product, int[] price, int[] quantity, int productCount)
        {
            StreamWriter f1 = new StreamWriter(inventoryPath, false);
            for (int x = 0; x < productCount; x++)
            {
                f1.WriteLine(product[x] + "," + price[x] + "," + quantity[x]);
            }
            f1.Flush();
            f1.Close();
        }


        static void viewProducts(string[] product, int[] price, int[] quantity, int productCount)
        {
            Console.WriteLine("Product\t\tPrice\t\tQuantity");
            for (int x = 0; x < productCount; x++)
            {
                Console.WriteLine(product[x] + "\t\t" + price[x] + "\t\t" + quantity[x]);
            }
        }


        // update an item
        static void updateItem(string newProduct, string[] product, int [] price, int [] quantity, ref int productCount)
        {
            int idx = findProduct(newProduct, product, productCount);
            if (idx >= 0 && idx <= 4)
            {
                Console.WriteLine("Product Found");
                Console.WriteLine("Enter the Updated price");
                int newPrice = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Updated Quantity: ");
                int newQuantity = int.Parse(Console.ReadLine());
                price[idx] = newPrice;
                quantity[idx] = newQuantity;
            }
            else
            {
                clearScreen();
                Console.WriteLine("Product Does Not Exists.");
            }
        }


        static void deleteItem(string newProduct, string[] product, int[] price, int[] quantity, ref int productCount)
        {
            int idx = findProduct(newProduct, product, productCount);
            if (idx >= 0 && idx <= 4)
            {
                Console.WriteLine("Product Found");
                for (int x = idx; x < productCount - 1; x++)
                {
                    product[x] = product[x + 1];
                    price[x] = price[x + 1];
                    quantity[x] = quantity[x + 1];
                }
                productCount = productCount - 1;
            }
        }


        static int findProduct(string newProduct, string[] product, int productCount)
        {
            for (int x = 0; x < productCount; x++)
            {
                if (newProduct == product[x])
                {
                    return x;
                }
            }
            return -1;
        }



        // add an item
        static void addItem(string newProduct, int newPrice, int newQuantity, string [] product, int[] price, int[] quantity, ref int productCount)
        {
            if (productCount <= 4)
            {
                product[productCount] = newProduct;
                price[productCount] = newPrice;
                quantity[productCount] = newQuantity;
                productCount = productCount + 1;
            }
        }


        
    
        // separating credentials for storing in arrays individually
        static string parseData(string record, int field)
        {
            int comma = 1;
            string item = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if (comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }


        // reading user file for storing data in arrays
        static void readUserData(string usersPath, string[] names, string[] pass, string[] roles, ref int usersCount)
        {
            StreamReader fp = new StreamReader(usersPath);
            string record;
            while ((record = fp.ReadLine()) != null)
            {
                if (usersCount > 4)
                {
                    break;
                }
                names[usersCount] = parseData(record, 1);
                pass[usersCount] = parseData(record, 2);
                roles[usersCount] = parseData(record, 3);
                usersCount = usersCount + 1;
            }
            fp.Close();
        }


        // reading product file for storing data in arrays
        static void readProductData(string inventoryPath, string[] product, int[] price, int[] quantity, ref int productCount)
        {
            StreamReader fp = new StreamReader(inventoryPath);
            string record;
            while ((record = fp.ReadLine()) != null)
            {
                if (productCount > 4)
                {
                    break;
                }
                product[productCount] = parseData(record, 1);
                price[productCount] = int.Parse(parseData(record, 2));
                quantity[productCount] = int.Parse(parseData(record, 3));
                productCount = productCount + 1;
            }
            fp.Close();
        }


        //adding data of Users into user Arrays
        static void addUser(string newUser, string newPass, string newRole, string[] names, string[] pass, string[] roles, ref int usersCount)
        {
            if (newRole == "admin" || newRole == "customer")
            {
                if (usersCount <= 4)
                {
                    names[usersCount] = newUser;
                    pass[usersCount] = newPass;
                    roles[usersCount] = newRole;
                    usersCount = usersCount + 1;
                }
                else
                {
                    clearScreen();
                    Console.WriteLine("User Limit Exceeded.");
                }
            }
            else
            {
                clearScreen();
                Console.WriteLine("Invalid User type");
            }
        }


        // implementing login feature for admin and users
        static string logIn(string n, string p, string[] names, string[] pass, string[] roles, int usersCount)
        {
            string user_role;
            for (int x = 0; x < usersCount; x++)
            {
                if (n == names[x] && p == pass[x])
                {
                    user_role = roles[x];
                    return user_role;
                }
            }
            return "Wrong User";

        }

        static char menu()
        {
            char op;
            Console.WriteLine("Press 1 to Login:");
            Console.WriteLine("Press 2 to Exit:");
            Console.Write("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }


        // admin menu
        static char admin_menu()
        {
            Console.Clear();
            char op;
            Console.WriteLine("Press 1 to Add User");
            Console.WriteLine("Press 2 to Add a New item:");
            Console.WriteLine("Press 3 to Update an Exisitng item: ");
            Console.WriteLine("Press 4 to Delete an Exisitng item:");
            Console.WriteLine("Press 5 to Exit: ");
            Console.WriteLine("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }


        // user menu
        static char user_menu()
        {
            Console.Clear();
            Char op;
            Console.WriteLine("Press 1 to Buy an item: ");
            Console.WriteLine("Press 2 to view the cart: ");
            Console.WriteLine("Press 3 to Exit: ");
            Console.WriteLine("Enter Option: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }

        static void clearScreen()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
