using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class Boundary
    {
        public Boundary(Point topLeft , Point topRight , Point bottomLeft , Point bottomRight  )
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
        public Point topLeft;
        public Point topRight;
        public Point bottomLeft;
        public Point bottomRight;
    }
}
