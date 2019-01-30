using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessSimulation.Model;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Tests
{
    [TestFixture]
    class ProductTests
    {
        [Test]
        public void generate_random_product_name()
        {
            Console.WriteLine("create_one_product_with_price");
            var randomProductName = RandomProductNameGenerator.Generate();
            Assert.IsTrue(randomProductName != null);
        }

        [Test]
        public void assign_a_vat_to_product()
        {
            IVat vat = new Vat();
            vat.percent = 20;
            IProduct product = new Product("sandwitch", 2.0f, vat);

            Assert.IsTrue(product.Vat != null);
        }

        [Test]
        public void assign_a_store_to_product()
        {
            IVat vat = new Vat();
            vat.percent = 20;
            IProduct product = new Product("sandwitch", 2.0f, vat);

            ICompany store = new Company();
            product.Company = store;

            Assert.IsTrue(product.Company != null);
        }

        [Test]
        public void create_one_product_with_price()
        {
            var product = new Product("sandwitch", 6.9f);

            Assert.IsTrue(product.Price == 6.9f);
        }

        [Test]
        public void calculte_vat_price_of_product()
        {
            var product = new Product("sandwitch", 6.9f);

            Assert.IsTrue(product.GetPriceWithVAT() > 0);
        }

        [Test]
        public void create_ten_coffee_products_on_the_fly()
        {
            int count = 0;

            while (count < 10)
            {
                count++;
                var product = new Product(null, 10.0f);
                Console.WriteLine($"Product #{count}: {product.Name}");

                Assert.IsTrue(product.Name != "");
            }
        }
    }
}
