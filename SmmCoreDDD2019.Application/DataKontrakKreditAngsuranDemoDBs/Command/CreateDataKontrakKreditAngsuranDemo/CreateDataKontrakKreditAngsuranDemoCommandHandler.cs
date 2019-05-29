using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Application.Extensions;
namespace SmmCoreDDD2019.Application.DataKontrakKreditAngsuranDemoDBs.Command.CreateDataKontrakKreditAngsuranDemo
{
    public class CreateDataKontrakKreditAngsuranDemoCommandHandler : IRequestHandler<CreateDataKontrakKreditAngsuranDemoCommand, Unit>
    {
        private readonly ISMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateDataKontrakKreditAngsuranDemoCommandHandler(ISMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
     
        public async Task<Unit> Handle(CreateDataKontrakKreditAngsuranDemoCommand request, CancellationToken cancellationToken)
        {
            if (request.AngsuranDimuka == "1")
            {
               var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, request.TanggalJatuhTempoBulanan);
              
                var BungaEfektif = request.BungaEff / 1200;
                var pokokpinjaman = (request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka;
                var pokokpinjaman2 = (double)((request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka);
                double AngsuranBln1a = (double)request.AngsuranBulanan;
                double cicilanpokok;
                double bunga1;
                double bunga2;
                double nilaibunga = (double)request.NilaiBunga;

                for (int angske = 1; angske <= (request.LamaKredit); angske++)
                {
                    if (angske == 1)
                    {
                        cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                        pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((AngsuranBln1a / 1000)) * 1000)), MidpointRounding.ToEven);

                        _context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                        {

                          
                            AngsKe = angske,
                            TglAngsuran = DateTime.Now.Date,
                            Angsuran = AngsuranBln1a,
                            Pokok = AngsuranBln1a,
                            Bunga = 0,
                            SisaPokok = pokokpinjaman2,
                            SisaBunga = nilaibunga

                          
                        });
                       
                    }
                    else
                    {
                        cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 1);
                        bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                        pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                        nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);

                        _context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                        {


                            AngsKe = angske,
                            TglAngsuran = tglangsur.AddMonths(angske - 1),
                            Angsuran = AngsuranBln1a,
                            Pokok = (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                            Bunga = bunga2,
                            SisaPokok = pokokpinjaman2,
                            SisaBunga = nilaibunga


                        });

                    }
                }
            }
            else
            {
                double AngsuranBln1a = (double)request.AngsuranBulanan;
              Double cicilanpokok;
                Double bunga1;
                Double bunga2;
                var BungaEfektif = request.BungaEff / 1200;
            double nilaibunga = (double)request.NilaiBunga;
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, request.TanggalJatuhTempoBulanan);
                var pokokpinjaman = request.HargaBarang +request.Asuransi + request.Administrasi - request.UangMuka;
                var pokokpinjaman2 = (double)(request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka);
                for (int angske = 1; angske <= request.LamaKredit; angske++)
                {
                    cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske,(int) request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                    pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                    nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);


                    _context.DataKontrakKreditAngsuranDemo.Add(new DataKontrakKreditAngsuranDemo
                    {
                       
                        AngsKe = angske,
                        TglAngsuran = tglangsur.AddMonths(angske),
                        Angsuran = Math.Round((((((cicilanpokok / 1000)) * 1000) + ((bunga1 / 1000) * 1000))) / 1000, MidpointRounding.ToEven) * 1000,
                        Pokok = (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                        Bunga = bunga2,
                        SisaPokok = ((Math.Round(pokokpinjaman2 / 1000, MidpointRounding.ToEven) * 1000)),
                        SisaBunga = (Math.Round((nilaibunga) / 1000, MidpointRounding.ToEven) * 1000)


                    });


                }
            }
          
         

            await _context.SaveChangesAsync(cancellationToken);
         // await _mediator.Publish(new DataKontrakKreditAngsuranDemoCreated { DataKontrakKreditAngsuranDemoID = entity.NoUrutDataKontrakKredit.ToString() });


            return Unit.Value;
        }
    }
}
