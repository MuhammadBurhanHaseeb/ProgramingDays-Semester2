using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Challenge1
{
    public partial class n: UserControl
    {
        private string DataList = "";
        public n()
        {
            InitializeComponent();
        }

        public string DataList1 { get => DataList; set => DataList = value; }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb.Text = cb1.Text;
            DataList = cb1.Text;
            MessageBox.Show(DataList);
        }
    }
}
