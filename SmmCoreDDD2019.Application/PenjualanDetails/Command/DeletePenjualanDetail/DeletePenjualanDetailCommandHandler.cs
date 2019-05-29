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

namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.DeletePenjualanDetail
{
    public class DeletePenjualanDetailCommandHandler : IRequestHandler<DeletePenjualanDetailCommand>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public DeletePenjualanDetailCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(DeletePenjualanDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.PenjualanDetail
               .FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(PenjualanDetail), request.Id);
            }

            //var hasOrders = _context.Orders.Any(o => o.CustomerId == entity.CustomerID);
            //if (hasOrders)
            //{
            //    throw new DeleteFailureException(nameof(CustomerDB), request.Id, "There are existing orders associated with this customer.");
            //}

            _context.PenjualanDetail.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}