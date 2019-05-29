﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MediatR;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;

namespace SmmCoreDDD2019.Application.DataSPKKreditDBs.Command.DeleteDataSPKKreditDB
{
    public class DeleteDataSPKKreditDBCommandHandler : IRequestHandler<DeleteDataSPKKreditDBCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public DeleteDataSPKKreditDBCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeleteDataSPKKreditDBCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.DataSPKKreditDB
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(DataSPKKreditDB), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerId);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(Customer), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.DataSPKKreditDB.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
            // throw new NotImplementedException();
        }
    }
}
