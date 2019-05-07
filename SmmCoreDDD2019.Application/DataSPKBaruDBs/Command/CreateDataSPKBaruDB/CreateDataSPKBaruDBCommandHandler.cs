using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;


namespace SmmCoreDDD2019.Application.DataSPKBaruDBs.Command.CreateDataSPKBaruDB
{
    public class CreateDataSPKBaruDBCommandHandler : IRequestHandler<CreateDataSPKBaruDBCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataSPKBaruDBCommandHandler(
            SMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataSPKBaruDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataSPKBaruDB
            {
              //  NoUrutSPKBaru = request.NoUrutSPKBaru,
              NoRegistrasiSPK = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK",

                LokasiSpk= request.LokasiSpk,
                Terinput= request.Terinput,
                TglInput= request.TglInput,
                Tolak= request.Tolak,
                UserIdpeg = request.UserIdpeg,

                UserInput= request.UserInput



            };

            _context.DataSPKBaruDB.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

           await _mediator.Publish(new DataSPKBaruDBCreated { DataSPKBaruDBID = entity.NoUrutSPKBaru.ToString() });

            return Unit.Value;


            //  throw new NotImplementedException();
        }
    }
}
