using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage;
using Fitnes.Storage.Manager.ProgramWorkouts;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fitnes.Controllers
{
    public class ProgramWorkoutController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly IProgramWorkoutManager _manager;
        public ProgramWorkoutController(FitnesDbContext context, IProgramWorkoutManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowProgramWorkouts() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public async Task<ViewResult> CreateProgramWorkout() {
            var tup = await _manager.CreateListForViewCreateProgramWorkout();
            return View(tup);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateProgramWorkoutRequest request) {
            try {
                await _manager.AddProgramWorkout(request);
                return RedirectToAction(nameof(ShowProgramWorkouts));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new program workout", call = nameof(ProgramWorkout) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
            catch (ArgumentException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: value should be positiv", call = nameof(ProgramWorkout) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateProgramWorkout(int id) {
            try {
                var entity = await _manager.GetProgramWorkoutById(id);
                var tmp = await _manager.CreateListForViewCreateProgramWorkout();
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find program workout with this id", call = nameof(ProgramWorkout) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id, CreateOrUpdateProgramWorkoutRequest request) {
            try {
                await _manager.UpdateProgramWorkout(id, request);
                return RedirectToAction(nameof(ShowProgramWorkouts));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update program workout", call = nameof(ProgramWorkout) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
            catch (ArgumentException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: value should be positiv", call = nameof(ProgramWorkout) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> DeleteProgramWorkout(int id) {
            try {
                await _manager.DeleteProgramWorkout(id);
                return RedirectToAction(nameof(ShowProgramWorkouts));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete program workout", call = nameof(ProgramWorkout) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
        }
        public ActionResult SearchProgramWorkout(string text, int term) {
            try {
                var list = _manager.SearchProgramWorkout(text, term);
                if (list.Count == 0)
                    throw new ArgumentOutOfRangeException();
                return View(list);
            }
            catch (ArgumentOutOfRangeException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Info: no elements", call = nameof(ProgramWorkout), output = "Information" });
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
            catch (FormatException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(ProgramWorkout) });
            }
            catch (Exception) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: unexpected exception", call = nameof(ProgramWorkout) });
            }
        }
    }
}