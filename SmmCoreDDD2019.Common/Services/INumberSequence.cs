using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmmCoreDDD2019.Common.Services
{
    public interface INumberSequence
    {
        string GetNumberSequence(string module);
    }
}
