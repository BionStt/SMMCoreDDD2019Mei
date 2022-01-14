using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SumberMas2015.SalesMarketing.Dto.DataKonsumen;
using SumberMas2015.SalesMarketing.DtoMapping;
using SumberMas2015.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.CreateDataKonsumen;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Commands.UpdateDataKonsumen;
using SumberMas2015.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerByID;
using SumberMas2015.SalesMarketing.ServiceApplication.JenisKelamin.ListJenisKelamin;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries;
using SumberMas2015.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SMMCoreDDD2019.AdminLte.Controllers
{
    public class CustomersController : Controller
    {
        private IMediator _mediator;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly string _userId;

        // private readonly string _userName;      
        //  private readonly string _userId2;

        public CustomersController(IMediator mediator, IHttpContextAccessor httpContextAccessor)
        {
            _mediator = mediator;
            _httpContextAccessor = httpContextAccessor;
            _userId = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;//userID Guid

            //  _userName = httpContextAccessor.HttpContext.User.Identity.Name;//username
            // _userId2 =  httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Name).Value;//UserNAme
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var NamaBidangPekerjaan1 = await _mediator.Send(new GetNamaBidangPekerjaanQuery());
            var NamaBidangUsaha1 = await _mediator.Send(new GetNamaBidangUsahaQuery());
            ViewData["NamaBidangPekerjaan1"] = new SelectList(NamaBidangPekerjaan1, "NoUrutBidangPekerjaan", "NamaMasterBidangPekerjaan");
            ViewData["NamaBidangUsaha1"] = new SelectList(NamaBidangUsaha1, "NoKodeMasterBidangUsaha", "NamaMasterBidangUsaha");

            var Agama = await _mediator.Send(new AgamaListQuery());
            var JnsKelamin = await _mediator.Send(new ListJenisKelaminQuery());
            ViewData["Agama1"] = new SelectList(Agama, "NoUrutId", "AgamaKeterangan");
            ViewData["JnsKelamin1"] = new SelectList(JnsKelamin, "NoUrutId", "JenisKelaminKeterangan");
       
            ViewData["UserId"] = _userId;

            //  ViewData["UserId2"] = _userId2;
            //  ViewData["UserName"] = _userName;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CreateDataKonsumenRequest customerViewModel)
        {
            if (ModelState.IsValid)
            {
                var dtKonsumen = customerViewModel.ToCommand();
                await _mediator.Send(dtKonsumen);


               // await _mediator.Send(customerViewModel);
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
            return View(customerViewModel);
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> EditCustomer(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var CustomerDb = await _mediator.Send(new GetCustomerByIDQuery { Id = id.ToString() });
            if (CustomerDb == null)
            {
                return NotFound();
            }
            return View(CustomerDb);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCustomer(int id, UpdateDataKonsumenCommand CustomerDB)
        {
            if (id != CustomerDB.CustomerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _mediator.Send(CustomerDB);

                return RedirectToAction(nameof(Create));
            }
            return View(CustomerDB);
        }

    }
}
