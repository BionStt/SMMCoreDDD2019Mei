using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;


namespace SmmCoreDDD2019.Application.CustomerDBs.Commands.CreateCustomerDB
{
    public class CreateCustomerCommandHandler : IRequestHandler<CreateCustomerCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateCustomerCommandHandler(SMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }

        public async Task<Unit> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var entity = new CustomerDB
            {
                // CustomerID = request.CustomerID,
                NoKodeCustomer = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "CUST",

                Email = request.Email,
                Alamat = request.Alamat,
                AlamatKirim = request.AlamatKirim,
                Faks = request.Faks,
                Handphone = request.Handphone,
                Jual = request.Jual,
                Kecamatan = request.Kecamatan,
                Kelurahan = request.Kelurahan,
                KodePos = request.KodePos,
                Kota = request.Kota,
                Propinsi=request.Propinsi,
                Nama = request.Nama,
                NamaBPKB = request.NamaBPKB,
                NoKtp = request.NoKtp,
             
                Telp = request.Telp,
                TelpKantor = request.TelpKantor,
                TglLahir = request.TglLahir,
                KodeBidangPekerjaan = request.KodeBidangPekerjaan,
                NamaBidangPekerjaan=request.NamaBidangPekerjaan,
                KodeBidangUsaha=request.KodeBidangUsaha,
                NamaBidangUsaha=request.NamaBidangUsaha,
                UserIDPeg = request.UserIDPeg,
                UserInput = request.UserInput
                

            };

            _context.CustomerDB.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new CustomerCreated { CustomerId = entity.CustomerID });


            return Unit.Value;
            //  throw new NotImplementedException();
        }
    }
}
