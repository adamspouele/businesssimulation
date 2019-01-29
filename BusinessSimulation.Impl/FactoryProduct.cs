using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public static class FactoryProduct
    {
        private static Random _random = new Random();

        // Create a product
        public static IProduct CreateNew(int priceRange = 100, IVat vat = null, IManager manager = null)
        {
            String productName = RandomProductNameGenerator.Generate();
            int productPrice = _random.Next(0, priceRange);
            var product = new Product(productName, productPrice, vat);

            if(manager != null)
                manager.AssignRandomCompanyToProduct(product);

            return product;
        }

        // Create multiple products at once
        public static List<IProduct> CreateMultipleProducts(int count, int priceRange = 100, IVat vat = null, IManager manager = null)
        {
            List<IProduct> products = new List<IProduct>();

            int iteration = 0;
            while (iteration < count)
            {
                products.Add(CreateNew(priceRange, vat, manager));
                iteration++;
            }

            return products;
        }
    }
}
