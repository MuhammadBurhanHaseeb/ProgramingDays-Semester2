using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    class GameObject
    {
        public GameObject(char[,] shape , Point startingPoint , Boundary premises ,string direction )
        {
            this.shape = shape;
            this.startingPoint = startingPoint;
            this.premises = premises;
            this.direction = direction;
        }
        public char[,] shape ;
        public Point startingPoint;
        public Boundary premises;
        public string direction;
    }
}
