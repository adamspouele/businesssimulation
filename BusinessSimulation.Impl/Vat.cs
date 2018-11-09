using System;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    public class Vat : IVat
    {
        public Vat(double percent = 0.0)
        {
            this.percent = percent;
        }

        public double percent { get; set; }

        public double calculateTTC(double amount)
        {
            return (amount / percent) + amount;
        }
    }
}
