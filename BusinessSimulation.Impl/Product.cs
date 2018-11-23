using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Product : IProduct
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public IVat Vat { get; set; }

        public Product(string name = null, float price = 0.0f, IVat vat = null)
        {
            Id = Count++;
            Name = name ?? RandomProductNameGenerator.Generate();
            Price = price;

            Vat = vat ?? new Vat();
        }
    }
}
