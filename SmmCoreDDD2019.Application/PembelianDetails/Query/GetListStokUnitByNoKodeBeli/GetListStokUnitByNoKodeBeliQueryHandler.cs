using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.PembelianDetails.Query.GetListStokUnitByNoKodeBeli
{
    public class GetListStokUnitByNoKodeBeliQueryHandler : IRequestHandler<GetListStokUnitByNoKodeBeliQuery, GetListStokUnitByNoKodeBeliViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetListStokUnitByNoKodeBeliQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetListStokUnitByNoKodeBeliViewModel> Handle(GetListStokUnitByNoKodeBeliQuery request, CancellationToken cancellationToken)
        {
            var model = new GetListStokUnitByNoKodeBeliViewModel();
            try
            {

                var aa = await(from a in _context.StokUnit
                               join b in _context.MasterBarangDB on a.MasterBarangDBId equals b.Id
                               where a.PembelianDetailId == Int32.Parse(request.Id)
                               select new
                               {
                                   NoUrutSO = a.Id,
                                   NamaBarang1 = string.Format("{0} - {1} - {2:c} - {3:c} - {4:c}",b.Merek,b.NamaBarang, b.Harga,b.BBN, b.Harga+b.BBN),
                                   NoRangka1 = a.NoRangka,
                                   NoMesin1 = a.NoMesin,
                                   Warna1 = a.Warna
                                
                               }

                   ).ToListAsync(cancellationToken);


                model.DataStokUnitDs = _mapper.Map<IEnumerable<GetListStokUnitByNoKodeBeliLookUpModel>>(aa);
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
