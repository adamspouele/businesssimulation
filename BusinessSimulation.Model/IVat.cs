using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface IVat
    {
        float percent { get; set; }

        float calculateTTC(float amount);
    }
}
