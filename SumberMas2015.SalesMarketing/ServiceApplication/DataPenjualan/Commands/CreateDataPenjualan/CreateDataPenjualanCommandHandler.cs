using MediatR;
using Microsoft.EntityFrameworkCore;
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
            var DataSPKId = await _context.DataSPK.Where(x => x.NoUrutId==request.dataSPKId).Select(x => x.DataSPKId).SingleOrDefaultAsync();
            var DtKonsumenId = await _context.DataKonsumen.Where(x => x.NoUrutId == request.dataKonsumenId).Select(x => x.DataKonsumenId).SingleOrDefaultAsync();
            var mstLeasingCabang = await _context.MasterLeasingCabang.Where(x => x.NoUrutId== request.masterLeasingCabangId).Select(x => x.MasterLeasingCabangId).SingleOrDefaultAsync();
            var salesId = await _context.DataSalesMarketing.Where(x => x.NoUrutId==request.salesUserId).Select(x => x.DataSalesMarketingId).SingleOrDefaultAsync();

            var mstKategoriPenjualan = await _context.MasterKategoriPenjualan.Where(x => x.NoUrutId==request.masterKategoriPenjualanId).Select(x => x.MasterKategoriPenjualanId).SingleOrDefaultAsync();

            var dtDataPenjualan = Domain.DataPenjualan.CreateDataPenjualan(DataSPKId, DtKonsumenId, mstLeasingCabang, request.noBuku, salesId,request.keterangan, mstKategoriPenjualan,request.mediator,request.UserName,request.UserNameId);

            await _context.DataPenjualan.AddAsync(dtDataPenjualan);
            await _context.SaveChangesAsync();

            return dtDataPenjualan.DataPenjualanId;

        }
    }
}
