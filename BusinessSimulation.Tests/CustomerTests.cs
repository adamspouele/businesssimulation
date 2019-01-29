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
    class CustomerTests
    {
        [SetUp]
        public void LoadTestDataAtBeginning()
        {

        }

        [Test]
        public void create_first_and_last_name()
        {
            var firstname = RandomNameGenerator.GenerateFirstName(Gender.Female);
            var lastname = RandomNameGenerator.GenerateLastName();

            Console.WriteLine($"First name : {firstname}");
            Console.WriteLine($"Last name : {lastname}");

            Assert.IsTrue(firstname != null && lastname != null);
        }

        [Test]
        public void create_one_customers()
        {
            var customer = new Customer();
            Console.WriteLine($"Customer : {customer.Name}");

            Assert.IsTrue(customer.Name != null);
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
