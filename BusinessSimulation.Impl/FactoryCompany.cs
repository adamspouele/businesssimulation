﻿using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
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
            throw new NotImplementedException();
        }
    }
}
