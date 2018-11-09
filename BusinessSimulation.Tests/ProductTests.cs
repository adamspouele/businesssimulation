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
    class ProductTests
    {
        [Test]
        public void generate_one_product_with_price()
        {
            var product = new Product("sandwitch", 6.9f);

            Assert.IsTrue(product.Price == 6.9f);
        }
        
        [Test]
        public void generate_ten_coffee_products_on_the_fly()
        {
            int count = 0;

            while (count < 10)
            {
                count++;
                var product = new Product("Coffee", 10.0f);
                Console.WriteLine($"Product #{count}: {product.Name}");

                Assert.IsTrue(product.Name == "Coffee");
            }
        }
    }
}
