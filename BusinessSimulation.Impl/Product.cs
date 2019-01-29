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
        public double Price { get; set; }
        public IVat Vat { get; set; }
        public ICompany Company { get; set; }

        public Product(string name = null, double price = 0.0, IVat vat = null)
        {
            Id = Count++;
            Name = name ?? RandomProductNameGenerator.Generate();
            Price = price;

            Vat = vat ?? new Vat();
        }

        public double GetPriceWithVAT()
        {
            // price with vat
            return Price + (Price * (Vat.percent / 100));
        }
    }

}
