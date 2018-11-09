using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Impl;

namespace BusinessSimulation.Impl
{
    class LegalStatus : ILegalStatus
    {
        public string Name { get; set; }
        public LegalStatusValues Status { get; set; }

        public LegalStatus(LegalStatusValues legalStatus)
        {
            Status = legalStatus;
        }
    }
}
