using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
namespace OceanNavigation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int op = 0;
            while (true)
            {
                Console.Clear();
                op = DriverMenu();
                if (op == 1)
                {
                    SHIP s = addShip();
                   SHIP.shipList.Add(s);

                }
                else if (op == 2)
                {
                    viewShipPosition(SHIP.shipList);
                }
                else if (op == 3)
                {
                    viewShipSerialNumber(SHIP.shipList);
                }
                else if (op == 4)
                {
                    changeShipPosition(SHIP.shipList);
                }
                else if (op == 5)
                {
                    break;
                }
            }

        }
        static int DriverMenu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("            UAMS               ");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1] ADD SHIP:");
            Console.WriteLine("2] VIEW SHIP POSITION :");
            Console.WriteLine("3] VIEW SHIP SERIAL NUMBER :");
            Console.WriteLine("4] CHANGE SHIP POSITION :");
            Console.WriteLine("5] EXIT:");
            Console.Write("  ENTER OPTION:");
            int option = 0;
            option = int.Parse(Console.ReadLine());
            return option;



        }

        static SHIP addShip()
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

            SHIP s = new SHIP(shipno, shipLtitude, shipLongitude);
            return s;
        }
        static void viewShipPosition(List<SHIP> shipList)
        {
            int count = 0;
            Console.WriteLine("enter the serial no of the ship which you want to  find :");
            string no = Console.ReadLine();
            foreach (SHIP s in shipList)
            {
                if (no == s.shipNumber)
                {
                    ANGLE a = new ANGLE(s.shipLatitude);
                    string latitudeFormat = a.changeFormate();

                    ANGLE b = new ANGLE(s.shipLongitude);
                    string longitudeFormat = b.changeFormate();
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
        static void viewShipSerialNumber(List<SHIP> shipList)
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
                string lat = s.shipLatitude.degree + "\u00b0" + s.shipLatitude.minute + "'" + s.shipLatitude.direction;
                string longi = s.shipLongitude.degree + "\u00b0" + s.shipLongitude.minute + "'" + s.shipLongitude.direction;
                if (a == lat && b == longi)
                {
                    Console.WriteLine("the serial no of the ship is {0} :", s.shipNumber);
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
        static void changeShipPosition(List<SHIP> shipList)
        {
            int count = 0;
            Console.WriteLine("enter the serial no of the ship which you want to  find :");
            string no = Console.ReadLine();
            foreach (SHIP s in shipList)
            {
                if (no == s.shipNumber)
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
                    s.changePosition(add);

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
