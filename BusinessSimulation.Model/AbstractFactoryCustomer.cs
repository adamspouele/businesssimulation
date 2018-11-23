using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public abstract class AbstractFactoryCustomer
    {
        public ICustomer CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
