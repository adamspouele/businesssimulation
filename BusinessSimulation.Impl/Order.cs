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

        public Order(ICustomer customer, List<IProduct> products = null)
        {
            Id = Count++;
            if (products == null) Products = new List<IProduct>();
        }

        public double getTotalPrice()
        {
            double totalPrice = 0;
            foreach (IProduct product in Products)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
