using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    public class Customer : ICustomer
    {
        public string Name { get; }
        public List<IOrder> Orders { get;  }
        public int Sex { get; }

        public Customer(string name = null, int sex = 0)
        {
            // Generate random first/last name and assign it to customer
            if (name == null)
            {
                var random = new Random();

                if (random.Next(1, 3) == 1)
                    Name = RandomNameGenerator.Generate(Gender.Male);
                else
                    Name = RandomNameGenerator.Generate(Gender.Female);
            }
            else
            {
                Name = name;
            }

            if(sex == 0)
            {
                var random = new Random();
                Sex = random.Next(1, 3);
            }
            else
            {
                Sex = sex;
            }
        }
    }
}
