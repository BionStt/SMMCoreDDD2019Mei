using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBarang.Queries.MasterBarangById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataSPK.Commands.CreateDataSPKKendaraan
{
    public class CreateDataSPKKendaraanCommandHandler : IRequestHandler<CreateDataSPKKendaraanCommand, Guid>
    {
        private readonly SalesMarketingContext _context;
        private IMediator _mediator;
        public CreateDataSPKKendaraanCommandHandler(SalesMarketingContext context, IMediator mediator)
        {
            _context = context;
            _mediator = mediator;
        }

        public async Task<Guid> Handle(CreateDataSPKKendaraanCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = await _mediator.Send(new MasterBarangByIdQuery { MasterBarangId = request.MasterBarangId});
            var dtSPKId = Guid.NewGuid();

            var dtSpkKendaraan = Domain.DataSPKKendaraan.CreateDataSPKKendaraan(request.TahunPerakitan,request.Warna,request.NamaSTNK,request.NoKTPSTNK, mstBarang.MasterBarangIdGuid, dtSPKId);

            await _context.DataSPKKendaraan.AddAsync(dtSpkKendaraan);
            await _context.SaveChangesAsync();

            return dtSpkKendaraan.DataSPKKendaraanId;
        }
    }
}
