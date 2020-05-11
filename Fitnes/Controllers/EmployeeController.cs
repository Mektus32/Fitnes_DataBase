using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly IEmployeeManager _manager;
        public EmployeeController(FitnesDbContext context, IEmployeeManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowEmployees() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public async Task<ViewResult> CreateEmployee() {
            var tup = await _manager.CreateListForViewCreateEmployee();
            return View(tup);
        }
        [HttpPost]
        public ActionResult Create(CreateOrUpdateEmployeeRequest request) {
            try {
                _manager.AddEmployee(request);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new employeer", call = nameof(Employee) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateEmployeet(int id) {
            try {
                var entity = await _manager.GetEmployeeById(id);
                var tmp = await _manager.CreateListForViewCreateEmployee();
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find emploeer with this id", call = nameof(Employee) });
            }
        }
        [HttpPost]
        public ActionResult Update(int id, CreateOrUpdateEmployeeRequest request) {
            try {
                _manager.UpdateEmployee(id, request);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update employee", call = nameof(Employee) });
            }

        }
        [HttpGet]
        public ActionResult DeleteCEmployee(int id) {
            try {
                _manager.DeleteEmployee(id);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete employee", call = nameof(Employee) });
            }
        }
    }
}