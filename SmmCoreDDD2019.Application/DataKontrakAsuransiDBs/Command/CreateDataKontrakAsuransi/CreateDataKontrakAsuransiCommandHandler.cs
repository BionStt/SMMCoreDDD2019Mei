using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;
namespace SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.CreateDataKontrakAsuransi
{
    public class CreateDataKontrakAsuransiCommandHandler : IRequestHandler<CreateDataKontrakAsuransiCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateDataKontrakAsuransiCommandHandler(SMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateDataKontrakAsuransiCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataKontrakAsuransi
            {
                NoRegistrasiKontrakAsuransi = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGKA",

                NoRegistrasiKontrakKredit = request.NoRegistrasiKontrakKredit,
                KodeAsuransi = request.KodeAsuransi,
                JenisAsuransi = request.JenisAsuransi,
                TanggalMulaiAsuransi = request.TanggalMulaiAsuransi,
                TanggalAkhirAsuransi= request.TanggalAkhirAsuransi,
                LamaAsuransi = request.LamaAsuransi,
                NilaiPertanggungan = request.NilaiPertanggungan,
                BiayaAsuransi = request.BiayaAsuransi



            };

            _context.DataKontrakAsuransi.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new DataKontrakAsuransiCreated { DataKontrakAsuransiID = entity.NoUrutDataAsuransi });


            return Unit.Value;
        }
    }
}
