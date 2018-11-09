using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public float Price { get; set; }
        public IVat Vat { get; set; }

        public Product(string name = "--", float price = 0.0f, Vat vat = null)
        {
            Name = name;
            Price = price;

            Vat = vat == null ? new Vat() : vat;
        }
    }
}
