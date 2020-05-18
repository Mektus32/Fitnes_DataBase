using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Employers;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        public async Task<ActionResult> Create(CreateOrUpdateEmployeeRequest request) {
            try {
                await _manager.AddEmployee(request);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new employeer", call = nameof(Employee) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee) });
            }
            catch (ArgumentException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: value should be positiv", call = nameof(Employee) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateEmployee(int id) {
            try {
                var entity = await _manager.GetEmployeeById(id);
                var tmp = await _manager.CreateListForViewCreateEmployee();
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find emploeer with this id", call = nameof(Employee) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee) });
            }
        }
        [HttpPost]
        public async Task<ActionResult> Update(int id, CreateOrUpdateEmployeeRequest request) {
            try {
                await _manager.UpdateEmployee(id, request);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update employee", call = nameof(Employee) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee) });
            }
            catch (ArgumentException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: value should be positiv", call = nameof(Employee) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> DeleteEmployee(int id) {
            try {
                await _manager.DeleteEmployee(id);
                return RedirectToAction(nameof(ShowEmployees));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete employee", call = nameof(Employee) });
            }
            catch (DbUpdateException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee) });
            }
        }
        public ActionResult SearchEmployee(string text, int term) {
            try {
                var list = _manager.SearchEmployee(text, term);
                if (list.Count == 0)
                    throw new ArgumentOutOfRangeException();
                return View(list);
            }
            catch (ArgumentOutOfRangeException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Info: no elements", call = nameof(Employee), output = "Information" });
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee)});
            }
            catch (FormatException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: invalid input", call = nameof(Employee) });
            }
            catch (Exception) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: unexpected exception", call = nameof(Employee) });
            }
        }
    }
}