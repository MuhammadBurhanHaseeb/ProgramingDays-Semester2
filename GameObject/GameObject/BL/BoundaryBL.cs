using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class BoundaryBL
    {
        public BoundaryBL(PointBL topLeft , PointBL topRight , PointBL bottomLeft , PointBL bottomRight  )
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }
        public PointBL topLeft;
        public PointBL topRight;
        public PointBL bottomLeft;
        public PointBL bottomRight;
    }
}
