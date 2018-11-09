using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface IVat
    {
        double percent { get; set; }

        double calculateTTC(double amount);
    }
}
