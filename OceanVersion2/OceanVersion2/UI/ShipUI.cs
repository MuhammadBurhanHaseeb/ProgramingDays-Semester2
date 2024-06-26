using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanVersion2.DL;
namespace OceanVersion2.UI
{
    class ShipUI
    {
        public static SHIP addShip()
        {
            string shipno;
            char latitudeDirection, longitudeDirection;
            int latDegree, longDegree;
            float latMinute, longMinute;
            Console.WriteLine("Enter the ship number :");
            shipno = Console.ReadLine();
            Console.WriteLine("Enter the ship Latitude :");
            Console.WriteLine("Enter the Latitud Degre :");
            latDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Minute :");
            latMinute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Latitude Direction :");
            latitudeDirection = char.Parse(Console.ReadLine());
            ANGLE shipLtitude = new ANGLE(latDegree, latMinute, latitudeDirection);
            Console.WriteLine("Enter the ship Longitude :");
            Console.WriteLine("Enter the Longitude Degre :");
            longDegree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Minute :");
            longMinute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Longitude Direction :");
            longitudeDirection = char.Parse(Console.ReadLine());
            ANGLE shipLongitude = new ANGLE(longDegree,longMinute,longitudeDirection);

            SHIP s = new SHIP(shipno, shipLtitude, shipLongitude);
            return s;
        }
        public static void viewShipPosition(List<SHIP> shipList)
        {
            int count = 0;
            Console.WriteLine("enter the serial no of the ship which you want to  find :");
            string no = Console.ReadLine();
            foreach (SHIP s in shipList)
            {
                if (no == s.getShipNumber())
                {
                    ANGLE a = new ANGLE(s.getShipLatitude());
                    string latitudeFormat =AngleDL.changeFormate(a);

                    ANGLE b = new ANGLE(s.getShipLongitude());
                    string longitudeFormat = AngleDL.changeFormate(b);
                    // s.addFormat(latitudeFormat, longitudeFormat);
                    Console.WriteLine("Ship is at {0} and {1}", latitudeFormat, longitudeFormat);

                }
                else
                {
                    count++;
                }
            }
            if (count == shipList.Count)
            {
                Console.WriteLine("the ship is not find :");


            }
            Console.ReadKey();
        }
        public static void viewShipSerialNumber(List<SHIP> shipList)
        {
            int count = 0;
            Console.WriteLine("enter the ship latitude  no :");
            string a1 = Console.ReadLine();
            string a2 = Console.ReadLine();
            string a3 = Console.ReadLine();
            string a = a1 + "\u00b0" + a2 + "'" + a3;
            Console.WriteLine("enter the ship longitude  no :");
            string b1 = Console.ReadLine();
            string b2 = Console.ReadLine();
            string b3 = Console.ReadLine();
            string b = b1 + "\u00b0" + b2 + "'" + b3;
            foreach (SHIP s in shipList)
            {
                string lat = s.getShipLatitude().getDegree() + "\u00b0" + s.getShipLatitude().getMinute() + "'" + s.getShipLatitude().getDirection();
                string longi = s.getShipLongitude().getDegree() + "\u00b0" + s.getShipLongitude().getMinute() + "'" + s.getShipLongitude().getDirection();
                if (a == lat && b == longi)
                {
                    Console.WriteLine("the serial no of the ship is {0} :", s.getShipNumber());
                }
                else
                {
                    count++;
                }
            }
            if (count == shipList.Count)
            {
                Console.WriteLine("thw ship not find in record :");
            }
            Console.ReadKey();
        }
        public static void changeShipPosition(List<SHIP> shipList)
        {
            int count = 0;
            Console.WriteLine("enter the serial no of the ship which you want to  find :");
            string no = Console.ReadLine();
            foreach (SHIP s in shipList)
            {
                if (no == s.getShipNumber())
                {
                    string shipno;
                    char latitudeDirection, longitudeDirection;
                    int latDegree, longDegree;
                    float latMinute, longMinute;
                    Console.WriteLine("Enter the ship number :");
                    shipno = Console.ReadLine();
                    Console.WriteLine("Enter the ship Latitude :");
                    Console.WriteLine("Enter the Latitud Degre :");
                    latDegree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Latitude Minute :");
                    latMinute = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Latitude Direction :");
                    latitudeDirection = char.Parse(Console.ReadLine());
                    ANGLE shipLtitude = new ANGLE(latDegree, latMinute, latitudeDirection);
                    Console.WriteLine("Enter the ship Longitude :");
                    Console.WriteLine("Enter the Longitude Degre :");
                    longDegree = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Longitude Minute :");
                    longMinute = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Longitude Direction :");
                    longitudeDirection = char.Parse(Console.ReadLine());
                    ANGLE shipLongitude = new ANGLE(longDegree, longMinute, longitudeDirection);

                    SHIP add = new SHIP(shipno, shipLtitude, shipLongitude);
                     ShipDL.changePosition(s,add);

                }
                else
                {
                    count++;
                }
            }
            if (count == shipList.Count)
            {
                Console.WriteLine("the ship not fount :");
            }
            Console.ReadKey();
        }
    }
}
