﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface ICustomer
    {
        string Name { get; }
        int Sex { get;}
        List<IOrder> Orders { get;}
    }
}
