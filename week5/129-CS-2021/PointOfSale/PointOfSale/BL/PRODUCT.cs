using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class PRODUCT
    {
        public PRODUCT(string prductNmae , string ProductCategory , int productPrice , int productQuantity)
        {
            this.productName = prductNmae;
            this.productCategory = ProductCategory;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
        public PRODUCT(string productName, string productCategory, int productPrice, int productQuantity, int thresholdproductQuantity)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
            this.thresholdproductQuantity = thresholdproductQuantity;
        }
        public string productName;
        public string productCategory;
        public int productPrice;
        public int productQuantity;
        public int thresholdproductQuantity;
        public static List<PRODUCT> productList = new List<PRODUCT>();
    }
}
