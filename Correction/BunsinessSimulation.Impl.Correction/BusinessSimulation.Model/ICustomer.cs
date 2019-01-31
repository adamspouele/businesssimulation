using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface ICustomer
    {
        int Id { get; set; }
        string Name { get; }
        int Sex { get;}
        List<IOrder> Orders { get;}
    }
}
