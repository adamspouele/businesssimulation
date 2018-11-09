using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface IVat
    {
        int Id { get; set; }
        double percent { get; set; }
        double calculateTTC(double amount);
    }
}
