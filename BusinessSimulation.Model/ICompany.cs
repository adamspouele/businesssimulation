using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface ICompany
    {
        int Id { get; set; }
        string Name { get; set; }
        LegalStatus Status { get; set; }
        double SalesRevenue { get; set; }
        List<IProduct> Products { get;set; }
    }
}
