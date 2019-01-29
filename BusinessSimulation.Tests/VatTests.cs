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
    class VatTests
    {
        [Test]
        public void create_one_vat()
        {
            var vat = new Vat();

            Assert.IsTrue(vat.percent == 0.0);
        }

        [Test]
        public void create_ten_vats_on_the_fly()
        {
            int count = 0;

            while (count < 10)
            {
                count++;
                var random = new Random(DateTime.Now.Millisecond);

                var vat = new Vat(random.Next(10,20));
                Console.WriteLine($"Vat #{count}: {vat.percent} %");

                Assert.IsTrue(vat.percent != 0.0);
            }
        }
    }
}
