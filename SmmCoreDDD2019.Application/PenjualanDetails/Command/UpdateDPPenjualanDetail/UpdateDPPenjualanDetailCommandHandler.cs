﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
using MediatR;
using Microsoft.EntityFrameworkCore;
using SmmCoreDDD2019.Application.Exceptions;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Interfaces;


namespace SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateDPPenjualanDetail
{
    public class UpdateDPPenjualanDetailCommandHandler : IRequestHandler<UpdateDPPenjualanDetailCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateDPPenjualanDetailCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateDPPenjualanDetailCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.PenjualanDetail
               .SingleAsync(c => c.NoPenjualanDetail == Int32.Parse(request.NoUrutPenjualanDetail), cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(CustomerDB), request.NoUrutPenjualanDetail);
            }
            entity.CheckDp = "1";


            _context.PenjualanDetail.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}