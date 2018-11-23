using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessSimulation.Impl;
using BusinessSimulation.Model;

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

            foreach(Product _product in products)
            {
                Console.WriteLine($"Product #{_product.Id}: {_product.Name}");
            }

            // create an order
            Order order = new Order(customer, products);

            Console.WriteLine($"Order #{order.Id}: {order.getTotalPrice()}");

            Assert.IsTrue(order.getTotalPrice() > 5);

        }
    }
}
