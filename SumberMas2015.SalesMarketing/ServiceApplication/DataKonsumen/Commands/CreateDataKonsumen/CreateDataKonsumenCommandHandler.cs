using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.ServiceApplication.Agama.Queries.AgamaListById;
using SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelaminById;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.MasterBidangPekerjaanDBsById;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.MasterBidangUsahaDBsById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen
{
    public class CreateDataKonsumenCommandHandler : IRequestHandler<CreateDataKonsumenCommand,Guid>
    {
        private readonly SalesMarketingContext _context;
        private IMediator _mediator;
        public CreateDataKonsumenCommandHandler(SalesMarketingContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataKonsumenCommand request, CancellationToken cancellationToken)
        {
            var Agama = await _mediator.Send( new AgamaListByIdQuery { AgamaId = request.Agama });
            var JnsKelamin = await _mediator.Send(new ListJenisKelaminByIdQuery { NoUrutId = request.JenisKelamin });

            var mstBidangUsaha = await _mediator.Send(new MasterBidangUsahaDBsByIdQuery {NoUrutId = request.KodeBidangUsaha });
            var mstBidangPekerjaan = await _mediator.Send(new MasterBidangPekerjaanDBsByIdQuery {NoUrutId = request.KodeBidangPekerjaan });


            var dtKonsumen = Domain.DataKonsumen.Create(request.NoKtp, request.TanggalLahir, JnsKelamin.ListJenisKelaminResponseId,Domain.ValueObjects.Name.CreateName(request.Nama.NamaDepan, request.Nama.NamaBelakang),
                Domain.ValueObjects.Name.CreateName(request.NamaBPKB.NamaDepan, request.NamaBPKB.NamaBelakang),Domain.ValueObjects.Alamat.CreateAlamat(request.Alamat.Jalan,
                request.Alamat.Kelurahan, request.Alamat.Kecamatan, request.Alamat.Kota, request.Alamat.Propinsi,
                request.Alamat.KodePos, request.Alamat.NoTelepon, request.Alamat.NoFax, request.Alamat.NoHandphone),
                Domain.ValueObjects.Alamat.CreateAlamat(request.AlamatKirim.Jalan, request.AlamatKirim.Kelurahan, request.AlamatKirim.Kecamatan, request.AlamatKirim.Kota,
                request.AlamatKirim.Propinsi, request.AlamatKirim.KodePos, request.AlamatKirim.NoTelepon, request.AlamatKirim.NoFax, request.AlamatKirim.NoHandphone),
                Agama.AgamaListByIdResponseId,request.Email, mstBidangPekerjaan.MasterBidangPekerjaanId, request.NamaBidangPekerjaan, mstBidangUsaha.MasterBidangUsahaId, request.NamaBidangUsaha,request.UserName,request.UserNameId);

            if(dtKonsumen != null)
            {
                await _context.DataKonsumen.AddAsync(dtKonsumen);
                await _context.SaveChangesAsync();
            }
             return dtKonsumen.DataKonsumenId;
            //return Unit.Value;

        }
    }
}
