using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    class Order : IOrder
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public ICustomer Customer { get; set; }
        public List<IProduct> Products { get; }

        public Order(ICustomer customer, List<Product> products = null)
        {
            Id = Count++;
            if (products == null) Products = new List<IProduct>();
        }
    }
}
