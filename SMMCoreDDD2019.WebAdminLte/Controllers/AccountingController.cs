using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Command.CreateAccountingDataAccount;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetAllDataAccountOrderByKodeAccount;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByDepth;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent;
using SmmCoreDDD2019.Application.AccountingDataAccountDB.Query.GetDataAccountByParent2;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Command.CreateAccountingDataJournal;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalAll;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeAkun;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetDataJournalByKodeHeader;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanLabaRugi;
using SmmCoreDDD2019.Application.AccountingDataJournalDB.Query.GetLaporanNeraca;
using SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Command.CreateAccountingDataJournalHeader;
using SmmCoreDDD2019.Application.AccountingDataJournalHeaderDB.Query.GetDataJournalHeader;
using SmmCoreDDD2019.Application.AccountingTipeJournalDB.Query.GetTipeJournal;


namespace SMMCoreDDD2019.WebAdminLte.Controllers
{
    public class AccountingController : BaseController
    {
        public async Task<IActionResult> Index()
        {
            var DataAccounting = await Mediator.Send(new GetAllDataAccountOrderByKodeAccountQuery());
            return View(DataAccounting.DataAccountDs.OrderBy(x => x.KodeAccount).ToList());
        }
        public async Task<IActionResult> CreateAccount()
        {
            var DataAccounting = await Mediator.Send(new GetDataAccountByParentQuery());
            ViewData["DataAkun1"] = new SelectList(DataAccounting.DataAccountParentDs.ToList(), "NoUrutAccountId", "DataAkun");

            return View();
        }
        public async Task<JsonResult> GetAccount(string data1a)//ajax calls this function which will return json object  

        {
            if (data1a == "0")
            {
                var DataAccounting = await Mediator.Send(new GetAllDataAccountOrderByKodeAccountQuery());
                var bb = DataAccounting.DataAccountDs.ToList();
                return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }
            else
            {
                var DataAccounting1 = await Mediator.Send(new GetDataAccountByParent2Query { Id = data1a });
                var bb = DataAccounting1.DataAccountParentDs.ToList();
                return Json(Newtonsoft.Json.JsonConvert.SerializeObject(bb));
            }


        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create2(string KodeAccount1, string Parent1, string Account1a, string NormalPos1, string Kelompok1, CreateAccountingDataAccountCommand CreateAccountingDataAccountCommand1)
        {
            CreateAccountingDataAccountCommand1.Parent = Parent1;
            CreateAccountingDataAccountCommand1.KodeAccount = KodeAccount1;
            CreateAccountingDataAccountCommand1.Account = Account1a;
            CreateAccountingDataAccountCommand1.NormalPos = Int32.Parse(NormalPos1);
            CreateAccountingDataAccountCommand1.Kelompok = Kelompok1;

            if (CreateAccountingDataAccountCommand1 != null)
            {
                await Mediator.Send(CreateAccountingDataAccountCommand1);
                return RedirectToAction(nameof(Index));
            }

            return View();

        }

        // GET: JournalHeaders/Create
        public async Task<IActionResult> CreateJournalHeader()
        {
            var TipeJournal = await Mediator.Send(new GetTipeJournalQuery());
            ViewData["TipeJournal1"] = new SelectList(TipeJournal.DataTipeJournalDs.ToList(), "NoIDTipeJournal", "NamaJournal");
            //jenis tipe journal 

            return View();
        }

        // POST: JournalHeaders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateJournalHeader(CreateAccountingDataJournalHeaderCommand CreateAccountingDataJournalHeaderCommand1)
        {
            if (ModelState.IsValid)
            {
                await Mediator.Send(CreateAccountingDataJournalHeaderCommand1);

                return RedirectToAction(nameof(AccountingController.CreateJournalDetail), "Accounting");
                // return RedirectToAction(nameof(JournalsController.Create), "Journals", new { KodeIdHeader1 = KodeIdHeader, tglinput1 = tgl11, ket11 = ket1, noBuktiJ = Isi1 });

            }
            return View();
        }
        public class AccountClientViewModel
        {
            public IList<SelectListItem> AccountIdList { get; set; }
        }
        // GET: Journals/Create
        public async Task<IActionResult> CreateJournalDetail(int? KodeIdHeader1)
        {
            var DataJournalHeader = await Mediator.Send(new GetDataJournalHeaderQuery());
            ViewData["DataJournalHeader1"] = new SelectList(DataJournalHeader.DataJournalHeaderDs.OrderByDescending(x => x.NoUrutJournalHID).Take(10).ToList(), "NoUrutJournalHID", "DataJournalHeaders");


            var bb = await Mediator.Send(new GetDataAccountByDepthQuery());
            var aa = bb.DataAccountByDepthDS.OrderBy(X => X.KodeAccount).GroupBy(x => x.DataAkun2).ToList();
            var model = new AccountClientViewModel()
            {
                AccountIdList = new List<SelectListItem>()

            };
            foreach (var akungroup in aa)
            {
                var OptionGrp = new SelectListGroup() { Name = akungroup.Key };
                foreach (var akun1 in akungroup)
                {
                    model.AccountIdList.Add(new SelectListItem() { Value = akun1.NoUrutAccountId.ToString(), Text = akun1.DataAkun1, Group = OptionGrp });
                }

            }

            ViewData["Account1"] = model.AccountIdList;
            //if (KodeIdHeader1!=null)
            //{

            //}
            //  var aa1 = await Mediator.Send(new GetDataJournalByKodeHeaderQuery { Id = KodeIdHeader1.ToString() });

            return View();
            // return View(aa1.DataJournalByKodeHeaderDs.ToList());
        }

        // POST: Journals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateJournalDetail(string IdAccount1, decimal Debit1, decimal Kredit1, string Keterangan1, string IdBukti1, CreateAccountingDataJournalCommand CreateAccountingDataJournalCommand1)
        {
            CreateAccountingDataJournalCommand1.NoUrutJournalH = IdBukti1;
            CreateAccountingDataJournalCommand1.NoUrutAccountId = IdAccount1;
            CreateAccountingDataJournalCommand1.Debit = Debit1;
            CreateAccountingDataJournalCommand1.Kredit = Kredit1;
            CreateAccountingDataJournalCommand1.Keterangan = Keterangan1;

            await Mediator.Send(CreateAccountingDataJournalCommand1);
            var aa1 = await Mediator.Send(new GetDataJournalByKodeHeaderQuery { Id = IdBukti1 });
            var DataJournalHeader = await Mediator.Send(new GetDataJournalHeaderQuery());
            ViewData["DataJournalHeader1"] = new SelectList(DataJournalHeader.DataJournalHeaderDs.OrderByDescending(x => x.NoUrutJournalHID).Take(10).ToList(), "NoUrutJournalHID", "DataJournalHeaders");
            var bb = await Mediator.Send(new GetDataAccountByDepthQuery());
            var aa = bb.DataAccountByDepthDS.OrderBy(X => X.KodeAccount).GroupBy(x => x.DataAkun2).ToList();
            var model = new AccountClientViewModel()
            {
                AccountIdList = new List<SelectListItem>()

            };
            foreach (var akungroup in aa)
            {
                var OptionGrp = new SelectListGroup() { Name = akungroup.Key };
                foreach (var akun1 in akungroup)
                {
                    model.AccountIdList.Add(new SelectListItem() { Value = akun1.NoUrutAccountId.ToString(), Text = akun1.DataAkun1, Group = OptionGrp });
                }

            }

            ViewData["Account1"] = model.AccountIdList;
            return View(aa1.DataJournalByKodeHeaderDs.ToList());
            //  return RedirectToAction(nameof(AccountingController.CreateJournalDetail), "Accounting");

        }

        public async Task<IActionResult> LaporanAkunBukuBesar()
        {
            var bb = await Mediator.Send(new GetDataAccountByDepthQuery());
            var aa = bb.DataAccountByDepthDS.OrderBy(X => X.KodeAccount).GroupBy(x => x.DataAkun2).ToList();
            var model = new AccountClientViewModel()
            {
                AccountIdList = new List<SelectListItem>()

            };
            foreach (var akungroup in aa)
            {
                var OptionGrp = new SelectListGroup() { Name = akungroup.Key };
                foreach (var akun1 in akungroup)
                {
                    model.AccountIdList.Add(new SelectListItem() { Value = akun1.NoUrutAccountId.ToString(), Text = akun1.DataAkun1, Group = OptionGrp });
                }

            }

            ViewData["Account1"] = model.AccountIdList;


            return View();
        }

        public async Task<IActionResult> LapAkunBukuBesarDetail(string Akun1)
        {
            var aas1 = await Mediator.Send(new GetDataJournalByKodeAkunQuery { Id = Akun1 });
            var aas3 = aas1.DataJournalByKodeAkunDs.ToList();

            ViewData["Akun1"] = aas3[0].DataAkun;
            return View(aas3);


        }

        public async Task<IActionResult> LapAkunBukuBesarAll()
        {
            var aa1 = await Mediator.Send(new GetDataJournalAllQuery());
            var bb1 = aa1.DataJournalAllDs.OrderBy(x => x.TanggalInput).OrderBy(x => x.DataAkun).ToList();
            return View(bb1);
        }

        public async Task<IActionResult> LapAkunBukuBesarAll2()
        {
            var aa1 = await Mediator.Send(new GetDataJournalAllQuery());
            var bb1 = aa1.DataJournalAllDs.OrderBy(x => x.TanggalInput).OrderBy(x => x.DataAkun).ToList();
            return View(bb1);
        }
        public IActionResult LaporanLabaRugiTanggal()
        {
            return View();
        }

        public async Task<IActionResult> LaporanLabaRugi(DateTime Tgl1, DateTime Tgl2)
        {
            var LapLabaRugi = await Mediator.Send(new GetLaporanLabaRugiQuery { Tanggal1 = Tgl1, Tanggal2 = Tgl2 });
            var bb = LapLabaRugi.LaporanLabaRugiDS.OrderBy(x => x.KodeAccountParent).OrderBy(x => x.KodeAccount1).ToList();
            return View();
        }
        public IActionResult LaporanNeracaTanggal()
        {
            return View();
        }
        public async Task<IActionResult> LaporanNeraca(DateTime Tgl1, DateTime Tgl2)
        {
            var LapNeraca = await Mediator.Send(new GetLaporanNeracaQuery { Tanggal1 = Tgl1, Tanggal2 = Tgl2 });
            var bb = LapNeraca.LaporanNeracaDS.OrderBy(x => x.KodeAccountParent).OrderBy(x => x.KodeAccount1).ToList();
            return View(bb);

        }

        public IActionResult LaporanNeraca2Tanggal()
        {

            return View();
        }
        public async Task<IActionResult> LaporanNeraca2(DateTime Tgl1, DateTime Tgl2)
        {
            var LapNeraca = await Mediator.Send(new GetLaporanNeracaQuery { Tanggal1 = Tgl1, Tanggal2 = Tgl2 });
            var bb = LapNeraca.LaporanNeracaDS.OrderBy(x => x.KodeAccountParent).OrderBy(x => x.KodeAccount1).ToList();
            return View();

        }


    }
}