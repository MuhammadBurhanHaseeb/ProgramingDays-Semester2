using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointLine.BL;
namespace PointLine
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int option = menuHeader();
                if (option == 1)
                {
                   MyLine.line =  makeLine();
                    
                }
                else if (option ==2)
                {
                    updateBeginPoint();

                }
                else if (option ==3)
                {
                    updateEndPoint();

                }
                else if (option ==4)
                {
                    showUpdateBeginPoint();

                }
                else if (option ==5)
                {
                    showUpdateEndPoint();

                }
                else if (option ==6)
                {
                    getLength();
                }
                else if (option ==7)
                {
                    getGradient();
                }
                else if (option ==8)
                {
                    distanceBeginToZeroPoint();
                }
                else if (option ==9)
                {
                    distanceEndToZeroPoint();
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
        static int menuHeader()
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
        static MyLine makeLine()
        {
            int x, y;
            Console.WriteLine("enter the point x of begin :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of begin :");
            y = int.Parse(Console.ReadLine());

            MyPoint begin = new MyPoint(x, y);

            Console.WriteLine("enter the point x of end  :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of end :");
            y = int.Parse(Console.ReadLine());

            MyPoint end  = new MyPoint(x, y);

            MyLine line = new MyLine(begin , end );
            return line;
            
        }
        static void showUpdateBeginPoint()
        {
            Console.WriteLine("the x and y point of begin point is ({0},{1})", MyLine.line.begin.x, MyLine.line.begin.y);
            Console.ReadKey();
        }
        static void updateBeginPoint()
        {
            MyPoint s = new MyPoint();
            MyPoint a = MyLine.line.getBeginPoint();
            int x, y;
            x =a.getX();
            y =a.getY();
            Console.WriteLine("enter the point x of begin :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of begin :");
            y = int.Parse(Console.ReadLine());
            a.setX(x);
            a.setY(y);
            a.setXY(x,y);
            MyPoint begin = new MyPoint(x, y);
            MyLine.line.setBeginPoint(begin);
        }
         static void updateEndPoint()
        {
            MyPoint s = new MyPoint();
            MyPoint a = MyLine.line.getEndPoint();
            int x, y;
            x = a.getX();
            y = a.getY();
            Console.WriteLine("enter the point x of begin :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of begin :");
            y = int.Parse(Console.ReadLine());
            a.setX(x);
            a.setY(y);
            a.setXY(x, y);
            MyPoint end = new MyPoint(x, y);
            MyLine.line.setEndPoint(end);
           
        }
        static void showUpdateEndPoint()
        {
            Console.WriteLine("the x and y point of end point is ({0},{1})", MyLine.line.end.x, MyLine.line.end.y);
            Console.ReadKey();

        }
        static void getLength()
        {
            double length = MyLine.line.getLength();
            Console.WriteLine("the length of the line is : " + length);
            Console.ReadKey();

        }
        static void getGradient()
        {
            double gradient = MyLine.line.getGradient();
            Console.WriteLine("the gradient  of the line is : " + gradient);
            Console.ReadKey();

        }
        static void distanceBeginToZeroPoint()
        {
            MyPoint s = new MyPoint();
            MyPoint A = MyLine.line.getBeginPoint();            
            double distance  = s.getdistanceBeginPoint(A);
            Console.WriteLine("the distace from the begin point to the orign is : " + distance);
            Console.ReadKey();

        }
        static void distanceEndToZeroPoint()
        {
            MyPoint s = new MyPoint();
            MyPoint A = MyLine.line.getEndPoint();
            double distance = s.getdistanceEndPoint(A);
            Console.WriteLine("the distace from the end point to the orign is : " + distance);
            Console.ReadKey();
        }
    }
}
