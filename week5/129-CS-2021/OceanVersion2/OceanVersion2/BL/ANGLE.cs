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
        public int degree;
        public float minute;
        public char direction;

        public string changeFormate()
            {
           string  format;
            format =  degree+"\u00b0"+minute+"'"+direction;
            return format;
            }

    }
}
