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

namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.CreatePejualanDetail
{
    public class CreatePejualanDetailCommandHandler : IRequestHandler<CreatePejualanDetailCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePejualanDetailCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePejualanDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = new PenjualanDetail
            {
                KodePenjualan = request.KodePenjualan,
                NoUrutSO= request.NoUrutSO,
                OffTheRoad= request.OffTheRoad,
                BBN= request.BBN,
                HargaOTR= request.HargaOTR,
                UangMuka= request.UangMuka,
                DiskonKredit= request.DiskonKredit,
                DiskonTunai= request.DiskonTunai,
                Subsidi = request.Subsidi,
                Promosi= request.Promosi,
                Komisi = request.Komisi,
                JoinPromo1= request.JoinPromo1,
                JoinPromo2= request.JoinPromo2,
                SPF= request.SPF,
                SellOut= request.SellOut,
                DendaWilayah= request.DendaWilayah

            };

            _context.PenjualanDetail.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new PenjualanDetailCreated { PenjualanDetailID = entity.NoPenjualanDetail.ToString() },cancellationToken);
            return Unit.Value;
        }
    }
}
