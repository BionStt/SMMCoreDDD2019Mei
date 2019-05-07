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

namespace SmmCoreDDD2019.Application.PembelianPODetails.Command.CreatePembelianPODetail
{
    public class CreatePembelianPODetailCommandHandler : IRequestHandler<CreatePembelianPODetailCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePembelianPODetailCommandHandler(SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePembelianPODetailCommand request, CancellationToken cancellationToken)
        {
            var entity = new PembelianPODetail
            {
                NoUrutPo = request.NoUrutPo,
                NoUrutMasterBarang = request.NoUrutMasterBarang,
                OffTheRoad = request.OffTheRoad,
                Bbn = request.Bbn,
                Diskon= request.Diskon,
                Warna = request.Warna,
                Qty = request.Qty,
                Keterangan = request.Keterangan

            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PembelianPODetailCreated { PembelianPoDetailID = entity.NoUrutPoDet.ToString() });
            return Unit.Value;

        }
    }
}
