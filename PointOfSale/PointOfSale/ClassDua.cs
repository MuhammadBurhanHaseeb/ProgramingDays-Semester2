using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale
{
    public partial class ClassDua : Component
    {
        public ClassDua()
        {
            InitializeComponent();
        }

        public ClassDua(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
