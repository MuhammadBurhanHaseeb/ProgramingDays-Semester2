using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using GameObject.BL;
using GameObject.DL;
using GameObject.UI;
namespace GameObject
{
    class Program
    {
        static void Main(string[] args)
        {


            GameObjectDL.addInTolist(GameObjectBL.obj1);
            GameObjectDL.addInTolist(GameObjectBL.obj2);
            while (true)
            {
                Thread.Sleep(300);
                foreach (GameObjectBL A in GameObjectDL.OBJECT)
                {
                    GameObjectUI.erase(A);
                    A.move();
                    GameObjectUI.draw(A);
                }
            }

        }

    }
    
}
