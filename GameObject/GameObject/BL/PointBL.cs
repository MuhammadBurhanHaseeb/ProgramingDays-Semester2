using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class PointBL
    {
        public PointBL ()
        {
            x = 0;
            y = 0;
        }
        public int x;
        public int y;
      
        public PointBL(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
    }
}
