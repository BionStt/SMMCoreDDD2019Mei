using System;
using System.Collections.Generic;
using System.Text;
using MediatR;


namespace SmmCoreDDD2019.Application.DataPerusahaanCabangs.Command.DeleteDataPerusahaanCabang
{
    public class DeleteDataPerusahaanCabangCommand:IRequest
    {
        public string Id { get; set; }
    }
}
