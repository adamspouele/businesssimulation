using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        ICompany Company { get; set; }
        // price whithout tax
        double Price { get; set; }
        // price with tax
        double GetPriceWithVAT();
        // tax
        IVat Vat { get; set; }
    }
}