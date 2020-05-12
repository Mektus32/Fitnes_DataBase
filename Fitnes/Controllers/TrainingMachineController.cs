using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.TrainingMachines;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class TrainingMachineController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly ITrainingMachineManager _manager;
        public TrainingMachineController(FitnesDbContext context, ITrainingMachineManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowTrainingMachines() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public ViewResult CreateTrainingMachine() => View();

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateTrainingMachineRequest request) {
            try {
                await _manager.AddTrainingMachine(request);
                return RedirectToAction(nameof(ShowTrainingMachines));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new training machine", call = nameof(TrainingMachine) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateTrainingMachine(int id) {
            try {
                var entity = await _manager.GetTrainingMachineById(id);
                return View(entity);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find training machine with this id", call = nameof(TrainingMachine) });
            }
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id, CreateOrUpdateTrainingMachineRequest request) {
            try {
                await _manager.UpdateTrainingMachine(id, request);
                return RedirectToAction(nameof(ShowTrainingMachines));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update training machine", call = nameof(TrainingMachine) });
            }

        }
        [HttpGet]
        public async Task<ActionResult> DeleteTrainingMachine(int id) {
            try {
                await _manager.DeleteTrainingMachine(id);
                return RedirectToAction(nameof(ShowTrainingMachines));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete training machine", call = nameof(TrainingMachine) });
            }
        }
    }
}