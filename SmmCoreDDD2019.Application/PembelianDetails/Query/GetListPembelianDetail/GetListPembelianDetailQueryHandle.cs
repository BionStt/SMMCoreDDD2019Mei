using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Persistence;
using System.Threading;

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListPembelianDetail
{
    public class GetListPembelianDetailQueryHandle : IRequestHandler<GetListPembelianDetailQuery, GetListPembelianDetailViewModel>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetListPembelianDetailQueryHandle(SMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetListPembelianDetailViewModel> Handle(GetListPembelianDetailQuery request, CancellationToken cancellationToken)
        {
            var model = new GetListPembelianDetailViewModel();
            try
            {

            var aa = await (from a in _context.Pembelian
                            join b in _context.PembelianDetail on a.KodeBeli equals b.KodeBeli
                            join c in _context.MasterBarangDB on b.KodeBrg equals c.NoUrutTypeKendaraan
                          //  join d in _context.StokUnit on b.KodeBeliDetail equals d.KodeBeliDetail
                               where a.KodeBeli == Int32.Parse(request.Id)
                            select new {
                                NoUrutPembelianDetail = b.KodeBeliDetail,
                                NamaBarang1 = c.NamaBarang,
                                HargaOff = string.Format("{0:c}",c.Harga),
                                BBN1 = string.Format("{0:c}",c.BBN),
                                HargaOTr =string.Format("{0:c}",(c.Harga)),
                                Diskon =string.Format("{0:c}",b.Diskon),
                                SellIn =string.Format("{0:c}",b.SellIn),
                                Qty1 =b.Qty ,
                                Count1=_context.StokUnit.Count(x=>x.KodeBeliDetail==b.KodeBeliDetail)
                            }

               ).ToListAsync(cancellationToken);
          

            model.DataPembelianDetailDs = _mapper.Map<IEnumerable<GetListPembelianDetailLookUpModel>>(aa);
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e.InnerException);
                Console.WriteLine("{0}", e.Message);
                Console.WriteLine("{0}", e.Source);
                Console.WriteLine("{0}", e.StackTrace);
                Console.WriteLine("{0}", e.Data);
            }
            //var model = new GetListPembelianDetailViewModel
            //{
            //   
            //};

            return model;
            //return new GetListPembelianDetailViewModel
            //{
            //    DataPembelianDetailDs = await _context.PembelianPO.ProjectTo<GetListPembelianDetailLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
