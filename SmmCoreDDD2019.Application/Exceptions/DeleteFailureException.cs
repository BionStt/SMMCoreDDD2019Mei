using System;
using System.Collections.Generic;
using System.Text;

namespace SmmCoreDDD2019.Application.Exceptions
{
    public class DeleteFailureException : System.Exception
    {
        public DeleteFailureException(string name, object key, string message)
            : base($"Deletion of entity \"{name}\" ({key}) failed. {message}")
        {
        }
    }
}
