using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public class FactoryCustomer : AbstractFactoryProduct
    {
        private static Random _randomGender = new Random();

        protected FactoryCustomer()
        {
        }

        public new ICustomer CreateNew()
        {
            String customerName = "";
            var sex = _randomGender.Next(1, 3);

            if (sex == 1)
                customerName = RandomNameGenerator.Generate(Gender.Male);
            else
                customerName = RandomNameGenerator.Generate(Gender.Female);

            return new Customer(customerName, sex);
        }
    }
}
