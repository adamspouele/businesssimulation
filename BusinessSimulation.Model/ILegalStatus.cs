using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Impl
{
    public interface ILegalStatus
    {
        string Name { get; set; }
        LegalStatusValues Status { get; set; }
    }
}
