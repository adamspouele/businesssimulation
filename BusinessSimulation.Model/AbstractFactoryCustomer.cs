using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public abstract class AbstractFactoryCustomer
    {
        public ICustomer CreateNew()
        {
            throw new NotImplementedException();
        }

        public List<ICustomer> CreateMultipleCustomers(int count)
        {
            throw new NotImplementedException();
        }
    }
}
