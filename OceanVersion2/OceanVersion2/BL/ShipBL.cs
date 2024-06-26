using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    class SHIP
    {
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
        private string shipNumber;
        private ANGLE shipLatitude;
        private ANGLE shipLongitude;

      /*  public void changePosition(SHIP s, SHIP a)
        {
            s.shipNumber = a.shipNumber;
            s.shipLatitude = a.shipLatitude;
            s.shipLongitude = a.shipLongitude;
        }*/

        public string getShipNumber()
        {
            return shipNumber;
        }
        public ANGLE getShipLatitude()
        {
            return shipLatitude;
        }
        public ANGLE getShipLongitude()
        {
            return shipLongitude;
        }
        public void setShipNumber(string shipNumber)
        {
            this. shipNumber = shipNumber;
        }
        public void setShipLatitude(ANGLE shipLatitude)
        {
            this.shipLatitude = shipLatitude ;
        }
        public void setShipLongitude(ANGLE shipLongitude)
        {
            this. shipLongitude =shipLongitude;
        }
    }
}
