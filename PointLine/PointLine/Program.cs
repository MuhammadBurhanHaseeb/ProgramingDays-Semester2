using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointLine.BL;
using PointLine.Menu;
using PointLine.UI;
using PointLine.DL;
namespace PointLine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int option =MenuUI.menuHeader();
                if (option == 1)
                {
                    MyLineDL.line = MyLineUI.makeLine();

                    //MyLineDL.addIntoVariable(l);// = MyLineUI.makeLine();
                    
                }
                else if (option ==2)
                {
                   MyLineUI.updateBeginPoint();

                }
                else if (option ==3)
                {
                  MyLineUI.updateEndPoint();

                }
                else if (option ==4)
                {
                   MyLineUI.showUpdateBeginPoint();

                }
                else if (option ==5)
                {
                   MyLineUI.showUpdateEndPoint();

                }
                else if (option ==6)
                {
                  MyLineUI.getLength();
                }
                else if (option ==7)
                {
                  MyLineUI.getGradient();
                }
                else if (option ==8)
                {
                   MyLineUI.distanceBeginToZeroPoint();
                }
                else if (option ==9)
                {
                   MyLineUI.distanceEndToZeroPoint();
                }
                else if (option ==10)
                {
                    Console.WriteLine("THANKS FOR USING THE APPLICATION OF POINT LINE >>");
                    Console.ReadKey();
                    break;

                }
                else 
                {
                    Console.WriteLine("entere the invalid option >>");
                    Console.ReadKey();

                }

            }
        }
       
       
       
       
    }
}
