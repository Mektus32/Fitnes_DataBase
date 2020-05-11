using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Trainers;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class TrainerController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly ITrainerManager _manager;


        public TrainerController(FitnesDbContext context, ITrainerManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowTrainers() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public async Task<ViewResult> CreateTrainer() {
            var tup = await _manager.CreateListForViewCreateTrainer();
            return View(tup);
        }

        [HttpPost]
        public ActionResult Create(CreateOrUpdateTrainerRequest request) {
            try {
                _manager.AddTrainer(request);
                return RedirectToAction(nameof(ShowTrainers));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new trainer", call = nameof(Trainer) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateTrainer(int id) {
            try {
                var entity = await _manager.GetTrainerById(id);
                var tmp = await _manager.CreateListForViewCreateTrainer();
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find trainer with this id", call = nameof(Trainer) });
            }
        }
        [HttpPost]
        public ActionResult Update(int id, CreateOrUpdateTrainerRequest request) {
            try {
                _manager.UpdateTrainer(id, request);
                return RedirectToAction(nameof(ShowTrainers));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update trainer", call = nameof(Trainer) });
            }

        }
        [HttpGet]
        public ActionResult DeleteTrainer(int id) {
            try {
                _manager.DeleteTrainer(id);
                return RedirectToAction(nameof(ShowTrainers));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete trainer", call = nameof(Trainer) });
            }
        }
    }
}