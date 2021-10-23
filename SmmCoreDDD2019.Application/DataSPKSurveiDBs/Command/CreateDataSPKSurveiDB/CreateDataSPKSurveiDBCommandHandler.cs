using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;

namespace SmmCoreDDD2019.Application.DataSPKSurveiDBs.Command.CreateDataSPKSurveiDB
{
    public class CreateDataSPKSurveiDBCommandHandler : IRequestHandler<CreateDataSPKSurveiDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataSPKSurveiDBCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }
        public async Task<Unit> Handle(CreateDataSPKSurveiDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataSPKBaruDB
            {
                //  NoUrutSPKBaru = request.NoUrutSPKBaru,
                NoRegistrasiSPK = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK",

                LokasiSpk = request.LokasiSpk,
                UserIdpeg = request.UserIdpeg,
                UserInput = request.UserInput
            };

            _context.DataSPKBaruDB.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            var nospkbaruid = entity.Id;
            //   await _context.SaveChangesAsync(cancellationToken);

            //   await _mediator.Publish(new DataSPKBaruDBCreated { DataSPKBaruDBID = entity.NoUrutSPKBaru.ToString() });

            //  return Unit.Value;


            var entity2 = DataSPKSurveiDB.CreateDataSPKSurveiDB(request.AlamatPemesan, request.HandphonePemesan, request.KecamatanPemesan, request.KelurahanPemesan,
                request.KodePosPemesan, request.KotaPemesan, request.NamaNPWP, request.NamaPemesan, request.NoKtpPemesan, request.NoNPWP
                , nospkbaruid, request.PekerjaanPemesan, request.PropinsiPemesan, request.TelpPemesan);

            _context.DataSPKSurveiDB.Add(entity2);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataSPKSurveiDBCreated { DataSPKSurveiDCID = nospkbaruid.ToString() },cancellationToken);

            return Unit.Value;



        }
    }
}
