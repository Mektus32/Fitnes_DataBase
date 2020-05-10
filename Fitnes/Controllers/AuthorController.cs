using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage;
using Fitnes.Storage.Manager;
using Fitnes.Storage.Manager.Authors;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class AuthorController : Controller {
        private readonly FitnesDbContext _context;
        private readonly IAuthorManager _manager;
        public AuthorController(FitnesDbContext context, IAuthorManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowAuthors() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public ViewResult CreateAuthor() => View();

        [HttpPost]
        public ActionResult Create(CreateOrUpdateAuthorRequest request) {
            try {
                _manager.AddAuthor(request);
                return RedirectToAction(nameof(ShowAuthors));
            } catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new author", call = nameof(Author) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateAuthor(int id) {
            ViewBag.ErrorMesssage = null;
            try {
                var entity = await _manager.GetAuthorById(id);
                return View(entity);
            } catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find author with this id", call = nameof(Author) });
            }
        }
        [HttpPost]
        public ActionResult Update(int id, CreateOrUpdateAuthorRequest request) {
            ViewBag.ErrorMessage = null;
            try {
                _manager.UpdateAuthor(id, request);
                return RedirectToAction(nameof(ShowAuthors));
            } catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new {message = "Error: can not update author", call = nameof(Author) });
            }
            
        }
        [HttpGet]
        public ActionResult DeleteAuthor(int id) {
            ViewBag.ErrorMessage = null;
            try {
                _manager.DeleteAuthor(id);
                return RedirectToAction(nameof(ShowAuthors));
            } catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main),  new {message = "Error: can not delete author", call = nameof(Author) });
            }
        }
    }
}