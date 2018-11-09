using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IVat
    {
        float percent { get; set; }

        float calculateTTC(float amount);
    }
}
