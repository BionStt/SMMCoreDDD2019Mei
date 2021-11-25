using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataPerusahaanVMV.Commands.CreateVisiPerusahaan
{
    public class CreateVisiPerusahaanCommand : IRequest
    {
        public string Visi { get;  set; }
    }
}
