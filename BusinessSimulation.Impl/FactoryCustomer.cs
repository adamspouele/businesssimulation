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
            throw new NotImplementedException();
        }

        // Create multiple customers at once
        public static List<ICustomer> CreateMultipleCustomers(int count)
        {
            throw new NotImplementedException();
        }
    }
}
