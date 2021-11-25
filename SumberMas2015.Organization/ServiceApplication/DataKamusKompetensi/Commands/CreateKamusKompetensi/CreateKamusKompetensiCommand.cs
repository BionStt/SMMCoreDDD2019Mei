using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumberMas2015.Organization.ServiceApplication.DataKamusKompetensi.Commands.CreateKamusKompetensi
{
    public class CreateKamusKompetensiCommand : IRequest
    {
        public string Penjelasan { get; internal set; }
        public string NamaKamusKompetensi { get; internal set; }
    }
}
