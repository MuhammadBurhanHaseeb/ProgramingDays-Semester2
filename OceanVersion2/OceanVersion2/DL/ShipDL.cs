using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using System.IO;
namespace OceanVersion2.DL
{
    class ShipDL
    {
        public static List<SHIP> shipList = new List<SHIP>();

        public static void addIntoList(SHIP s)
        {
            shipList.Add(s);
        }
        public static void loadShip()
        {
            string path = "ship.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string shipNo = load[0];
                    int latitudeDegree =int.Parse( load[1]);
                    float latitudeMinute = float.Parse(load[2]);
                    char latitudeDirection = char.Parse(load[3]);
                    ANGLE latitude = new ANGLE(latitudeDegree, latitudeMinute, latitudeDirection);
                    int longitudeDegree = int.Parse(load[4]);
                    float longitudeMinute = float.Parse(load[5]);
                    char longitudeDirection = char.Parse(load[6]);
                    ANGLE longitude = new ANGLE(longitudeDegree, longitudeMinute, longitudeDirection);
                    string role = load[2];
                    SHIP s = new SHIP(shipNo, latitude, longitude);
                    ShipDL.shipList.Add(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }
        public static void addIntoFile(SHIP s)
        {
            string path = "ship.txt";
            StreamWriter f = new StreamWriter(path,true);
            f.WriteLine(s.getShipNumber() + "," + s.getShipLatitude().getDegree() + "," + s.getShipLatitude().getMinute() + "," + s.getShipLatitude().getDirection() + "," + s.getShipLongitude().getDegree() + "," + s.getShipLongitude().getMinute()+","+s.getShipLongitude().getDirection());
            f.Flush();
            f.Close();
        }

        public static void changePosition(SHIP s , SHIP a)
        {
            string shipNumber = a.getShipNumber();
            s.setShipNumber(shipNumber);
            ANGLE shipLatitude = a.getShipLatitude();
            s.setShipLatitude(shipLatitude);
            ANGLE shipLongitude = a.getShipLongitude();
            s.setShipLongitude(shipLongitude);
        }

    }
}
