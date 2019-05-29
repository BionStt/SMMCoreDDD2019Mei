using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataSPKLeasingDBs.Command.CreateDataSPKLeasingDB
{
    public class CreateDataSPKLeasingDBCommandHandler:IRequestHandler<CreateDataSPKLeasingDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;

        public CreateDataSPKLeasingDBCommandHandler(
            ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
            IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataSPKLeasingDBCommand request, CancellationToken cancellationToken)
        {

            var entity = new DataSPKLeasingDB
            {
              //  NoUrut = request.NoUrut,
                Angsuran= request.Angsuran,
                NoUrutLeasingCabang = request.NoUrutLeasingCabang,
                Mediator= request.Mediator,
                NamaCmo= request.NamaCmo,
                NoUrutKategoriBayaran= request.NoUrutKategoriBayaran,

                NoUrutKategoriPenjualan= request.NoUrutKategoriPenjualan,
                NoUrutSales = request.NoUrutSales,
                NoUrutSPKBaru= request.NoUrutSPKBaru,
                Tenor= request.Tenor,
                TglSurvei= request.TglSurvei
            



            };

            _context.DataSPKLeasingDB.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataSPKLeasingDBCreated { DataSPKLeasingDBID = entity.NoUrut.ToString() },cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
