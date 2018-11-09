using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IProduct
    {
        string Name { get; set; }
        float Price { get; set; }
        IVat Vat { get; set; }
    }
}