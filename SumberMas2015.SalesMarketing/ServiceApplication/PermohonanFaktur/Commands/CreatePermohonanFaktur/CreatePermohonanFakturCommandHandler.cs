using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SumberMas2015.SalesMarketing.InfrastructureData.Context;

namespace SumberMas2015.SalesMarketing.ServiceApplication.PermohonanFaktur.Commands.CreatePermohonanFaktur
{
    public class CreatePermohonanFakturCommandHandler : IRequestHandler<CreatePermohonanFakturCommand, Guid>
    {
        private readonly SalesMarketingContext _context;

        public CreatePermohonanFakturCommandHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreatePermohonanFakturCommand request, CancellationToken cancellationToken)
        {

            var penjualanDetailId = await _context.DataPenjualanDetail.Where(x => x.NoUrutId == request.KodePenjualanDetail).Select(x=>new { x.DataPenjualanDetailId}).SingleOrDefaultAsync();

            var xx = await _context.PermohonanFaktur.OrderByDescending(x => x.NoUrutId).Take(1).ToListAsync();
            var xy = string.Empty;
            if (xx.Any())
            {
                xy = (xx[0].NoUrutId + 1).ToString();
            }
            else
            {
                xy = "1";

            }

            var dtPermohonanFaktur = Domain.PermohonanFaktur.CreatePermohonanFaktur(GenerateNomorPermohonanFaktur(request.TanggalInput,xy), request.TanggalInput, penjualanDetailId.DataPenjualanDetailId, request.TanggalLahir,request.NomorKTP,request.NamaFaktur,
                Domain.ValueObjects.Alamat.CreateAlamat(request.Alamat, request.Kelurahan, request.Kecamatan, request.Kota, request.Propinsi
                , request.KodePos, request.Telepon, request.NomorFaks,request.HandphoneF),request.UserNameId,request.UserName);

            await _context.PermohonanFaktur.AddAsync(dtPermohonanFaktur);
            await _context.SaveChangesAsync();

            return dtPermohonanFaktur.PermohonanFakturId;

        }

        private string GenerateNomorPermohonanFaktur(DateTime TanggalInput, string Number)
        {
            var bln = TanggalInput.Month;
            var thn = TanggalInput.Year;
            var NomorPermohonanFaktur = string.Empty;

            switch (bln)
            {
                case 1:
                    NomorPermohonanFaktur = "NF/" + Number + "/I/" + thn;
                    break;
                case 2:
                    NomorPermohonanFaktur = "NF/" + Number + "/II/" + thn;
                    break;
                case 3:
                    NomorPermohonanFaktur = "NF/" + Number + "/III/" + thn;
                    break;
                case 4:
                    NomorPermohonanFaktur = "NF/" + Number + "/IV/" + thn;
                    break;
                case 5:
                    NomorPermohonanFaktur = "NF/" + Number + "/V/" + thn;
                    break;
                case 6:
                    NomorPermohonanFaktur = "NF/" + Number + "/VI/" + thn;
                    break;
                case 7:
                    NomorPermohonanFaktur = "NF/" + Number + "/VII/" + thn;
                    break;
                case 8:
                    NomorPermohonanFaktur = "NF/" + Number + "/VIII/" + thn;
                    break;
                case 9:
                    NomorPermohonanFaktur = "NF/" + Number + "/IX/" + thn;
                    break;
                case 10:
                    NomorPermohonanFaktur = "NF/" + Number + "/X/" + thn;
                    break;
                case 11:
                    NomorPermohonanFaktur = "NF/" + Number + "/XI/" + thn;
                    break;
                case 12:
                    NomorPermohonanFaktur = "NF/" + Number + "/XII/" + thn;
                    break;
            }
            return NomorPermohonanFaktur;
        }
    }
   
}
