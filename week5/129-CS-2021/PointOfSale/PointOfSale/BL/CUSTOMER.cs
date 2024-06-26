using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class CUSTOMER
    {
        public CUSTOMER(string customerName , List<PRODUCT> customerProduct)
        {
            this.customerName = customerName;
            this.customerProduct = customerProduct;
        }

        public string customerName  ;

        public   List<PRODUCT> customerProduct = new List<PRODUCT>();

        public static List<CUSTOMER> customerList = new List<CUSTOMER>();

     
    }
}
