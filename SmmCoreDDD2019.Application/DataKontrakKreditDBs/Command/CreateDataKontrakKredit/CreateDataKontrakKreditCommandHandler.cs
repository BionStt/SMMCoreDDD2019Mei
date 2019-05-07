using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using MediatR;
using SmmCoreDDD2019.Application.Extensions;
using SmmCoreDDD2019.Application.Interfaces;
using SmmCoreDDD2019.Domain.Entities;
using SmmCoreDDD2019.Persistence;

namespace SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.CreateDataKontrakKredit
{
    public class CreateDataKontrakKreditCommandHandler : IRequestHandler<CreateDataKontrakKreditCommand, Unit>
    {
        private readonly SMMCoreDDD2019DbContext _context;
        private readonly INotificationService _notificationService;
        private readonly IMediator _mediator;


        public CreateDataKontrakKreditCommandHandler(SMMCoreDDD2019DbContext context, INotificationService notificationService, IMediator mediator)
        {
            _context = context;
            _notificationService = notificationService;
            _mediator = mediator;

        }
        public async Task<Unit> Handle(CreateDataKontrakKreditCommand request, CancellationToken cancellationToken)
        {
            var pokokpinjaman1a = (request.HargaBarang + request.Asuransi + request.Administrasi) - request.UangMuka;
            var bungaflat11 = request.NilaiBunga / pokokpinjaman1a * 12 / request.LamaKredit*100;
            var entity = new DataKontrakKredit
            {

                NoRegisterKontrakKredit = DateTime.UtcNow.Date.Year.ToString() +
                DateTime.UtcNow.Date.Month.ToString() +
                DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGKK",

                NoRegisterSurvei = request.NoRegisterSurvei,
                TanggalKontrak = request.TanggalKontrak,
                PolaAngsuran = request.PolaAngsuran,
                CaraBayar = request.CaraBayar,
                HargaBarang = request.HargaBarang,
                PinjamanPokok = pokokpinjaman1a,
                UangMuka = request.UangMuka,
                Asuransi = request.Asuransi,
                Administrasi = request.Administrasi,
                BungaEff = request.BungaEff,
                BungaFlat = (decimal)bungaflat11,
                LamaKredit = request.LamaKredit,
                TanggalAngsuranBulanan = request.TanggalAngsuranBulanan,
                AngsuranDimuka = request.AngsuranDimuka,
                NilaiBunga = request.NilaiBunga,
                NilaiKontrak = request.NilaiKontrak,
                AngsuranBulanan = request.AngsuranBulanan,
                BiayaAdministrasiAngsuran = request.BiayaAdministrasiAngsuran,
                PenagihId= request.PenagihId


            };

            _context.DataKontrakKredit.Add(entity);
             await _context.SaveChangesAsync();
            var NoRegKontrakKredit = entity.NoUrutDataKontrakKredit;
       

            if (request.AngsuranDimuka == "1")
            {
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Int32.Parse(request.TanggalAngsuranBulanan));

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

                        _context.DataKontrakAngsuran.Add(new DataKontrakAngsuran
                        {

                            //            NoRegisterKontrakKredit = DateTime.UtcNow.Date.Year.ToString() +
                            //DateTime.UtcNow.Date.Month.ToString() +
                            //DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGKK",
                            NoRegisterKontrakKredit = NoRegKontrakKredit.ToString(),
                            AngsuranKe = angske,
                            TanggalAngsuran = DateTime.Now.Date,
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

                        _context.DataKontrakAngsuran.Add(new DataKontrakAngsuran
                        {

                            NoRegisterKontrakKredit = NoRegKontrakKredit.ToString(),
                            AngsuranKe = angske,
                            TanggalAngsuran = tglangsur.AddMonths(angske - 1),
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
                var tglangsur = new DateTime(DateTime.Now.Year, DateTime.Now.Month, Int32.Parse( request.TanggalAngsuranBulanan));
                var pokokpinjaman = request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka;
                var pokokpinjaman2 = (double)(request.HargaBarang + request.Asuransi + request.Administrasi - request.UangMuka);
                for (int angske = 1; angske <= request.LamaKredit; angske++)
                {
                    cicilanpokok = FinancialFunctional.Ppmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga1 = FinancialFunctional.Ipmt((double)BungaEfektif, angske, (int)request.LamaKredit, (double)(-pokokpinjaman), 0.0, 0);
                    bunga2 = AngsuranBln1a - (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000);
                    pokokpinjaman2 = Math.Round((((pokokpinjaman2 / 1000) * 1000) - (((cicilanpokok / 1000)) * 1000)), MidpointRounding.ToEven);
                    nilaibunga = Math.Round(((((nilaibunga) / 1000) * 1000) - (((((cicilanpokok / 1000)) * 1000) + ((bunga2 / 1000) * 1000)) - ((((cicilanpokok / 1000)) * 1000)))), MidpointRounding.ToEven);


                    _context.DataKontrakAngsuran.Add(new DataKontrakAngsuran
                    {
                        NoRegisterKontrakKredit = NoRegKontrakKredit.ToString(),
                        AngsuranKe = angske,
                        TanggalAngsuran = tglangsur.AddMonths(angske),
                        Angsuran = Math.Round((((((cicilanpokok / 1000)) * 1000) + ((bunga1 / 1000) * 1000))) / 1000, MidpointRounding.ToEven) * 1000,
                        Pokok = (Math.Round((cicilanpokok / 1000), MidpointRounding.ToEven) * 1000),
                        Bunga = bunga2,
                        SisaPokok = ((Math.Round(pokokpinjaman2 / 1000, MidpointRounding.ToEven) * 1000)),
                        SisaBunga = (Math.Round((nilaibunga) / 1000, MidpointRounding.ToEven) * 1000)


                    });


                }
            }

            await _context.SaveChangesAsync(cancellationToken);
            await _mediator.Publish(new DataKontrakKreditCreated { DataKontrakKreditID = entity.NoUrutDataKontrakKredit.ToString() });


            return Unit.Value;
        }
    }
}
