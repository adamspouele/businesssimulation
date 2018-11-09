using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    class Company : ICompany
    {
        public string name { get; set; }
        public ILegalStatus legalStatus { get; set; }
        public List<IProduct> products { get; set; }
        public double salesRevenue { get; set; }
    }
}
