using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;
using System.Threading;

namespace SmmCoreDDD2019.Application.MasterAllowanceTypeDB.Command.CreateMasterAllowanceTypeDB
{
    public class CreateMasterAllowanceTypeDBCommandHandler : IRequestHandler<CreateMasterAllowanceTypeDBCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateMasterAllowanceTypeDBCommandHandler(ISMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateMasterAllowanceTypeDBCommand request, CancellationToken cancellationToken)
        {
            var entity = new MasterAllowanceType
            {
                AllowanceTypeName = request.AllowanceTypeName

            };

            _context.MasterAllowanceType.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new MasterAllowanceTypeDBCreated { MasterAllowanceTypeID = entity.Id.ToString() });
            return Unit.Value;
        }
    }
}
