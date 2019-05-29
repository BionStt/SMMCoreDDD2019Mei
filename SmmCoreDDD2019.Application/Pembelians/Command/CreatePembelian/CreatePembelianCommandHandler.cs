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


namespace SmmCoreDDD2019.Application.Pembelians.Command.CreatePembelian
{
    public class CreatePembelianCommandHandler : IRequestHandler<CreatePembelianCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePembelianCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePembelianCommand request, CancellationToken cancellationToken)
        {
          


            var entity = new Pembelian
            {
              //  TglBeli = request.TglBeli,
              NoRegistrasiPembelian = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGPMB",

                Idsupplier = request.Idsupplier,
                JenisTransPmb = request.JenisTransPmb,
                Kredit = request.Kredit,
                Keterangan = request.Keterangan,
                UserInput = request.UserInput,
                UserInputId = request.UserInputId,
                NoPOPembelian = request.NoPOPembelian

            };

            _context.Pembelian.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PembelianCreated { PembelianID = entity.KodeBeli.ToString() },cancellationToken);
          
          

            return Unit.Value;

        }
    }
}
