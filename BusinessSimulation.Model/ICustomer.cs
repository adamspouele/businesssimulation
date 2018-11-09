using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface ICustomer
    {
        string Name { get; set; }
        List<IOrder> orders { get; set; }
    }
}
