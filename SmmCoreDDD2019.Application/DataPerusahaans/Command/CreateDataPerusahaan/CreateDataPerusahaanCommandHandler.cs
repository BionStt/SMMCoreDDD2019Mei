using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPerusahaans.Command.CreateDataPerusahaan
{
    public class CreateDataPerusahaanCommandHandler : IRequestHandler<CreateDataPerusahaanCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataPerusahaanCommandHandler(
           ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPerusahaanCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPerusahaan
            {
              //  KodeP = request.KodeP,
              NoRegDataPerusahaan = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGDP", 

                NamaP= request.NamaP,
                AlamatP= request.AlamatP,
                Kel= request.Kel,
                Kec= request.Kec,
                Kota= request.Kota,
                Propinsi=request.Propinsi,
                KodePos= request.KodePos,
                Telp= request.Telp,
                Cs= request.Cs
                
            };

            _context.DataPerusahaan.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPerusahaanCreated { DataPerusahanID = entity.Id.ToString() },cancellationToken);

            return Unit.Value;



          
        }
    }
}
