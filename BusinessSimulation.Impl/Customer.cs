using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public List<IOrder> orders { get; set; }
    }
}
