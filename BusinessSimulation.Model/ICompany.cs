using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface ICompany
    {
        string name { get; set; }
        ILegalStatus legalStatus { get; set; }
        double salesRevenue { get; set; }
        List<IProduct> products { get;set; }
    }
}
