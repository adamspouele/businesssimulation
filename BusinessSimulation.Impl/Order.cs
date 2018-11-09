using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    class Order : IOrder
    {
        public int Id { get; }
        public ICustomer Customer { get; set; }

        public List<IProduct> products { get; }
    }
}
