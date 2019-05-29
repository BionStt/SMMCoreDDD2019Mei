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


namespace SmmCoreDDD2019.Application.StokUnits.Command.CreateStokUnit
{
    public class CreateStokUnitCommandHandler : IRequestHandler<CreateStokUnitCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateStokUnitCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateStokUnitCommand request, CancellationToken cancellationToken)
        {
            var entity = new StokUnit
            {
                KodeBeliDetail = request.KodeBeliDetail,
                KodeBrg = request.KodeBrg,
                NoRangka = request.NoRangka,
                NoMesin = request.NoMesin,
                Warna = request.Warna,
                Harga = request.Harga,
                Diskon = request.Diskon,
                SellIn = request.SellIn,
                Harga1 = Math.Round((request.Harga??0) / 110 * 100),
                Diskon2 = Math.Round((request.Diskon??0) / 110 * 100),
                SellIn2 = Math.Round((request.SellIn??0) / 110 * 100),
                HargaPPN = (((request.Harga??0)) + (-(Math.Round((request.Harga??0) / 110 * 100)))),
                DiskonPPN = (((request.Diskon??0)) + (-(Math.Round((request.Diskon??0) / 110 * 100)))),
                SellInPPN = (((request.SellIn??0)) + (-(Math.Round((request.SellIn??0) / 110 * 100))))


              };
            _context.StokUnit.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
     
            await _mediator.Publish(new StokUnitCreated { StokUnitID = entity.NoUrutSo.ToString() },cancellationToken);
            return Unit.Value;
        }
    }
}
