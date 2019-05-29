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

namespace SmmCoreDDD2019.Application.PenjualanPiutangDB.Command.CreatePenjualanPiutang
{
    public class CreatePenjualanPiutangCommandHandler : IRequestHandler<CreatePenjualanPiutangCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePenjualanPiutangCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePenjualanPiutangCommand request, CancellationToken cancellationToken)
        {
            var entity = new PenjualanPiutang
            {
                TanggalLunas = request.TanggalLunas,
                KodePenjualanDetail = request.KodePenjualanDetail,
                Keterangan = request.Keterangan,
             

            };

            _context.PenjualanPiutang.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PenjualanPiutangCreated { PenjualanPiutangID = entity.KodePenjualanDetail.ToString() },cancellationToken);
            return Unit.Value;
        }
    }
}
