using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface IProduct
    {
        string Name { get; set; }
        // whithout tax
        float Price { get; set; }
        // tax
        IVat Vat { get; set; }
    }
}