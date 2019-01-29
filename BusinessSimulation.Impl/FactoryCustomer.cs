using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public static class FactoryCustomer
    {
        private static Random _randomGender = new Random();

        // Create a new customer
        public static ICustomer CreateNew()
        {
            String customerName = "";
            var sex = _randomGender.Next(1, 3);

            if (sex == 1)
                customerName = RandomNameGenerator.Generate(Gender.Male);
            else
                customerName = RandomNameGenerator.Generate(Gender.Female);

            return new Customer(customerName, sex);
        }

        // Create multiple customers at once
        public static List<ICustomer> CreateMultipleCustomers(int count)
        {
            List<ICustomer> customers = new List<ICustomer>();

            int iteration = 0;
            while (iteration < count)
            {
                customers.Add(CreateNew());
                iteration++;
            }

            return customers;
        }
    }
}
