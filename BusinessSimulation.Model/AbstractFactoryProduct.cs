using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public abstract class AbstractFactoryProduct
    {
        public IProduct CreateNew()
        {
            throw new NotImplementedException();
        }
    }
}
