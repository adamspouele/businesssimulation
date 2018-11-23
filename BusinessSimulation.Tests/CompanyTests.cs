﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Tests
{
    [TestFixture]
    class CompanyTests
    {
        [Test]
        public void generate_one_company()
        {
            var company = new Company("Apple", LegalStatus.SA, null, 0);

            Assert.IsTrue(company.Status == LegalStatus.SA);
        }

        [Test]
        public void generate_ten_companies_on_the_fly()
        {
            int count = 0;

            while (count < 10)
            {
                count++;
                var company = new Company("Apple", LegalStatus.SA, null, (new Random()).Next(100000, 40000000));
                Console.WriteLine($"Company #{count}: {company.Name}, salesRevenue: {company.SalesRevenue}");

                Assert.IsTrue(company.Status == LegalStatus.SA);
            }
        }
    }
}