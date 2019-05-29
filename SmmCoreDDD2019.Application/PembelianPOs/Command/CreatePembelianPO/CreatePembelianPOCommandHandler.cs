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


namespace SmmCoreDDD2019.Application.PembelianPOs.Command.CreatePembelianPO
{
    public class CreatePembelianPOCommandHandler : IRequestHandler<CreatePembelianPOCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreatePembelianPOCommandHandler(ISMMCoreDDD2019DbContext context,
            INotificationService notificationService,
                IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreatePembelianPOCommand request, CancellationToken cancellationToken)
        {
            var entity = new PembelianPO
            {
               // TglPo = request.TglPo,
                NoDealer = request.NoDealer,
                Keterangan = request.Keterangan,
                UserId = request.UserId,
                UserInput = request.UserInput,
                PoAstra= request.PoAstra,
                NoRegistrasiPoPMB = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGPOPMB"

            };

            _context.PembelianPO.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            var entity2 = await _context.PembelianPO.FindAsync(entity.NoUrutPo);
            if (entity2==null)
            {
                throw new NotFoundException(nameof(PembelianPO), entity.NoUrutPo);
            }
            int thn = entity2.TglPo.Value.Year;
            int bln = entity2.TglPo.Value.Month;
            int KodePO = entity2.NoUrutPo;
            String Isi1 = string.Empty;
            if (bln == 1)
            { Isi1 = "PO" + KodePO + "/I/SM/" + thn; }
            else if (bln == 2) { Isi1 = "PO" + KodePO + "/II/SM/" + thn; }
            else if (bln == 3) { Isi1 = "PO" + KodePO + "/III/SM/" + thn; }
            else if (bln == 4) { Isi1 = "PO" + KodePO + "/IV/SM/" + thn; }
            else if (bln == 5) { Isi1 = "PO" + KodePO + "/V/SM/" + thn; }
            else if (bln == 6) { Isi1 = "PO" + KodePO + "/VI/SM/" + thn; }
            else if (bln == 7) { Isi1 = "PO" + KodePO + "/VII/SM/" + thn; }
            else if (bln == 8) { Isi1 = "PO" + KodePO + "/VIII/SM/" + thn; }
            else if (bln == 9) { Isi1 = "PO" + KodePO + "/IX/SM/" + thn; }
            else if (bln == 10) { Isi1 = "PO" + KodePO + "/X/SM/" + thn; }
            else if (bln == 11) { Isi1 = "PO" + KodePO + "/XI/SM/" + thn; }
            else { { Isi1 = "PO" + KodePO + "/XII/SM/" + thn; } }

            entity2.PoAstra = Isi1;
            _context.PembelianPO.Update(entity2);
            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new PembelianPoCreated { PembelianPoID = entity.NoUrutPo.ToString() },cancellationToken);
            return Unit.Value;

        }
    }
}
