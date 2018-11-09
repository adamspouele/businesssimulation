using System;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    public class Vat : IVat
    {
        public Vat(float percent = 0.2f)
        {
            this.percent = percent;
        }

        public float percent { get; set; }

        public float calculateTTC(float amount)
        {
            return (amount / percent) + amount;
        }
    }
}
