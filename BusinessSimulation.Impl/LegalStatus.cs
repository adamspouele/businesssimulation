using System;
using System.Collections.Generic;
using System.Text;
using BusinessSimulation.Model;

namespace BusinessSimulation.Impl
{
    class LegalStatus : ILegalStatus
    {
        public string Name { get; set; }
        private int Status { get; set; }

        private string[] LegalStatusArray { get; set; }

        public LegalStatus()
        {
            LegalStatusArray = new string[7];
            LegalStatusArray[0] = "SA";
            LegalStatusArray[1] = "SAS";
            LegalStatusArray[2] = "SASU";
            LegalStatusArray[3] = "SARL";
            LegalStatusArray[4] = "EURL";
            LegalStatusArray[5] = "EIRL";
            LegalStatusArray[6] = "SNC";
        }
        
        public string getLegalStatus()
        {
            return LegalStatusArray[Status];
        }

        // use LegalStatusArray find the right status
        public void setLegalStatus(int status)
        {
            Status = status;
        }
    }
}
