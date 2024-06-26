using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLine.BL
{
    class MyPoint
    {
        public MyPoint ()
        {
            this.x = 0;
            this.y = 0;
        }
        public MyPoint(int x , int y )
        {
            this.x = x;
            this.y = y;
        }
        public int x;
        public int y;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
                 
        }
        public void setY(int y)
        {
            this.y = y ;

        }
        public void setXY(int x , int y)
        {
            this.x = x;
            this.y = y;

        }
        public double getdistanceBeginPoint(MyPoint A)
        {
            int x = A.x -0;
            int y = A.y - 0;
            double a = Math.Pow(x, 2);
            double b = Math.Pow(y, 2);
            double length = a - b;
            length = Math.Sqrt(length);
            return length;
        }
        public double getdistanceEndPoint(MyPoint A)
        {
            int x = A.x - 0;
            int y = A.y - 0;
            double a = Math.Pow(x, 2);
            double b = Math.Pow(y, 2);
            double length = a - b;
            length = Math.Sqrt(length);
            return length;
        }
    }
}
