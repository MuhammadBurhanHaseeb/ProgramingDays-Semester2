using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
namespace OceanVersion2.DL
{
    class AngleDL
    {
        public static string changeFormate(ANGLE a)
        {
            string format;
            format = a.getDegree() + "\u00b0" + a.getMinute() + "'" + a.getDirection();
            return format;
        }
    }
}
