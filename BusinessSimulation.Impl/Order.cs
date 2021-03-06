﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Order : IOrder
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public ICustomer Customer { get; set; }
        public List<IProduct> Products { get; }

        public Order(ICustomer customer = null, List<IProduct> products = null)
        {
            Id = Count++;

            Customer = customer;

            if (products == null) Products = new List<IProduct>();
            else Products = products;
        }

        public double GetTotalPrice()
        {
            throw new NotImplementedException();
        }

        public double GetTotalPriceWithVAT()
        {
            throw new NotImplementedException();
        }

        public double GetVatMargin()
        {
            throw new NotImplementedException();
        }
    }
}
