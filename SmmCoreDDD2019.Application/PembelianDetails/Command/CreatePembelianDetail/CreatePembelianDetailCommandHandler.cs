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


namespace SmmCoreDDD2019.Application.PembelianDetails.Command.CreatePembelianDetail
{
    public class CreatePembelianDetailCommandHandler : IRequestHandler<CreatePembelianDetailCommand>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePembelianDetailCommandHandler(SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePembelianDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = new PembelianDetail
            {
                KodeBeli = request.KodeBeli,
                KodeBrg = request.KodeBrg,
                HargaOffTheRoad= request.HargaOffTheRoad,
                BBN= request.BBN,
                Qty = request.Qty,
                Diskon = request.Diskon,
                SellIn = request.SellIn,

                Diskon2 = Math.Round((request.Diskon??0) / 110 * 100),
             
                SellIn2 = Math.Round((request.SellIn ?? 0) / 110 * 100), 
                Harga1 = Math.Round((request.HargaOffTheRoad ?? 0 )/ 110 * 100),
                HargaPPN = ((request.HargaOffTheRoad??0) + (-(Math.Round((request.HargaOffTheRoad ?? 0) / 110 * 100)))),
                DiskonPPN = ((request.Diskon??0) + (-(Math.Round((request.Diskon??0) / 110 * 100)))),
                SellInPPN= ((request.SellIn??0) + (-(Math.Round((request.SellIn??0) / 110 * 100))))
            };

            _context.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PembelianDetailCreated { PembelianDetailID = entity.KodeBeliDetail.ToString() });
            return Unit.Value;
        }
    }
}
