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
        public void Generate_one_order()
        {
            FactoryCustomer fcustomer = new FactoryCustomer();
            ICustomer customer = fcustomer.CreateNew();

            // create Vat
            Vat vat = new Vat(20);

            var random = new Random();

            // create products
            FactoryProduct fproduct = new FactoryProduct();
            List<IProduct> products = fproduct.CreateMultipleProducts(random.Next(5, 15), random.Next(50, 150), vat);

            foreach(Product _product in products)
            {
                Console.WriteLine($"Product #{_product.Id}: {_product.Name}, vat : {_product.Vat.percent}%, price without vat : {_product.Price} €, price with vat : {_product.GetPriceWithVAT()} €");
            }

            // create an order
            Order order = new Order(customer, products);

            Console.WriteLine($"Order #{order.Id}: {order.Products.Count} products, price : {order.GetTotalPrice()} €, price with vat : {order.GetTotalPriceWithVAT()} €, vat margin : {order.GetVatMargin()} €  ");

            Assert.IsTrue(order.Products.Count > 1);
        }
    }
}
