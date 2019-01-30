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
            throw new NotImplementedException();
        }

        // Create multiple products at once
        public static List<IProduct> CreateMultipleProducts(int count, int priceRange = 100, IVat vat = null, IManager manager = null, ICompany store = null)
        {
            throw new NotImplementedException();
        }
    }
}
