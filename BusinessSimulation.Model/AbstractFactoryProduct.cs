using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public abstract class AbstractFactoryProduct
    {
        public IProduct CreateNew()
        {
            throw new NotImplementedException();
        }

        public List<IProduct> CreateMultipleProducts(int count, int priceRange = 100, IVat vat = null)
        {
            throw new NotImplementedException();
        }
    }
}
