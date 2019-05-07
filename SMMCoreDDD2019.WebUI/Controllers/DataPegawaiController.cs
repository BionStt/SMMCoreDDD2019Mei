using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Queries.GetNamaPegawai;
using SmmCoreDDD2019.Application.DataPegawaiDataKeluargas.Command.CreateDataPegawaiDataKeluarga;
using SmmCoreDDD2019.Application.DataPegawaiDataPribadiInput.Command.CreateDataPegawaiDataPribadiInput;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPekerjaans.Command.CreateDataPegawaiDataRiwayatPekerjaan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPendidikans.Command.CreateDataPegawaiDataRiwayatPendidikan;
using SmmCoreDDD2019.Application.DataPegawaiDataRiwayatPelatihans.Command.CreateDataPegawaiDataRiwayatPelatihan;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Command.CreateDataPegawaiFoto;
using SmmCoreDDD2019.Application.DataPegawaiDataOrmass.Command.CreateDataPegawaiDataOrmas;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;
using SmmCoreDDD2019.Application.DataPegawaiFotos.Queries.GetDataPegawaiList;
using SmmCoreDDD2019.Application.DataPegawaiDataJabatans.Commands.CreateDataPegawaiDataJabatan;
using SmmCoreDDD2019.Application.MasterJenisJabatanDBs.Query.GetNamaJabatan;
using SmmCoreDDD2019.Application.Extensions;

namespace SMMCoreDDD2019.WebUI.Controllers
{
    public class DataPegawaiController : BaseController
    {
       
        [HttpGet]
        public IActionResult CreateDataPegawai()
        {
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(),"Value","Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["StatusNikah"] = new SelectList(SelectListItemHelper.GetStatusMenikah(), "Value", "Text");
            ViewData["StatusRumah"] = new SelectList(SelectListItemHelper.GetStatusTempatTinggal(), "Value", "Text");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawai(CreateDataPegawaiDataPribadiInputCommand DataPegawaiViewModel)
        {
            if (ModelState.IsValid)
            {
             
                await Mediator.Send(DataPegawaiViewModel);
                
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDataKeluarga), "DataPegawai");
            }
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["StatusNikah"] = new SelectList(SelectListItemHelper.GetStatusMenikah(), "Value", "Text");
            ViewData["StatusRumah"] = new SelectList(SelectListItemHelper.GetStatusTempatTinggal(), "Value", "Text");
            return View(DataPegawaiViewModel);
        }

        public async Task<IActionResult> CreateDataPegawaiDataKeluarga()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["PendidikanT"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");
            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs.OrderByDescending(x=>x.IDPegawai), "IDPegawai", "NamaDepan");
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["Darurat"] = new SelectList(SelectListItemHelper.GetEmergencyCall(), "Value", "Text");
            ViewData["HubunganKel"] = new SelectList(SelectListItemHelper.GetHubunganKeluarga(), "Value", "Text");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDataKeluarga(CreateDataPegawaiDataKeluargaCommand DataKeluargaViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataKeluargaViewModel);

                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDataKeluarga), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["JenisKelamin1"] = new SelectList(SelectListItemHelper.GetJenisKelaminList(), "Value", "Text");
            ViewData["Agama1"] = new SelectList(SelectListItemHelper.GetAgamaList(), "Value", "Text");
            ViewData["Darurat"] = new SelectList(SelectListItemHelper.GetEmergencyCall(), "Value", "Text");
            ViewData["HubunganKel"] = new SelectList(SelectListItemHelper.GetHubunganKeluarga(), "Value", "Text");
            return View(DataKeluargaViewModel);
        }

        [HttpGet]
        public async Task<IActionResult>  CreateDataPegawaiDtPekerjaan()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtPekerjaan(CreateDataPegawaiDataRiwayatPekerjaanCommand DataPegawaiDtPekerjaanViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPegawaiDtPekerjaanViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtPekerjaan), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            return View(DataPegawaiDtPekerjaanViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> CreateDataPegawaiDtPendidikan()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["TingkatPendidikan"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtPendidikan(CreateDataPegawaiDataRiwayatPendidikanCommand DataPegawaiDtPendidikanViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPegawaiDtPendidikanViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtPendidikan), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["TingkatPendidikan"] = new SelectList(SelectListItemHelper.GetPendidikanTerakhir(), "Value", "Text");
            return View(DataPegawaiDtPendidikanViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreateDataPegawaiDtPelatihan()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtPelatihan(CreateDataPegawaiDataRiwayatPelatihanCommand DataPegawaiDtPelatihanViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPegawaiDtPelatihanViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtPelatihan), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            return View(DataPegawaiDtPelatihanViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreateDataPegawaiDtOrmas()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtOrmas(CreateDataPegawaiDataOrmasCommand DataPegawaiDtOrmasViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPegawaiDtOrmasViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtOrmas), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            return View(DataPegawaiDtOrmasViewModel);
        }
        [HttpGet]
        public async Task<IActionResult> CreateDataPegawaiDtFoto()
        {
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
         //   ViewData["KodeBarcode1"] = "MP" + DateTime.Now.Date.Day + DateTime.Now.Date.Month + DateTime.Now.Date.Year ;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtFoto(CreateDataPegawaiFotoCommand DataPegawaiDtFotoViewModel, IFormFile KirimFoto1, string test1)
        {
            if (ModelState.IsValid)
            {
                if (test1 !=null)
                {
                    var base64Data = Regex.Match(test1, @"data:image/(?<type>.+?),(?<data>.+)").Groups["data"].Value;
                    byte[] tempBytes = Convert.FromBase64String(base64Data);
                    DataPegawaiDtFotoViewModel.Foto = tempBytes;
                }
                else
                {
                    if (KirimFoto1 != null && KirimFoto1.Length > 0)
                    {
                        DataPegawaiDtFotoViewModel.Foto = GetByteArrayFromImage(KirimFoto1);
                    }
                }
                await Mediator.Send(DataPegawaiDtFotoViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtFoto), "DataPegawai");
            }
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            return View(DataPegawaiDtFotoViewModel);
        }

        private byte[] GetByteArrayFromImage(IFormFile file)
        {
            using (var target = new MemoryStream())
            {
                file.CopyTo(target);
                Bitmap gmb = new Bitmap(100, 100);
                gmb.Save(target, System.Drawing.Imaging.ImageFormat.Jpeg);
                return target.ToArray();
            }
        }
        private static double GetCoordinateDouble(PropertyItem propItem)
        {
            uint degreesNumerator = BitConverter.ToUInt32(propItem.Value, 0);
            uint degreesDenominator = BitConverter.ToUInt32(propItem.Value, 4);
            double degrees = degreesNumerator / (double)degreesDenominator;


            uint minutesNumerator = BitConverter.ToUInt32(propItem.Value, 8);
            uint minutesDenominator = BitConverter.ToUInt32(propItem.Value, 12);
            double minutes = minutesNumerator / (double)minutesDenominator;

            uint secondsNumerator = BitConverter.ToUInt32(propItem.Value, 16);
            uint secondsDenominator = BitConverter.ToUInt32(propItem.Value, 20);
            double seconds = secondsNumerator / (double)secondsDenominator;

            double coorditate = degrees + (minutes / 60d) + (seconds / 3600d);
            string gpsRef = System.Text.Encoding.ASCII.GetString(new byte[1] { propItem.Value[0] }); //N, S, E, or W  

            if (gpsRef == "S" || gpsRef == "W")
            {
                coorditate = coorditate * -1;
            }
            return coorditate;
        }

            //      using (Bitmap bitmap = new Bitmap(@"D:\tmp\content_example_ibiza.jpg"))  
            //    {  
            //        var longitude = GetCoordinateDouble(bitmap.PropertyItems.Single(p => p.Id == 4));
            //var latitude = GetCoordinateDouble(bitmap.PropertyItems.Single(p => p.Id == 2));

            //Console.WriteLine($"Longitude: {longitude}");  
            //        Console.WriteLine($"Latitude: {latitude}");  
  
            //        Console.WriteLine($"https://www.google.com/maps/place/{latitude},{longitude}");  
  
            //    }

//        using (Bitmap bitmap = new Bitmap(@"D:\tmp\content_example_ibiza.jpg"))  
//{  
//    var longitudeData = bitmap.PropertyItems.Single(p => p.Id == 4).Value;
//    var latitudeData = bitmap.PropertyItems.Single(p => p.Id == 2).Value;
//}

//uint degreesNumerator = BitConverter.ToUInt32(propItem.Value, 0);
//uint degreesDenominator = BitConverter.ToUInt32(propItem.Value, 4);
//uint minutesNumerator = BitConverter.ToUInt32(propItem.Value, 8);
//uint minutesDenominator = BitConverter.ToUInt32(propItem.Value, 12);
//uint secondsNumerator = BitConverter.ToUInt32(propItem.Value, 16);
//uint secondsDenominator = BitConverter.ToUInt32(propItem.Value, 20);


public async Task<IActionResult> GetListFoto()
        {
              IList<DataPegawaiLookUpModel> aa;
        var NamaL = await Mediator.Send(new DataPegawaiListQuery());
           aa  = NamaL.DataPegawaiFotoDs;
            return View(aa.ToList());
        }


        [HttpGet]
        public async Task<IActionResult> CreateDataPegawaiDtJabatan()
        {
            var NamaJabatan = await Mediator.Send(new GetNamaJabatanQuery());
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["Jabatan"] = new SelectList(NamaJabatan.MasterJenisJabatanDs, "NoUrut", "NamaJabatan");


            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateDataPegawaiDtJabatan(CreateDataPegawaiDataJabatanCommand DataPegawaiDtJabatanViewModel)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(DataPegawaiDtJabatanViewModel);
                return RedirectToAction(nameof(DataPegawaiController.CreateDataPegawaiDtJabatan), "DataPegawai");
            }
            var NamaJabatan = await Mediator.Send(new GetNamaJabatanQuery());
            var NamaL = await Mediator.Send(new GetNamaPegawaiQuery());

            ViewData["NamaPekerja"] = new SelectList(NamaL.DataPegawaiDtPribadiDs, "IDPegawai", "NamaDepan");
            ViewData["Jabatan"] = new SelectList(NamaJabatan.MasterJenisJabatanDs, "NoUrut", "NamaJabatan");
            return View(DataPegawaiDtJabatanViewModel);
        }


    }
}