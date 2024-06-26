using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using PointOfSale.BL;
namespace PointOfSale.DL
{
    class MuserDL
    {
        public static List<MuserBL> muserList = new List<MuserBL>();

        public static void AddUserIntoList(MuserBL s)
        {
           muserList.Add(s);
        }
        public static void addIntoFile(MuserBL s)
        {
            string path = "user.txt";
            StreamWriter f = new StreamWriter(path,true);
            f.WriteLine(s.getUserName() + "," + s.getUserPassword()+","+ s.getUserRole());
            f.Flush();
            f.Close();
        }
        public static void loadUser()
        {
            string path = "user.txt";
            string record;
            StreamReader f = new StreamReader(path);
            if (File.Exists(path))
            {
                while ((record = f.ReadLine()) != null)
                {
                    string[] load = record.Split(',');
                    string name = load[0];
                    string password = load[1];
                    string  role = load[2];
                   MuserBL s = new MuserBL(name, password , role);
                   muserList.Add(s);
                }
            }
            else
            {
                Console.WriteLine("file not exists>>>");
                Console.ReadKey();
            }
            f.Close();
        }

    }
}
