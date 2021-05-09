using FleetMonitoring.Data.Repositories;
using FleetMonitoring.WebUI.Models;
using FleetMonitoring.WebUI.Services;
using FleetMonitoring.WebUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FleetMonitoring.WebUI.Controllers
{
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

            ViewData["Units"] = units;

            return View();
        }

        // GET: Unit/Create
        public ActionResult Create()
        {
            ViewData["Owners"] = _ownerRepository.GetAll();

            return View();
        }

        // POST: Unit/Create
        [HttpPost]
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
            return View();
        }

        // POST: Unit/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Unit/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Unit/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
