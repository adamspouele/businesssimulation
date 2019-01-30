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
    class CustomerTests
    {
        [SetUp]
        public void LoadTestDataAtBeginning()
        {

        }

        [Test]
        public void create_a_male_first_name()
        {
            Console.WriteLine("create_a_male_first_name");
            var firstname = RandomNameGenerator.GenerateFirstName(Gender.Male);

            Assert.IsNotNull(firstname);
        }

        [Test]
        public void create_a_female_first_name()
        {
            Console.WriteLine("create_a_female_first_name");
            var firstname = RandomNameGenerator.GenerateFirstName(Gender.Female);

            Assert.IsNotNull(firstname);
        }

        [Test]
        public void create_a_last_name()
        {
            Console.WriteLine("create_a_last_name");
            var lastname = RandomNameGenerator.GenerateLastName();

            Assert.IsNotNull(lastname);
        }

        [Test]
        public void create_male_customer()
        {
            Console.WriteLine("create_male_customer");
            var fullname = RandomNameGenerator.Generate(Gender.Male);

            ICustomer customer = new Customer(fullname, 1);

            Assert.IsTrue(fullname != null && customer.Sex == 1);
        }

        [Test]
        public void create_female_customer()
        {
            Console.WriteLine("create_female_customer");
            var fullname = RandomNameGenerator.Generate(Gender.Female);

            ICustomer customer = new Customer(fullname, 2);

            Assert.IsTrue(fullname != null && customer.Sex == 2);
        }

        [Test]
        public void create_ten_customers_on_the_fly()
        {
            int count = 0;

            while(count < 10)
            {
                count++;
                var customer = FactoryCustomer.CreateNew();
                var sex = "";

                if (customer.Sex == 1)
                    sex = "Male";
                else
                    sex = "Female";

                Console.WriteLine($"Customer #{count}: {customer.Name}, Sex : {sex}");

                Assert.IsTrue(customer.Name != null);
            }
        }
    }
}
