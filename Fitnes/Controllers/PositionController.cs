using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage;
using Fitnes.Storage.Manager.Positions;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class PositionController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly IPositionManager _manager;
        public PositionController(FitnesDbContext context, IPositionManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowPositions() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public ViewResult CreatePosition() => View();

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdatePositionRequest request) {
            try {
                await _manager.AddPosition(request);
                return RedirectToAction(nameof(ShowPositions));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new position", call = nameof(Position) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdatePosition(int id) {
            try {
                var entity = await _manager.GetPositionById(id);
                return View(entity);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find position with this id", call = nameof(Position) });
            }
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id, CreateOrUpdatePositionRequest request) {
            try {
                await _manager.UpdatePosition(id, request);
                return RedirectToAction(nameof(ShowPositions));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update position", call = nameof(Position) });
            }

        }
    }
}