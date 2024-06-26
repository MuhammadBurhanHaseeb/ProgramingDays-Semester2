using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointLine.DL;

namespace PointLine.BL
{
    class MyLineBL
    {
        public MyLineBL()
        {
            this.begin = null;
            this.end = null;
        }
        public MyLineBL(MyPointBL begin , MyPointBL end )
        {
            this.begin = begin;
            this.end = end;
        }
        private   MyPointBL begin;
        private   MyPointBL end;

        public MyPointBL getBeginPoint()
        {
            return begin;
        }
        public MyPointBL getEndPoint()
        {
            return end;
        }
        public void setBeginPoint(MyPointBL begin)
        {
            this.begin = begin;
        }
        public void setEndPoint(MyPointBL end)
        {
            this.end = end;
        }
        public double getLength()
        {
            int x = end.getX() - begin.getX();
            int y = end.getY() - begin.getY();
            double a = Math.Pow(x, 2);
            double b = Math.Pow(y, 2);
            double length = a - b;
            length = Math.Sqrt(length);
            return length; 

        }
        public double getGradient()
        {
            int y = end.getY() - begin.getY();
            int x = end.getX() - begin.getX();
            return  y / x;
        }
    }
}
