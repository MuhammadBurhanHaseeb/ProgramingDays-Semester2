using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    class ProductBL
    {
        public ProductBL(string prductNmae , string ProductCategory , int productPrice , int productQuantity)
        {
            this.productName = prductNmae;
            this.productCategory = ProductCategory;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
        }
        public ProductBL(string productName, string productCategory, int productPrice, int productQuantity, int thresholdproductQuantity)
        {
            this.productName = productName;
            this.productCategory = productCategory;
            this.productPrice = productPrice;
            this.productQuantity = productQuantity;
            this.thresholdproductQuantity = thresholdproductQuantity;
        }
        private string productName;
        private string productCategory;
        private int productPrice;
        private int productQuantity;
        private int thresholdproductQuantity;

        public int getProductPrice()
        {
            return productPrice;
        }
        public string getProductName()
        {
            return productName;
        }
        public string  getProductCategory()
        {
            return productCategory;
        }
        public int getProductQuantity()
        {
            return productQuantity;
        }
        public int getThresholdProductQuantity()
        {
            return thresholdproductQuantity;
        }
        public void setProductQuantity(int productQuantity)
        {
            this.productQuantity = productQuantity;
        }
      
    }
   
}
