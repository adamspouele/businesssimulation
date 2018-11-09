using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    class Product : IProduct
    {
        public Product()
        {
            Name = "--";
            Price = 0.0f;
            Vat = new Vat();
        }

        public string Name { get; set; }
        public float Price { get; set; }
        public IVat Vat { get; set; }
    }
}
