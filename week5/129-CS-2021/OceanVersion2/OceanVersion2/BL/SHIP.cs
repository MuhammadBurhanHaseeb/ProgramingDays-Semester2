using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class SHIP
    {
        public static List<SHIP> shipList = new List<SHIP>();
        public SHIP(string shipno,ANGLE latitude  , ANGLE longitude )
        {
            shipNumber  = shipno;
            shipLatitude = latitude;
            shipLongitude = longitude;

        }
       /* public void addFormat(string a , string b)
        {
            shipLatitude = a;
            shipLongitude = b;
        }*/
        public string shipNumber;
        public ANGLE shipLatitude;
        public ANGLE shipLongitude;

        public void changePosition(SHIP s)
        {
            shipNumber = s.shipNumber;
            shipLatitude = s.shipLatitude;
            shipLongitude = s.shipLongitude;
        }

    }
}
