using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using SmmCoreDDD2019.Application.Interfaces.Mapping;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.Pembelians.Query.GetNamaPO
{
    public class GetNamaPOViewModel
    {
        public IEnumerable<GetNamaPOLookUpModel> DataPODS { get; set; }
    }
}
