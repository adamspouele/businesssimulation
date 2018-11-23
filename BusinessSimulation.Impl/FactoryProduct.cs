using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Model
{
    public class FactoryProduct : AbstractFactoryProduct
    {
        private static Random _random = new Random();

        protected FactoryProduct()
        {
        }

        public IProduct CreateNew(int priceRange = 100, Vat vat = null)
        {
            String productName = RandomProductNameGenerator.Generate();
            int productPrice = _random.Next(0, priceRange);
            return new Product(productName, productPrice, vat);
        }
    }
}
