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
        public static IProduct CreateNew(int priceRange = 100, IVat vat = null, ICompany store = null)
        {
            String productName = RandomProductNameGenerator.Generate();
            int productPrice = _random.Next(1, priceRange);
            var product = new Product(productName, productPrice, vat);

            if(store != null)
               product.Company = store;

            return product;
        }

        // Create multiple products at once
        public static List<IProduct> CreateMultipleProducts(int count, int priceRange = 100, IVat vat = null, IManager manager = null, ICompany store = null)
        {
            List<IProduct> products = new List<IProduct>();

            if(manager != null)
            {
                if (store == null && manager.GetCompanies().Count > 0)
                    store = manager.getRandomCompany();
            }

            int iteration = 0;
            while (iteration < count)
            {
                products.Add(CreateNew(priceRange, vat, store));
                iteration++;
            }

            return products;
        }
    }
}
