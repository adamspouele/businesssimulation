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
        public void assign_a_customer_to_order()
        {
            IOrder order = new Order();

            ICustomer customer = FactoryCustomer.CreateNew();

            order.Customer = customer;

            Console.WriteLine(order.Customer != null);
        }

        [Test]
        public void assign_some_products_to_order()
        {
            IOrder order = new Order();

            var products = FactoryProduct.CreateMultipleProducts(3);

            order.Products.AddRange(products);

            Console.WriteLine(order.Products.Count == 2);
        }

        [Test]
        public void calculate_total_order_price()
        {
            IOrder order = new Order();

            var products = FactoryProduct.CreateMultipleProducts(3);

            order.Products.AddRange(products);

            Console.WriteLine(order.GetTotalPrice() > 0);
        }

        [Test]
        public void calculate_total_order_vat_price()
        {
            IOrder order = new Order();

            var products = FactoryProduct.CreateMultipleProducts(3);

            order.Products.AddRange(products);

            Console.WriteLine(order.GetTotalPriceWithVAT() > 0);
        }

        [Test]
        public void calculate_vat_amount_of_an_order()
        {
            IOrder order = new Order();

            var products = FactoryProduct.CreateMultipleProducts(3);

            order.Products.AddRange(products);

            Console.WriteLine(order.GetVatMargin() > 0);
        }

        [Test]
        public void create_one_complete_order()
        {
            IManager manager = new Manager();
            ICustomer customer = FactoryCustomer.CreateNew();
            manager.AddCustomer(customer);

            // create Vat
            Vat vat = new Vat(20);
            manager.AddVat(vat);

            var random = new Random();

            ICompany store = new Company();
            manager.AddCompany(store);

            // create products
            List<IProduct> products = FactoryProduct.CreateMultipleProducts(random.Next(5, 15), random.Next(50, 150), vat, manager, store);

            foreach(Product _product in products)
            {
                manager.AddProduct(_product);
                Console.WriteLine($"Product #{_product.Id}: {_product.Name}, vat : {_product.Vat.percent}%, price without vat : {_product.Price} €, price with vat : {_product.GetPriceWithVAT()} €");
            }

            // create an order
            Order order = new Order(customer, products);

            Console.WriteLine($"Order #{order.Id}: {order.Products.Count} products, price : {order.GetTotalPrice()} €, price with vat : {order.GetTotalPriceWithVAT()} €, vat margin : {order.GetVatMargin()} €  ");

            Assert.IsTrue(products.Count > 1);
            //Assert.IsTrue(order.Products.Count > 1);
        }
    }
}
