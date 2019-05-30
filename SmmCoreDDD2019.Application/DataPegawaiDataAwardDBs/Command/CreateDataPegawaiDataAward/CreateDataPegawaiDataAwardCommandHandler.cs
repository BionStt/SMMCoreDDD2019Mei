using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;


namespace SmmCoreDDD2019.Application.DataPegawaiDataAwardDBs.Command.CreateDataPegawaiDataAward
{
    public class CreateDataPegawaiDataAwardCommandHandler : IRequestHandler<CreateDataPegawaiDataAwardCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;
        public CreateDataPegawaiDataAwardCommandHandler(
          ISMMCoreDDD2019DbContext context,
          INotificationService notificationService,
          IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;
        }

        public async Task<Unit> Handle(CreateDataPegawaiDataAwardCommand request, CancellationToken cancellationToken)
        {
            var entity = new DataPegawaiDataAward
            {
                AwardTitle = request.AwardTitle,
            CreateDate = request.CreateDate,
            UpdateDate = request.UpdateDate,
            IsDelete = request.IsDelete,
            Gift = request.Gift,
                Price = request.Price,
                Date = request.Date,
                Month = request.Month,
                EmployeeId = request.EmployeeId
            };

            _context.DataPegawaiDataAward.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            await _mediator.Publish(new DataPegawaiDataAwardCreated { DataPegawaiDataAwardID = entity.Id.ToString() }, cancellationToken);

            return Unit.Value;
        }
    }
}
