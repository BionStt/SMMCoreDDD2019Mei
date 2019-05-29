using System;
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
namespace SmmCoreDDD2019.Application.StokUnits.Command.UpdateStokUnitPembatalanPj
{
    public class UpdateStokUnitPembatalanPjCommandHandler : IRequestHandler<UpdateStokUnitPembatalanPjCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;

        public UpdateStokUnitPembatalanPjCommandHandler(ISMMCoreDDD2019DbContext context)
        {
            _context = context;
        }
        public async Task<Unit> Handle(UpdateStokUnitPembatalanPjCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.StokUnit
                .SingleAsync(c => c.NoUrutSo == Int32.Parse(request.NoUrutSO), cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(StokUnit), request.NoUrutSO);
            }
            entity.Jual = null;
            entity.Kembali= null;
        
            _context.StokUnit.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
