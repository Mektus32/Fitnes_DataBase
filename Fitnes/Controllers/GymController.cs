﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage;
using Fitnes.Storage.Manager.Gyms;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class GymController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly IGymManager _manager;
        public GymController(FitnesDbContext context, IGymManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowGyms() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public ViewResult CreateGym() {
            var tup = _manager.CreateListWithTrainingMachines(null);
            return View(tup);
        }

        [HttpPost]
        public ActionResult Create(CreateOrUpdateGymRequest request) {
            try {
                _manager.AddGym(request);
                return RedirectToAction(nameof(ShowGyms));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new gym", call = nameof(Gym) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateGym(int id) {
            try {
                var entity = await _manager.GetGymById(id);
                var tmp = _manager.CreateListWithTrainingMachines(id);
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find gym with this id", call = nameof(Gym) });
            }
        }
        [HttpPost]
        public ActionResult Update(int id, CreateOrUpdateGymRequest request) {
            try {
                _manager.UpdateGym(id, request);
                return RedirectToAction(nameof(ShowGyms));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update gym", call = nameof(Gym) });
            }

        }
        [HttpGet]
        public ActionResult DeleteGym(int id) {
            try {
                _manager.DeleteGym(id);
                return RedirectToAction(nameof(ShowGyms));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete gym", call = nameof(Gym) });
            }
        }
    }
}