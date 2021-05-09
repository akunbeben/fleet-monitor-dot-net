using FleetMonitoring.Data.Repositories;
using FleetMonitoring.WebUI.Models;
using FleetMonitoring.WebUI.Services;
using System.Web.Mvc;

namespace FleetMonitoring.WebUI.Controllers
{
    public class OwnerController : Controller
    {
        protected readonly IOwnerRepository _ownerRepository;

        public OwnerController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }

        // GET: Owner
        public ActionResult Index()
        {
            var owners = _ownerRepository.GetAll();

            ViewData["Owners"] = owners;

            return View();
        }

        // GET: Owner/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Owner/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(OwnerModel collection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _ownerRepository.Save(OwnerService.MappingOwnerModel(collection));

            return RedirectToAction("Index");
        }

        // GET: Owner/Edit/5
        public ActionResult Edit(int id)
        {
            var owner = OwnerService.MappingToView(_ownerRepository.Get(id));

            return View(owner);
        }

        // POST: Owner/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, OwnerModel collection)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _ownerRepository.Update(id, OwnerService.MappingOwnerModel(collection, true));
            
            return RedirectToAction("Index");
        }

        // POST: Owner/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            _ownerRepository.Delete(id);

            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ownerRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
