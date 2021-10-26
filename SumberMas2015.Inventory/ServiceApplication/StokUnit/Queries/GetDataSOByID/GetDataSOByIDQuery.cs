﻿using MediatR;
using SumberMas2015.Inventory.Dto.StokUnit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.StokUnit.Queries.GetDataSOByID
{
    public class GetDataSOByIDQuery:IRequest<GetDataSOByIDResponse>
    {
        public string Id { get; set; }
    }
}