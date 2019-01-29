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
    class ManagerTests
    {
        [SetUp]
        public void LoadTestDataAtBeginning()
        {

        }

        [Test]
        public void add_a_customer_to_manager()
        {
            var manager = new Manager();

            ICustomer customer = FactoryCustomer.CreateNew();

            manager.AddCustomer(customer);

            int productsCount = manager.GetCustomers().Count;

            Console.WriteLine($"Manager : customers count : {productsCount}");

            Assert.AreEqual(1, productsCount);
        }

        [Test]
        public void add_an_order_to_manager()
        {
            var manager = new Manager();

            // create an order
            IOrder order = new Order(null, null);

            manager.AddOrder(order);

            int ordersCount = manager.GetOrders().Count;

            Console.WriteLine($"Manager : orders count : {ordersCount}");

            Assert.AreEqual(1, ordersCount);
        }

        [Test]
        public void add_a_product_to_manager()
        {
            var manager = new Manager();

            IProduct product = FactoryProduct.CreateNew();

            manager.AddProduct(product);

            int productsCount = manager.GetProducts().Count;

            Console.WriteLine($"Manager : products count : {productsCount}");

            Assert.AreEqual(1, productsCount);
        }

        [Test]
        public void add_a_company_to_manager()
        {
            var manager = new Manager();

            ICompany company = new Company(null, LegalStatus.SA, null, 0);

            manager.AddCompany(company);

            int companiesCount = manager.GetCompanies().Count;

            Console.WriteLine($"Manager : companies count : {companiesCount}");

            Assert.AreEqual(1, companiesCount);
        }

        [Test]
        public void assign_a_company_to_a_product()
        {
            var manager = new Manager();

            IProduct product = FactoryProduct.CreateNew();

            manager.AddProduct(product);

            ICompany company = new Company(null, LegalStatus.SA, null, 0);

            manager.AddCompany(company);

            manager.AssignRandomCompanyToProduct(product);

            Console.WriteLine($"Manager | product name : '{product.Name}', product's provider : '{product.Company.Name}'");

            Assert.IsNotNull(product.Company);
        }

        [Test]
        public void aaa()
        {
            var manager = new Manager();

            ICustomer customer = FactoryCustomer.CreateNew();

            // create Vat
            Vat vat = new Vat(20);

            var random = new Random();

            // create products
            List<IProduct> products = FactoryProduct.CreateMultipleProducts(random.Next(5, 15), random.Next(50, 150), vat, manager);

            foreach (Product _product in products)
            {
                manager.AssignRandomCompanyToProduct(_product);
                Console.WriteLine($"Product #{_product.Id} | {_product.Name}, provider: {_product.Company}, vat : {_product.Vat.percent}%, price without vat : {_product.Price} €, price with vat : {_product.GetPriceWithVAT()} €");
            }

            // create an order
            Order order = new Order(customer, products);

            Console.WriteLine($"Order #{order.Id} | {order.Products.Count} products, price : {order.GetTotalPrice()} €, price with vat : {order.GetTotalPriceWithVAT()} €, vat margin : {order.GetVatMargin()} €  ");

           // Console.WriteLine($"Manager : Customers : {manager.GetCustomers.}")

            Assert.IsTrue(order.Products.Count > 1);
        }
    }
}
