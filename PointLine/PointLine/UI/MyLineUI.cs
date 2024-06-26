using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointLine.BL;
using PointLine.DL;
namespace PointLine.UI
{
    class MyLineUI
    {
        public static MyLineBL makeLine()
        {
            int x, y;
            Console.WriteLine("enter the point x of begin :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of begin :");
            y = int.Parse(Console.ReadLine());

            MyPointBL begin = new MyPointBL(x, y);

            Console.WriteLine("enter the point x of end  :");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the point y of end :");
            y = int.Parse(Console.ReadLine());

            MyPointBL end = new MyPointBL(x, y);

            MyLineBL line = new MyLineBL(begin, end);
            return line;

        }
        public static void updateBeginPoint()
        {
            MyPointBL s = new MyPointBL();
            MyPointBL a = MyLineDL.line.getBeginPoint();
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
            MyPointBL begin = new MyPointBL(x, y);
            MyLineDL.line.setBeginPoint(begin);
        }

        public static void updateEndPoint()
        {
            MyPointBL s = new MyPointBL();
            MyPointBL a = MyLineDL.line.getEndPoint();
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
            MyPointBL end = new MyPointBL(x, y);
            MyLineDL.line.setEndPoint(end);

        }

        public static void showUpdateBeginPoint()
        {
            Console.WriteLine("the x and y point of begin point is ({0},{1})", MyLineDL.line.getBeginPoint().getX(), MyLineDL.line.getEndPoint().getY());
            Console.ReadKey();
        }


       public  static void showUpdateEndPoint()
        {
            Console.WriteLine("the x and y point of end point is ({0},{1})", MyLineDL.line.getBeginPoint().getX(), MyLineDL.line.getEndPoint().getY());
            Console.ReadKey();

        }

        public static void getLength()
        {
            double length = MyLineDL.line.getLength();
            Console.WriteLine("the length of the line is : " + length);
            Console.ReadKey();

        }
       public   static void getGradient()
        {
            double gradient = MyLineDL.line.getGradient();
            Console.WriteLine("the gradient  of the line is : " + gradient);
            Console.ReadKey();

        }
       public  static void distanceBeginToZeroPoint()
        {
            MyPointBL s = new MyPointBL();
            MyPointBL A = MyLineDL.line.getBeginPoint();
            double distance = s.getdistanceBeginPoint(A);
            Console.WriteLine("the distace from the begin point to the orign is : " + distance);
            Console.ReadKey();

        }
       public  static void distanceEndToZeroPoint()
        {
            MyPointBL s = new MyPointBL();
            MyPointBL A = MyLineDL.line.getEndPoint();
            double distance = s.getdistanceEndPoint(A);
            Console.WriteLine("the distace from the end point to the orign is : " + distance);
            Console.ReadKey();
        }
    }
}
