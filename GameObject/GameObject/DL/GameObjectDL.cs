using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;
namespace GameObject.DL
{
    class GameObjectDL
    {
        public static List<GameObjectBL> OBJECT  = new List<GameObjectBL>();

        public static void addInTolist(GameObjectBL enemie)
        {
            OBJECT.Add(enemie);
        }
    }
}
