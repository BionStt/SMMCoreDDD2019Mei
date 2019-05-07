using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.CreatePermohonanFaktur
{
    public class CreatePermohonanFakturCommandHandler : IRequestHandler<CreatePermohonanFakturCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePermohonanFakturCommandHandler(SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePermohonanFakturCommand request, CancellationToken cancellationToken)
        {
            var entity = new PermohonanFakturDB
            {
               // TanggalMohonFaktur = request.TanggalMohonFaktur,
               NoRegistrasiFaktur = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGMHNFKT",

                KodePenjualanDetail= request.KodePenjualanDetail,
                TanggalLahir= request.TanggalLahir,
                NomorKTP= request.NomorKTP,
                NamaFaktur= request.NamaFaktur,
                Alamat= request.Alamat,
                Kelurahan = request.Kelurahan,
                Kecamatan= request.Kecamatan,
                Kota= request.Kota,
                Propinsi= request.Propinsi,
                KodePos = request.KodePos,
                Telepon= request.Telepon,
                HandphoneF= request.HandphoneF
       


            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PermohonanFakturCreated { PermohonanFakturID = entity.NoUrutFaktur.ToString() });
            return Unit.Value;
        }
    }
    
}
