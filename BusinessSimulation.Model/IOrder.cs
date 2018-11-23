using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IOrder
    {
        int Id { get; set; }
        ICustomer Customer { get; set; }
        List<IProduct> Products { get; }
        double getTotalPrice();
    }
}
