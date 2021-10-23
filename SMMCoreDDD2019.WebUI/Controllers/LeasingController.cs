using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.CustomerDBs.Commands.DeleteCustomerDB;
using SmmCoreDDD2019.Application.DataPerusahaans.Queries.GetNamaPerusahaanLeasingCetak;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetMerek;
using SmmCoreDDD2019.Application.MasterLeasingCabangDBs.Queries.GetCabangLeasing;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.DeletePenjualanDetail;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateCheckPenjualanDetail;
using SmmCoreDDD2019.Application.PenjualanDetails.Command.UpdateDPPenjualanDetail;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPBulanan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCekDPPenjualan2;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanBulanan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataCheckPenjualanDetailBulanan;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataDetailLeasingCetak;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPenjualanDetailByNo;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPenjualanDetailByNosin;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasing;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetDataPiutangLeasingMerek;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetak;
using SmmCoreDDD2019.Application.PenjualanDetails.Query.GetLeasingCetakBySearch;
using SmmCoreDDD2019.Application.PenjualanPiutangDB.Command.CreatePenjualanPiutang;
using SmmCoreDDD2019.Application.Penjualans.Command.DeletePenjualan;
using SmmCoreDDD2019.Application.PermohonanFakturDBs.Command.DeletePermohonanFaktur;
using SmmCoreDDD2019.Application.StokUnits.Command.UpdateStokUnitPembatalanPj;
using SmmCoreDDD2019.Application.StokUnits.Query.GetLaporanSO;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class LeasingController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var LeasingCetakDs = await Mediator.Send(new GetLeasingCetakQuery() );
          //  ViewData["DataKontrakList1"] = new SelectList(LeasingCetakDs.DataLeasingCetakDS, "NoUrutPenjualanDetail", "NamaKonsumen");
            return View(LeasingCetakDs.DataLeasingCetakDS.ToList());
        }
        public async Task<IActionResult> Index2(string Search)
        {
            var LeasingCetakDs = await Mediator.Send(new GetLeasingCetakBySearchQuery { ID= Search });
            return View(LeasingCetakDs.DataLeasingCetakDS.ToList());
        }

        public async Task <IActionResult> SuratJalan1(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }
        public async Task <IActionResult> SuratJalan2(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }
        public async Task <IActionResult> SuratJalan3(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }
        public async Task <IActionResult> SuratJalan4(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }
        public async Task<IActionResult> SuratJalanTunai(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery() );
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery {Id=Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);
        }
        public async Task<IActionResult> SIPBPKB(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }

        public async Task<IActionResult> SIPBPKB2(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }
        public async Task<IActionResult> PenagihanL(string Id)
        {
            var DataPerusahaan = await Mediator.Send(new GetNamaPerusahaanLeasingCetakQuery());
            var aa = DataPerusahaan.NamaPerusahaanBDs.ToList();
            ViewData["NamaP"] = aa[0].NamaPerusahaan;
            ViewData["AlamatP"] = aa[0].AlamatPerusahaan;
            ViewData["KelP"] = aa[0].KelurahanPerusahaan;
            ViewData["KecP"] = aa[0].KecamatanPerusahaan;
            ViewData["KotaP"] = aa[0].KotaPerusahaan;
            ViewData["PropinsiP"] = aa[0].PropinsiPerusahaan;
            ViewData["KodePosP"] = aa[0].KodePos;
            ViewData["ContakCs"] = aa[0].Cs;
            ViewData["TelpP"] = aa[0].Telp;

            var DataDetailLeasingCetak = await Mediator.Send(new GetDataDetailLeasingCetakQuery { Id = Id });
            var bb = DataPerusahaan.NamaPerusahaanBDs.ToList();
            return View(bb);

        }

        public async Task<IActionResult> LaporanStokUnit()
        {
            var LaporanSO = await Mediator.Send(new GetLaporanSOQuery());
            var LaporanSO1 = LaporanSO.LaporanSODs.ToList().OrderBy(x=>x.TypeKendaraan).OrderBy(x=>x.TanggalBeli);
            return View(LaporanSO1);
        }
        public async Task<IActionResult> CekPembayaranLeasing()
        {
            var DataLeasingCabang = await Mediator.Send(new GetCabangLeasingQuery());
            ViewData["DataLeasingCabang1"] = new SelectList(DataLeasingCabang.MasterLeasingCabangDs.ToList().OrderBy(x => x.NamaCab), "NoUrutLeasingCabang", "NamaCab");


            return View();

        }
        public async Task<IActionResult> CekPembayaranLeasingDetail(string submit, string Ket1, DateTime TglLunasLeasing, DateTime tgl1, DateTime tgl2, string KodeLeasing, string KodePj1n, string KodePj1a, DateTime tgl1a, DateTime tgl2a, string NourutPjDetaila, DateTime tgl1b, DateTime tgl2b)
        {
            switch (submit)
            {
                case "Cek":
                    if (KodePj1a != null)
                    {
                        CreatePenjualanPiutangCommand CreatePenjualanPiutangCommand1 = new CreatePenjualanPiutangCommand
                        {
                            Keterangan = Ket1,
                            TanggalLunas = TglLunasLeasing,
                            KodePenjualanDetail = int.Parse(KodePj1a)
                        };
                        var PiutangPj = await Mediator.Send(CreatePenjualanPiutangCommand1);

                    }

                    var dd = await Mediator.Send(new GetDataCekDPPenjualan2Query { IDLeasingCabang= KodeLeasing,TanggalPenjualan2=tgl2,TanggalPenjualan1=tgl1,TanggalPenjualan2a=tgl2a,TanggalPenjualan1a=tgl1a  });



                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["Tgl1b"] = tgl1b;
                    ViewData["Tgl2b"] = tgl2b;
                    ViewData["KodeLeasing"] = KodeLeasing;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(dd.CekDPPenjualan2DS.ToList().OrderBy(x => x.TanggalPenjualan), "NoUrutPenjualanDetail", "DataPenjualan");
                    ViewData["NourutPjDetaila"] = NourutPjDetaila;
                    return View();
                // return RedirectToAction(nameof(CekPjBulananDet));
                // break;


                default:
                    var cc = await Mediator.Send(new GetDataCekDPPenjualan2Query { IDLeasingCabang = KodeLeasing, TanggalPenjualan2 = tgl2, TanggalPenjualan1 = tgl1, TanggalPenjualan2a = tgl2a, TanggalPenjualan1a = tgl1a });

                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["Tgl1b"] = tgl1b;
                    ViewData["Tgl2b"] = tgl2b;
                    ViewData["KodeLeasing"] = KodeLeasing;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(cc.CekDPPenjualan2DS.ToList().OrderBy(x => x.TanggalPenjualan), "NoUrutPenjualanDetail", "DataPenjualan");
                    ViewData["NourutPjDetaila"] = NourutPjDetaila;
                    //     ViewData["DataPj1"] = new SelectList(ee.ToList().OrderBy(x => x.TglPj).Where(x=>x.CheckDp==null), "KodePj", "DataPj");
                    if (KodePj1a == null)
                    {
                    }
                    else
                    {
                        var aa = await Mediator.Send(new GetDataCekDPPenjualanQuery());

                        return View(aa.CekDPPenjualanDS.ToList());
                    }
                    return View();

            }

            return View();
        }

        public IActionResult CekDP()
        {
            return View();
        }

        public async Task <IActionResult> CekDPDetail(string submit, DateTime tgl1, DateTime tgl2, string KodePj1a, DateTime tgl1a, DateTime tgl2a)
        {
            switch (submit)
            {
                case "Cek":
                    if (KodePj1a == null)
                    {
                        return NotFound();
                    }
                    await Mediator.Send(new UpdateDPPenjualanDetailCommand{ NoUrutPenjualanDetail= KodePj1a });

                    var ee = await Mediator.Send(new GetDataCekDPBulananQuery {TanggalPenjualan2=tgl2,TanggalPenjualan1=tgl1,TanggalPenjualan1a=tgl1a,TanggalPenjualan2a=tgl2a });

                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(ee.CekDataCekDPBulananDS.ToList().OrderBy(x => x.TanggalPenjualan).Where(x => x.CheckDP == null), "NoUrutPenjualanDetail", "DataPenjualan");

                    //   return RedirectToAction(nameof(CekDPDetail));
                    //  return View(ee.ToList());
                    return View();




                default:
                    var cc = await Mediator.Send(new GetDataCekDPBulananQuery { TanggalPenjualan2 = tgl2, TanggalPenjualan1 = tgl1, TanggalPenjualan1a = tgl1a, TanggalPenjualan2a = tgl2a });


                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(cc.CekDataCekDPBulananDS.ToList().OrderBy(x => x.TanggalPenjualan).Where(x => x.CheckDP == null), "NoUrutPenjualanDetail", "DataPenjualan");

                    if (KodePj1a == null)
                    {
                    }
                    else
                    {
                        var aa = await Mediator.Send(new GetDataPenjualanDetailByNoQuery { Id= KodePj1a });


                        return View(aa.GetDataPenjualanDetailByNoDS.ToList());
                    }
                    return View();

            }

            return View();

        }

        public async Task<IActionResult> PiutangLeasing(string KodeLeasing)
        {
            var Leasing = await Mediator.Send(new GetCabangLeasingQuery());
            ViewData["leasing1"] = new SelectList(Leasing.MasterLeasingCabangDs.ToList().OrderBy(x => x.NamaCab), "NoUrutLeasingCabang", "NamaCab");

            if (KodeLeasing != null)
            {
                var aa = await Mediator.Send(new GetDataPiutangLeasingQuery { IdLeasing= KodeLeasing });

                return View(aa.DataPiutangLeasingDS.ToList().OrderBy(x => x.TanggalPenjualan));
            }
            return View();


        }
        public async Task<IActionResult> PiutangLeasingMerek(string KodeLeasing,string Merek1)
        {
            var Leasing = await Mediator.Send(new GetCabangLeasingQuery());
            ViewData["leasing1"] = new SelectList(Leasing.MasterLeasingCabangDs.ToList().OrderBy(x => x.NamaCab), "NoUrutLeasingCabang", "NamaCab");

            var Merek1a = await Mediator.Send(new GetMerekQuery());
            ViewData["Merek1"] = new SelectList(Merek1a.MasterBarangMerekDs.ToList().Distinct(), "Merek", "Merek");

            if (KodeLeasing != null)
            {
                var aa = await Mediator.Send(new GetDataPiutangLeasingMerekQuery {IdLeasing= KodeLeasing, Merek= Merek1 });

                return View(aa.DataPiutangLeasingMerekDS.ToList().OrderBy(x => x.TanggalPenjualan));
            }
            return View();


        }
        public async Task<IActionResult> InputPembatalanPenjualan(string Nosin1, string submit, string Nofakturr, string KOdePj11, string KodePjDet11, string KodeCust11, string NoSO11)
        {
            switch (submit)
            {
                case "Hapus":
                    if (Nofakturr != null)
                    {
                        await Mediator.Send(new DeletePermohonanFakturCommand{Id= Nofakturr });
                    }

                    if (KodePjDet11 != null)
                    {
                        await Mediator.Send(new DeletePenjualanDetailCommand {Id= KodePjDet11 });
                    }

                    if (KodeCust11 != null)
                    {
                        await Mediator.Send(new DeleteCustomerCommand { Id= KodeCust11 });
                    }

                    if (KOdePj11 != null)
                    {
                        await Mediator.Send(new DeletePenjualanCommand { Id= KOdePj11 });
                    }
                    if (NoSO11 != null)
                    {
                        await Mediator.Send(new UpdateStokUnitPembatalanPjCommand {NoUrutSO= NoSO11 } );
                    }
                    return RedirectToAction(nameof(InputPembatalanPenjualan));


                case "Cari":
                    if (Nosin1 != null)
                    {
                        var aa = await Mediator.Send(new GetDataPenjualanDetailByNosinQuery {Id= Nosin1 });
                        var ff = aa.GetDataPenjualanDetailByNosinDS.ToList();
                        if (ff != null)
                        {

                            ViewData["NoFaktur"] = ff[0].NoFaktur;
                            ViewData["KodePj1f"] = ff[0].NoUrutPenjualan;
                            ViewData["KOdePjDet"] = ff[0].NoUrutPenjualanDetail;
                            ViewData["KodeCust"] = ff[0].KodeKonsumen;
                            ViewData["KodeSO1"] = ff[0].NoUrutSO;
                        }

                        return View(aa.GetDataPenjualanDetailByNosinDS.ToList());
                    }
                    return View();

                // break;
                default:
                    break;

            }



            return View();
        }
        public IActionResult CekLaporanPenjualanBulanan()
        {
            return View();
        }

        public async Task<IActionResult> CekLaporanPenjualanBulananDetail(string submit, DateTime tgl1, DateTime tgl2, string KodePj1n, string KodePj1a, DateTime tgl1a, DateTime tgl2a, string NourutPjDetaila, DateTime tgl1b, DateTime tgl2b)
        {
            switch (submit)
            {
                case "Cek":
                    if (KodePj1a != null)
                    {
                        // kode pj detail ??
                        await Mediator.Send(new UpdateCheckPenjualanDetailCommand {NoUrutPenjualanDetail= KodePj1a, UserInput="" });
                    }

                    var dd = await Mediator.Send(new GetDataCheckPenjualanBulananQuery {TanggalPenjualan1=tgl1,TanggalPenjualan1a=tgl1b,TanggalPenjualan2=tgl2,TanggalPenjualan2a =tgl2b});


                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["Tgl1b"] = tgl1b;
                    ViewData["Tgl2b"] = tgl2b;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(dd.CheckPenjualanBulananDs.ToList().OrderBy(x => x.TanggalPenjualan), "KodePenjualan", "DataPenjualan");
                    ViewData["NourutPjDetaila"] = NourutPjDetaila;
                    return View();
                // return RedirectToAction(nameof(CekPjBulananDet));
                // break;

                default:
                    var cc = await Mediator.Send(new GetDataCheckPenjualanBulananQuery { TanggalPenjualan1 = tgl1, TanggalPenjualan1a = tgl1a, TanggalPenjualan2 = tgl2, TanggalPenjualan2a = tgl2a });

                    ViewData["Tgl1a"] = tgl1;
                    ViewData["Tgl2a"] = tgl2;
                    ViewData["Tgl1b"] = tgl1b;
                    ViewData["Tgl2b"] = tgl2b;
                    ViewData["KodePj1b"] = KodePj1a;
                    ViewData["DataPj1"] = new SelectList(cc.CheckPenjualanBulananDs.ToList().OrderBy(x => x.TanggalPenjualan), "KodePenjualan", "DataPenjualan");
                    ViewData["NourutPjDetaila"] = NourutPjDetaila;
                    //     ViewData["DataPj1"] = new SelectList(ee.ToList().OrderBy(x => x.TglPj).Where(x=>x.CheckDp==null), "KodePj", "DataPj");
                    if (KodePj1a == null)
                    {
                    }
                    else
                    {
                        //kodepj detail
                        var aa = await Mediator.Send(new GetDataCheckPenjualanDetailBulananQuery { Id= NourutPjDetaila });


                        return View(aa.GetDataPenjualanDetailByNosinDS.ToList());
                    }
                    return View();

            }
            return View();
        }











        }
    }