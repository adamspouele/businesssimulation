using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    public class Company : ICompany
    {
        static int Count { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProduct> Products { get; set; }
        public LegalStatus Status { get; set; }
        public double SalesRevenue { get; set; }

        public Company(string name = null, LegalStatus legalStatus = LegalStatus.SAS, List<IProduct> products = null, double salesRevenue = 0.0)
        {
            Id = Count++;
            Name = name ?? RandomCompanyNameGenerator.Generate();
            Status = legalStatus;

            if (products == null) Products = new List<IProduct>();

            SalesRevenue = salesRevenue;
        }
    }
}
