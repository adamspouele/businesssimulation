using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl.Correction
{
    public class Customer : ICustomer
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public string Name { get; }
        public List<IOrder> Orders { get;  }
        // 1 = Male | 2 = Female
        public int Sex { get; } 

        public Customer(string name = null, int sex = 0)
        {
            Id = Count++;
            // Generate random first/last name and assign it to customer
            if (name == null)
            {
                if (sex == 1)
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
