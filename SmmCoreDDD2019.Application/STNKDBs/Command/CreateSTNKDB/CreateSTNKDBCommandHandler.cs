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


namespace SmmCoreDDD2019.Application.STNKDBs.Command.CreateSTNKDB
{
    public class CreateSTNKDBCommandHandler : IRequestHandler<CreateSTNKDBCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateSTNKDBCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateSTNKDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new STNKDB
            {
                TanggalBayarSTNK = request.TanggalBayarSTNK,
                NoUrutFaktur= request.NoUrutFaktur,
                NoStnk= request.NoStnk,
                PajakStnk= request.PajakStnk,
                Birojasa= request.Birojasa,
                BiayaTambahan= request.BiayaTambahan,
                FormA= request.FormA,
                NomorPlat = request.NomorPlat,
                Perwil= request.Perwil,
                PajakProgresif=request.PajakProgresif,
                BbnPabrik= request.BbnPabrik,
                ProgresifKe= request.ProgresifKe
 

            };
            _context.STNKDB.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new STNKDBCreated { STNKDBID = entity.NoUrutStnk.ToString() },cancellationToken);
            return Unit.Value;
        }
    }
}
