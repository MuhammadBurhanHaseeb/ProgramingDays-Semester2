using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Core;
namespace consumer
{
    public partial class Form1 : Form
    {
        private Game g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            g = new Game(5);
            g.onAddGameObject += new EventHandler(addInControl);
            g.addGameObject(Properties.Resources.playerShip, 20, 20, "Keyboard");
            g.addGameObject(Properties.Resources.meteorBrown, 20, 100, "Vertical");
            g.addGameObject(Properties.Resources.meteorBrown, 20, 100, "leftToRight");




        }

        private void addInControl(object sender, EventArgs e)
        {
            this.Controls.Add((PictureBox)sender);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g.Update();
        }
    }
}
