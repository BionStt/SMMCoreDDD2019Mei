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

namespace SmmCoreDDD2019.Application.Penjualans.Command.CreatePenjualan
{
    public class CreatePenjualanCommandHandler : IRequestHandler<CreatePenjualanCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePenjualanCommandHandler(SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePenjualanCommand request, CancellationToken cancellationToken)
        {
            var entity = new Penjualan
            {
                NoRegistrasiPenjualan = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGPJ",

                NoUrutSPK = request.NoUrutSPK,
                TanggalPenjualan= request.TanggalPenjualan,
                KodeKonsumen= request.KodeKonsumen,
                KodeLease= request.KodeLease,
                NoBuku= request.NoBuku,
                NoUrutSales = request.NoUrutSales,
                Keterangan = request.Keterangan,
                KategoriPenjualan= request.KategoriPenjualan,
                Mediator= request.Mediator,
                UserInputId = request.UserInputId,
                UserInput= request.UserInput
         

            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PenjualanCreated { PenjualanID = entity.KodePenjualan.ToString() });
            return Unit.Value;
        }
    }
}
