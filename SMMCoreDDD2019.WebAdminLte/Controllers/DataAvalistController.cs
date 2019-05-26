using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Command.CreateDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKontrakAsuransiDBs.Command.CreateDataKontrakAsuransi;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Command.CreateDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakKreditAngsuranDemoDBs.Command.CreateDataKontrakKreditAngsuranDemo;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Command.CreateDataKontrakSurvei;
using SmmCoreDDD2019.Application.Extensions;
using SmmCoreDDD2019.Application.MasterBidangPekerjaanDBs.Query.GetNamaBidangPekerjaan;
using SmmCoreDDD2019.Application.MasterBidangUsahaDBs.Query.GetNamaBidangUsaha;
using SmmCoreDDD2019.Application.MasterBarangDBs.Queries.GetNamaBarangQr;
using SmmCoreDDD2019.Application.DataKonsumenAvalistDbs.Query.GetDataKonsumenAvalist;
using SmmCoreDDD2019.Application.DataKontrakSurveiDBs.Query.GetDataSurvei;
using SmmCoreDDD2019.Application.DataKontrakAngsuranDBs.Query.GetDataKontrakAngsuranByNoID;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKredit;
using SmmCoreDDD2019.Application.DataKontrakKreditDBs.Query.GetListDataKontrakKreditByNoID;

namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class DataAvalistController : BaseController
    {
      
        [HttpGet]
        public async Task<IActionResult> CreateDataKontrakSurvei()
        {

            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["StatusNikah"] = new SelectList(SelectListItemHelper.GetStatusMenikah(), "Value", "Text");
            ViewData["StatusRumah"] = new SelectList(SelectListItemHelper.GetStatusTempatTinggal(), "Value", "Text");
            ViewData["TingkatPendidikan"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");
            ViewData["HubunganDenganKel"] = new SelectList(SelectListItemHelper.GetHubunganKeluarga(), "Value", "Text");
            ViewData["HasilSurvei"] = new SelectList(SelectListItemHelper.GetHasilSurvei(), "Value", "Text");
            ViewData["LokasiTempatTinggal"] = new SelectList(SelectListItemHelper.GetLokasiTempatTinggal(), "Value", "Text");
            ViewData["TempatSurvei"] = new SelectList(SelectListItemHelper.GetTempatSurvei(), "Value", "Text");
            ViewData["Kulkas"] = new SelectList(SelectListItemHelper.GetKulkas(), "Value", "Text");
            ViewData["TV"] = new SelectList(SelectListItemHelper.GetTv(), "Value", "Text");
            ViewData["Toilet"] = new SelectList(SelectListItemHelper.GetToilet(), "Value", "Text");
            ViewData["LantaiRumah"] = new SelectList(SelectListItemHelper.GetLantaiRumah(), "Value", "Text");
            ViewData["AtapRumah"] = new SelectList(SelectListItemHelper.GetAtapRumah(), "Value", "Text");
            ViewData["DindingRumah"] = new SelectList(SelectListItemHelper.GetDindingRumah(), "Value", "Text");
            ViewData["GarasiRumah"] = new SelectList(SelectListItemHelper.GetGarasiRumah(), "Value", "Text");
            ViewData["KondisiPagar"] = new SelectList(SelectListItemHelper.GetKondisiPagar(), "Value", "Text");
            ViewData["KondisiTanaman"] = new SelectList(SelectListItemHelper.GetKondisiTanaman(), "Value", "Text");
            ViewData["KondisiJalanRumah"] = new SelectList(SelectListItemHelper.GetKondisiJalanRumah(), "Value", "Text");
            ViewData["KondisiFisikRumah"] = new SelectList(SelectListItemHelper.GetKondisiFisikRumah(), "Value", "Text");
            ViewData["SegmenRumah"] = new SelectList(SelectListItemHelper.GetSegmenRumah(), "Value", "Text");
            ViewData["PernahKredit"] = new SelectList(SelectListItemHelper.GetPernahKredit(), "Value", "Text");
            ViewData["JumlahTanggungan"] = new SelectList(SelectListItemHelper.GetJumlahTanggungan(), "Value", "Text");
            ViewData["Kerjasama"] = new SelectList(SelectListItemHelper.GetKerjasama(), "Value", "Text");
            ViewData["Karakter"] = new SelectList(SelectListItemHelper.GetKarakter(), "Value", "Text");

            var DataKonsumenAvalist = await Mediator.Send(new GetDataKonsumenAvalistQuery());
            ViewData["NamaKonsumen1"] = new SelectList(DataKonsumenAvalist.DataKonsumenAvalistDS, "NoCustomerAvalist", "NamaKonsumen");

            var NamaBarang = await Mediator.Send(new GetNamaBarangQrQuery());
            ViewData["NamaBarang"] = new SelectList(NamaBarang.MasterBarangDs, "NoUrutKendaraan", "NamaBarang");

            var NamaBidangPekerjaan1 = await Mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await Mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1.MasterBidangPekerjaanDs, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1.MasterBidangUsahaDs, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");


            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKontrakSurvei(CreateDataKontrakSurveiCommand CreateDataKontrakSurveiCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateDataKontrakSurveiCommand1);
                return RedirectToAction(nameof(DataAvalistController.CreateDataKontrakKredit), "DataAvalist");

            }


            return View(CreateDataKontrakSurveiCommand1);
        }
        [HttpGet]
        public IActionResult CreateDataKontrakKreditAngsuranDemo()
        {
            ViewData["AngsuranDimuka1"] = new SelectList(SelectListItemHelper.GetAngsuranDimuka(), "Value", "Text");
            ViewData["PolaAngsuran1"] = new SelectList(SelectListItemHelper.GetPolaAngsuran(), "Value", "Text");
            ViewData["CaraBayar1"] = new SelectList(SelectListItemHelper.GetCaraBayar(), "Value", "Text");
            //  var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            // ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKontrakKreditAngsuranDemo(CreateDataKontrakKreditAngsuranDemoCommand CreateDataKontrakKreditAngsuranDemoCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateDataKontrakKreditAngsuranDemoCommand1);
                // return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtPekerjaan), "DataPegawai");

            }


            return View(CreateDataKontrakKreditAngsuranDemoCommand1);
        }
        [HttpGet]
        public async Task<IActionResult> ListDataKontrakKredit()
        {
            var datalist = await Mediator.Send(new GetListDataKontrakKreditQuery());
            ViewData["DataKontrakList1"] = new SelectList(datalist.DataKontraKrediListDs, "NoUrutDataKontrakKredit1", "DataKontrakKredit");

            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ListDataKontrakKredit(string DataId)
        {
            //var RinciangAngsuran = await Mediator.Send(new GetDataKontrakAngsuranByNoIDQuery { Id = DataId });
            //var RinciangAngsuran1 = RinciangAngsuran.DataKontrakAngsuranDs.ToList();

            return RedirectToAction(nameof(DataAvalistController.CetakDataRincianAngsuran), "DataAvalist", new { Id = DataId });
        }

        public async Task<IActionResult> CetakDataRincianAngsuran(string Id)
        {
            var DataAngsuran = await Mediator.Send(new GetListDataKontrakKreditByNoIDQuery { Id = Id });
            var aa = DataAngsuran.DataKontraKrediListByIDDs.ToList();
            ViewBag.NamaKonsumen1 = aa[0].NamaKonsumen1;
            ViewBag.NamaPenjamin1 = aa[0].NamaPenjamin1;
            ViewBag.AlamatRumah = aa[0].AlamatRumah;
            ViewBag.NoTeleponRumah = aa[0].NoTeleponRumah;
            ViewBag.NoTeleponKantor = aa[0].NoTeleponKantor;
            ViewBag.NoTeleponUsaha = aa[0].NoTeleponUsaha;
            ViewBag.NoHP1 = aa[0].NoHP1;
            ViewBag.NoHP2 = aa[0].NoHP2;
            ViewBag.NilaiKontrak1 = aa[0].NilaiKontrak1;
            ViewBag.NilaiBunga1 = aa[0].NilaiBunga1;
            ViewBag.Tenor1 = aa[0].Tenor1;
            ViewBag.Angsuran1 = aa[0].Angsuran1;
            ViewBag.pinjamanPokok = aa[0].pinjamanPokok;


            var RinciangAngsuran = await Mediator.Send(new GetDataKontrakAngsuranByNoIDQuery { Id = Id });
            var RinciangAngsuran1 = RinciangAngsuran.DataKontrakAngsuranDs.ToList();
            return View(RinciangAngsuran1);
        }


        [HttpGet]
        public async Task<IActionResult> CreateDataKontrakKredit()
        {
            ViewData["AngsuranDimuka1"] = new SelectList(SelectListItemHelper.GetAngsuranDimuka(), "Value", "Text");
            ViewData["PolaAngsuran1"] = new SelectList(SelectListItemHelper.GetPolaAngsuran(), "Value", "Text");
            ViewData["CaraBayar1"] = new SelectList(SelectListItemHelper.GetCaraBayar(), "Value", "Text");

            var DataSurvei1 = await Mediator.Send(new GetDataSurveiQuery());
            ViewData["DataSurvei1"] = new SelectList(DataSurvei1.DataSurveiAvalistDS, "NoDataSurveiAvalist", "NamaKonsumen");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKontrakKredit(CreateDataKontrakKreditCommand CreateDataKontrakKreditCommand1)
        {
            if (ModelState.IsValid)
            {
                var aa = await Mediator.Send(CreateDataKontrakKreditCommand1);


                return RedirectToAction(nameof(HomeController.Index), "Home");
                //  return RedirectToAction(nameof(DataAvalistController.CetakDataRincianAngsuran), "DataAvalist",new { Id= aa});
            }


            return View(CreateDataKontrakKreditCommand1);
        }

        [HttpGet]
        public IActionResult CreateDataKontrakAsuransi()
        {
            //  var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            // ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKontrakAsuransi(CreateDataKontrakAsuransiCommand CreateDataKontrakAsuransiCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateDataKontrakAsuransiCommand1);
                // return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtPekerjaan), "DataPegawai");

            }


            return View(CreateDataKontrakAsuransiCommand1);
        }


        [HttpGet]
        public async Task<IActionResult> CreateDataKonsumenAvalist()
        {
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["StatusNikah"] = new SelectList(SelectListItemHelper.GetStatusMenikah(), "Value", "Text");
            ViewData["StatusRumah"] = new SelectList(SelectListItemHelper.GetStatusTempatTinggal(), "Value", "Text");
            ViewData["TingkatPendidikan"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");
            ViewData["HubunganDenganKel"] = new SelectList(SelectListItemHelper.GetHubunganKeluarga(), "Value", "Text");
            ViewData["SkalaUsaha1"] = new SelectList(SelectListItemHelper.GetSkalaUsaha(), "Value", "Text");

            var NamaBidangPekerjaan1 = await Mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await Mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1.MasterBidangPekerjaanDs, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1.MasterBidangUsahaDs, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

            //  var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            // ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataKonsumenAvalist(CreateDataKonsumenAvalistCommand CreateDataKonsumenAvalistCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateDataKonsumenAvalistCommand1);
                return RedirectToAction(nameof(DataAvalistController.CreateDataKontrakSurvei), "DataAvalist");

            }


            return View(CreateDataKonsumenAvalistCommand1);
        }









    }
}