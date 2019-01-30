using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl.Correction
{
    public static class FactoryCompany
    {
        // Create a new company
        public static ICompany CreateNew()
        {
            return new Company(null, LegalStatus.SA, null, 0);
        }

        // Create multiple company at once
        public static List<ICompany> CreateMultipleCompanies(int count)
        {
            List<ICompany> companies = new List<ICompany>();

            int iteration = 0;
            while (iteration < count)
            {
                companies.Add(CreateNew());
                iteration++;
            }

            return companies;
        }
    }
}
