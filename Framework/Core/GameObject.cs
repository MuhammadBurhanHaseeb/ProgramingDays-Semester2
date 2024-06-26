using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
namespace Framework.Core
{
    public class GameObject
    {
        public PictureBox  P;
        private string direction;
        public GameObject(Image image, int top, int left,string positon)
        {
            P = new PictureBox();
            P.Image = image;
            P.Height = image.Height;
            P.Width = image.Width;
            P.Top = top;
            P.Left = left;
            P.BackColor = Color.Transparent;
            P.SizeMode = PictureBoxSizeMode.Zoom;

            direction = positon;

        }

       

        public void update(int gravity)
        {
            if (direction == "Vertical")
            {
                P.Top = P.Top + gravity;
            }
            else if(direction == "leftToRight")
            {
                P.Left = P.Left + gravity;
            }
            else if(direction == "Keyboard")
            {
                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    P.Left = P.Left + gravity;
                }
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    P.Left = P.Left - gravity;
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow)){
                    P.Top = P.Top - gravity;
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    P.Top = P.Top + gravity;
                }

            }
        }
    }
}
