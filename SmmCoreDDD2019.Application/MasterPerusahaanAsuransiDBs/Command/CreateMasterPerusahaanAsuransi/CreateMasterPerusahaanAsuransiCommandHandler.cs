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
namespace SmmCoreDDD2019.Application.MasterPerusahaanAsuransiDBs.Command.CreateMasterPerusahaanAsuransi
{
    public class CreateMasterPerusahaanAsuransiCommandHandler : IRequestHandler<CreateMasterPerusahaanAsuransiCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateMasterPerusahaanAsuransiCommandHandler(SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateMasterPerusahaanAsuransiCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterPerusahaanAsuransi
            {
                KodeAsuransi = request.KodeAsuransi,
                NamaAsuransi = request.NamaAsuransi,
                AlamatAsuransi = request.AlamatAsuransi,
                KelurahanAsuransi = request.KelurahanAsuransi,
                KecamatanAsuransi= request.KecamatanAsuransi,
                KotaAsuransi= request.KotaAsuransi,
                PropinsiAsuransi= request.PropinsiAsuransi,
                KodePosAsuransi= request.KodePosAsuransi,
                TelpAsuransi= request.TelpAsuransi,
                FaxAsuransi= request.FaxAsuransi,
                PihakBerwenang= request.PihakBerwenang

            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new MasterPerusahaanAsuransiCreated { MasterPerusahaanAsuransiID = entity.NoUrutPerusahaanAsuransi.ToString() });
            return Unit.Value;
        }
    }
}
