using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMSversion.Menu
{
    class MenuUI
    {
        public static int header()
        {
            Console.WriteLine("*********************************************");
            Console.WriteLine("                   UAMS                      ");
            Console.WriteLine("*********************************************");
            Console.WriteLine("1. Add the student :");
            Console.WriteLine("2. Add the degree program : ");
            Console.WriteLine("3. Generate the merit :");
            Console.WriteLine("4. view the registered student  :");
            Console.WriteLine("5. view student of the specific program :");
            Console.WriteLine("6. Register subjects for the specific student : ");
            Console.WriteLine("7. Calculate fees for all registered students :");
            Console.WriteLine("8. Logut this UAMS Application :");
            int op;
            Console.WriteLine("enter the option:");
            op = int.Parse(Console.ReadLine());
            return op;



        }
    }
}
