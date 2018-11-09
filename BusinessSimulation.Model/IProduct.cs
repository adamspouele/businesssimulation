using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        // whithout tax
        float Price { get; set; }
        // tax
        IVat Vat { get; set; }
    }
}