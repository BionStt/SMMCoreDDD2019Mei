using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class NotFoundException : System.Exception
    {
        public NotFoundException(string name, object key)
            : base($"Entity \"{name}\" ({key}) was not found.")
        {
        }
    }
}
