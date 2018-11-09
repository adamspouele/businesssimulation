using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessSimulation.Model
{
    public interface ILegalStatus
    {
        string Name { get; set; }
        string getLegalStatus();
        void setLegalStatus(int status);
    }
}
