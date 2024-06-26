using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class ANGLE
    {
        public ANGLE(ANGLE s)
        {
            this.degree = s.degree;
            this.minute = s.minute;
            this.direction = s.direction;
        }
        public ANGLE (int degree , float min ,char direction)
        {
            this.degree = degree;
            this.minute = min;
            this.direction = direction;
        }
        private int degree;
        private float minute;
        private char direction;

       public int getDegree()
        {
            return degree;
        }
        public float getMinute()
        {
            return minute;
        }
        public char getDirection()
        {
            return direction;
        }

    }
}
