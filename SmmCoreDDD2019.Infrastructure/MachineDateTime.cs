using SmmCoreDDD2019.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Infrastructure
{
    public class MachineDateTime : IDateTime
    {
        public DateTime Now => DateTime.Now;

        public int CurrentYear => DateTime.Now.Year;
    }
}
