using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge2
{
    public partial class UserControl1: UserControl
    {
        private Muser dataList;

        public UserControl1()
        {
            InitializeComponent();
        }

        internal Muser DataList { get => dataList; set => dataList = value; }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
