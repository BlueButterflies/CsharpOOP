using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Product
    {
        public Product(string nameProduct, double costProduct)
        {
            this.NameProduct = nameProduct;
            this.CostProduct = costProduct;
        }

        public string NameProduct { get; private set; }
        public double CostProduct { get; private set; }
    }
}
