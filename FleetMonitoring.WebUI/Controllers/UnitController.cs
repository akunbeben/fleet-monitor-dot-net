using FleetMonitoring.Data.Repositories;
using FleetMonitoring.WebUI.Models;
using FleetMonitoring.WebUI.Services;
using System.Web.Mvc;

namespace FleetMonitoring.WebUI.Controllers
{
    [Authorize]
    public class UnitController : Controller
    {
        protected readonly IUnitRepository _unitRepository;
        protected readonly IOwnerRepository _ownerRepository;

        public UnitController(IUnitRepository unitRepository, IOwnerRepository ownerRepository)
        {
            _unitRepository = unitRepository;
            _ownerRepository = ownerRepository;
        }

        // GET: Unit
        public ActionResult Index()
        {
            var units = _unitRepository.GetAll();

            return View(units);
        }

        // GET: Unit/Create
        public ActionResult Create()
        {
            ViewData["Owners"] = _ownerRepository.GetAll();

            return View();
        }

        // POST: Unit/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UnitModel collection)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Owners"] = _ownerRepository.GetAll();

                return View();
            }

            _unitRepository.Save(UnitService.MappingToModel(collection));

            return RedirectToAction("Index");
        }

        // GET: Unit/Edit/5
        public ActionResult Edit(int id)
        {
            var unit = UnitService.MappingToView(_unitRepository.Get(id));
            ViewData["Owners"] = _ownerRepository.GetAll();

            return View(unit);
        }

        // POST: Unit/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, UnitModel collection)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Owners"] = _ownerRepository.GetAll();

                return View();
            }

            _unitRepository.Update(id, UnitService.MappingToModel(collection, true));

            return RedirectToAction("Index");
        }

        // POST: Unit/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            _unitRepository.Delete(id);

            return RedirectToAction("Index");
        }

        public ActionResult Location(int id)
        {
            var unit = _unitRepository.Get(id);

            ViewData["Location"] = UnitService.MockLocation();

            return View(unit);
        }

        protected override void Dispose(bool disposing)
        {
            _unitRepository.Dispose();
            _ownerRepository.Dispose();
            base.Dispose(disposing);
        }
    }
}
