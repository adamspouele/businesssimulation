using System;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Vat : IVat
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public Vat(double percent = 0.0)
        {
            Id = Count++;
            this.percent = percent;
        }

        public double percent { get; set; }

        public double calculateTTC(double amount)
        {
            return (amount / percent) + amount;
        }
    }
}
