using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLine.BL
{
    class MyLine
    {
        public MyLine()
        {
            this.begin = null;
            this.end = null;
        }
        public MyLine(MyPoint begin , MyPoint end )
        {
            this.begin = begin;
            this.end = end;
        }
        public   MyPoint begin;
        public   MyPoint end;
        public static MyLine line;

        public MyPoint getBeginPoint()
        {
            return line.begin;
        }
        public MyPoint getEndPoint()
        {
            return line.end;
        }
        public void setBeginPoint(MyPoint begin)
        {
            this.begin = begin;
        }
        public void setEndPoint(MyPoint end)
        {
            this.end = end;
        }
        public double getLength()
        {
            int x = end.x - begin.x;
            int y = end.y - begin.y;
            double a = Math.Pow(x, 2);
            double b = Math.Pow(y, 2);
            double length = a - b;
            length = Math.Sqrt(length);
            return length; 

        }
        public double getGradient()
        {
            int y = end.y - begin.y;
            int x = end.x - begin.x;
            return  y / x;
        }
    }
}
