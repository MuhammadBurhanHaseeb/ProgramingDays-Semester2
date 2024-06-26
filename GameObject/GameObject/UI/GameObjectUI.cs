using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.BL;
namespace GameObject.UI
{
    class GameObjectUI
    {
        public static void erase(GameObjectBL obj)
        {
            for (int i = 0; i < obj.shape.GetLength(0); i++)
            {
                for (int j = 0; j < obj.shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(obj.startingPoint.y + j, obj.startingPoint.x + i);
                    Console.Write(" ");
                }
            }
        }
        public static void draw(GameObjectBL obj)
        {
            for (int i = 0; i < obj.shape.GetLength(0); i++)
            {
                for (int j = 0; j < obj.shape.GetLength(1); j++)
                {
                    Console.SetCursorPosition(obj.startingPoint.y + j, obj.startingPoint.x + i);
                    Console.WriteLine(obj.shape[i, j]);
                }
                // Console.WriteLine();
            }
        }
    }
}
