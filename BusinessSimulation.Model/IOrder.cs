﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface IOrder
    {
        int Id { get; }
        ICustomer Customer { get; set; }
        List<IProduct> products { get; }
    }
}
