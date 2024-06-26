using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class GameObjectBL
    {
        public GameObjectBL(char[,] shape , PointBL startingPoint  ,string direction, BoundaryBL premises)
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.direction = direction;
            this.premises = premises;
        }
        public char[,] shape ;
        public PointBL startingPoint;
        public BoundaryBL premises;
        public string direction;
        int count = 0;
        bool changeDirection = false;


        public static char[,] triangle = new char[5, 3] { { ' ', ' ', ' ' }, { '*', '*', ' ' }, { '*', '*', '*' }, { '*', '*', ' ' }, { ' ', ' ', ' ' } };
        public static char[,] opTriangle = new char[5, 3] { { ' ', ' ', ' ' },{ ' ', '*', '*' },{ '*', '*', '*' },{ ' ', '*', '*' },{ ' ', ' ', ' ' } };

        public static BoundaryBL boundary = new BoundaryBL(new PointBL(0, 0), new PointBL(0, 90), new PointBL(30, 0), new PointBL(30, 90));

        public static GameObjectBL obj1 = new GameObjectBL(triangle, new PointBL(5, 5), "patrol", boundary);
        public static GameObjectBL obj2 = new GameObjectBL(opTriangle, new PointBL(30, 0), "projectile", boundary);
        public void move()
        {
            if (direction == "leftToRight")
            {
                if (startingPoint.y < premises.topRight.y)
                {
                    startingPoint.y = startingPoint.y + 1;
                }
            }
            else if (direction == "rightToLeft")
            {
                if (startingPoint.y > premises.topLeft.y)
                {
                    startingPoint.y = startingPoint.y - 1;
                }
            }
            else if (direction == "topToBottom")
            {
                if (startingPoint.x < premises.bottomLeft.x)
                {
                    startingPoint.x = startingPoint.x + 1;
                }
            }
            else if (direction == "bottomToTop")
            {
                if (startingPoint.x > premises.topLeft.x)
                {
                    startingPoint.x = startingPoint.x - 1;
                }
            }
            else if (direction == "patrol")
            {
                if (changeDirection == false)
                {
                    if (startingPoint.y <= premises.bottomRight.y)
                    {
                        startingPoint.y = startingPoint.y + 1;
                    }
                    else
                    {
                        changeDirection = true;
                    }
                }
                else if (changeDirection == true)
                {
                    if (startingPoint.y >= premises.topLeft.y)
                    {
                        startingPoint.y = startingPoint.y- 1;
                    }
                    else
                    {
                        changeDirection = false;
                    }
                }
            }
            else if (direction == "projectile")
            {
                if (startingPoint.y < premises.topRight.y)

                {
                    if (startingPoint.x <= premises.bottomLeft.x)
                    {
                        if (count <= 9)
                        {
                            startingPoint.x = startingPoint.x - 2;
                            startingPoint.y = startingPoint.y + 4;
                            count++;
                        }
                        else if (count <= 17)
                        {
                            startingPoint.y = startingPoint.y + 1;
                            count++;
                        }
                        else if (count > 18)
                        {
                            startingPoint.x = startingPoint.x + 1;
                            startingPoint.y = startingPoint.y + 3;
                        }
                    }
                }
            }
        }

    }
}
