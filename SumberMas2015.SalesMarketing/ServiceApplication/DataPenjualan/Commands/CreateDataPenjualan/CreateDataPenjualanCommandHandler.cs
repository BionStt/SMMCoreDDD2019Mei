using MediatR;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.SalesMarketing.ServiceApplication.DataPenjualan.Commands.CreateDataPenjualan
{
    public class CreateDataPenjualanCommandHandler : IRequestHandler<CreateDataPenjualanCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreateDataPenjualanCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateDataPenjualanCommand request, CancellationToken cancellationToken)
        {
            //data dibawah ini mau diambil
            var DataSPKId = Guid.NewGuid();
            var DtKonsumenId = Guid.NewGuid();
            var mstLeasingCabang = Guid.NewGuid();
            var salesId = Guid.NewGuid();
            var mstKategoriPenjualan = Guid.NewGuid();


            var dtDataPenjualan = Domain.DataPenjualan.CreateDataPenjualan(DataSPKId, DtKonsumenId, mstLeasingCabang, request.noBuku, salesId,request.keterangan, mstKategoriPenjualan,request.mediator,request.userNameInput);

            await _context.DataPenjualan.AddAsync(dtDataPenjualan);
            await _context.SaveChangesAsync();

            return dtDataPenjualan.DataPenjualanId;

        }
    }
}
