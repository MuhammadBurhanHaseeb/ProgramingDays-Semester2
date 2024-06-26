using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.Core
{
   public class Game
    {
        private List<GameObject> objectsGame;
        private int gravity;
        
        public event EventHandler onAddGameObject;
        public Game(int gravity)
        {
            this.gravity = gravity;
            objectsGame = new List<GameObject>();
        }
        public void addGameObject(Image image , int top, int left,string position)
        {
            GameObject g = new GameObject(image, top, left,position);
            objectsGame.Add(g);
            onAddGameObject?.Invoke(g.P, EventArgs.Empty);

        }
        public void Update()
        {
            foreach(GameObject g in objectsGame)
            {
                g.update(gravity);
            }
        }
    }
}
