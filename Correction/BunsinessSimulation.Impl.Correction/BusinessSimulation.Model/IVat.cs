using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IVat
    {
        int Id { get; set; }
        double percent { get; set; }
        double calculateTTC(double amount);
    }
}
