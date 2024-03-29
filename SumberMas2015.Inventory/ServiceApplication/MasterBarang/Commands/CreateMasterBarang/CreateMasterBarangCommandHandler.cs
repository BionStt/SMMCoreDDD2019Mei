﻿using MediatR;
using SumberMas2015.IntegrationEvent;
using SumberMas2015.Inventory.EventBus;
using SumberMas2015.Inventory.InfrastructureData.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SumberMas2015.Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang
{
    public class CreateMasterBarangCommandHandler : IRequestHandler<CreateMasterBarangCommand, Guid>
    {
        private readonly IInventoryEventBus _eventBus;
        private readonly InventoryContext _context;
        private readonly IMediator _mediator;
        public CreateMasterBarangCommandHandler(InventoryContext context, IMediator mediator, IInventoryEventBus eventBus)
        {
            _context = context;
            _mediator=mediator;
            _eventBus=eventBus;
        }

        public async Task<Guid> Handle(CreateMasterBarangCommand request, CancellationToken cancellationToken)
        {
            var masterBarangId= Guid.NewGuid();
            var mstBarang = Domain.MasterBarang.Create(request.NamaBarang, request.NomorRangka, request.NomorMesin, request.Merek
                , request.KapasitasMesin, request.HargaOff, request.BBn, request.TahunPerakitan, request.TypeKendaraan,request.UserName,request.USerNameId, masterBarangId);

            await _context.MasterBarang.AddAsync(mstBarang);

            await _eventBus.Publish(new MasterBarangAddedIntegrationEvent(
                request.NamaBarang,
                request.NomorRangka,
                request.NomorMesin,
                request.Merek,
                request.KapasitasMesin,
                request.HargaOff,
                request.BBn,
                request.TahunPerakitan,
                request.TypeKendaraan,
                masterBarangId
                ));

            await _context.SaveChangesAsync();

            //await _mediator.Publish(new CreateMasterBarangCreated {
            //      BBN = request.BBn,
            //      HargaOffTheRoad = request.HargaOff,
            //    KapasitasMesin = request.KapasitasMesin,
            //    Merek = request.Merek,
            //    NamaBarang = request.NamaBarang,
            //    NomorMesin = request.NomorMesin,
            //    NomorRangka = request.NomorRangka,
            //    TahunPerakitan = request.TahunPerakitan,
            //    TypeKendaraan = request.TypeKendaraan
            //}, cancellationToken);

            return mstBarang.MasterBarangId;
        }
    }
}
