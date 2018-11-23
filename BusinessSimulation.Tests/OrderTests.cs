using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Tests
{
    [TestFixture]
    class OrderTests
    {
        [Test]
        public void generate_one_order()
        {
            FactoryCustomer fcustomer = new FactoryCustomer();
            ICustomer customer = fcustomer.CreateNew();

            // create Vat
            Vat vat = new Vat(20);

            // create products
            FactoryProduct fproduct = new FactoryProduct();
            List<IProduct> products = fproduct.CreateMultipleProducts(10, 100, vat);

            // create order
            // ...

        }

        [Test]
        public void generate_ten_order_on_the_fly()
        {
        }
    }
}
