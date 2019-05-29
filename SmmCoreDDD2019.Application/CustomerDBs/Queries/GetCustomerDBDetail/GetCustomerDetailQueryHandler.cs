using System;
using System.Collections.Generic;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;


namespace SmmCoreDDD2019.Application.CustomerDBs.Queries.GetCustomerDBDetail
{
    public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public GetCustomerDetailQueryHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }

        public async Task<CustomerDetailModel> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.CustomerDB
                .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CustomerDB), request.Id);
            }

            return new CustomerDetailModel
            {
               CustomerID = entity.CustomerID,
                Alamat = entity.Alamat,
                AlamatKirim = entity.AlamatKirim,
                Faks = entity.Faks,
                Handphone = entity.Handphone,
                Kecamatan = entity.Kecamatan,
                Kelurahan = entity.Kelurahan,
                KodePos = entity.KodePos,
                Kota = entity.Kota,
                Nama = entity.Nama,
                NamaBPKB = entity.NamaBPKB,
                NoKtp = entity.NoKtp,
             Telp = entity.Telp,
                TelpKantor = entity.TelpKantor,
                TglLahir = entity.TglLahir,
                UserIDPeg = entity.UserIDPeg,
                UserInput = entity.UserInput
            };
        }
    }
}
