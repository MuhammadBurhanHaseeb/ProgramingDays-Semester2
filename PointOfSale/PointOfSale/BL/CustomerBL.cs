using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class CustomerBL
    {
        public CustomerBL(string customerName , List<ProductBL> customerProduct)
        {
            this.customerName = customerName;
            this.customerProduct = customerProduct;
        }

        private string customerName  ;

        private List<ProductBL> customerProduct = new List<ProductBL>();

        public string getCustomerName()
        {
            return customerName;
        }
          
        public List<ProductBL> getCustomerProduct()
         {
            return customerProduct;
        }
     
    }
}
