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

namespace SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQrByNoUrut
{
    public class GetNamaBarangQrByNoUrutQueryHandler : IRequestHandler<GetNamaBarangQrByNoUrutQuery, GetNamaBarangQrByNoUrutViewModel>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly IMapper _mapper;
        public GetNamaBarangQrByNoUrutQueryHandler(ISMMCoreDDD2019DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<GetNamaBarangQrByNoUrutViewModel> Handle(GetNamaBarangQrByNoUrutQuery request, CancellationToken cancellationToken)
        {
            var databarang = await (from a  in _context.MasterBarangDB
                                    where a.Id == Int32.Parse(request.Id)
                                    select new { HargaOff = a.Harga, BBN1 =a.BBN}
                ).ToListAsync(cancellationToken);
            var model = new GetNamaBarangQrByNoUrutViewModel
            {
                MasterBarangDs = _mapper.Map<IEnumerable<GetNamaBarangQrByNoUrutLookUpModel>>(databarang)
            };
            return model;


            //return new GetNamaBarangQrByNoUrutViewModel
            //{
            //    MasterBarangDs = await _context.MasterBarangDB.ProjectTo<GetNamaBarangQrByNoUrutLookUpModel>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken)
            //};
        }
    }
}
