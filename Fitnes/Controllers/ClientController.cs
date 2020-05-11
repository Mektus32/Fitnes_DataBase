using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Clients;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class ClientController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly IClientManager _manager;
        public ClientController(FitnesDbContext context, IClientManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowClients() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        [HttpGet]
        public async Task<ViewResult> CreateClient() {
            var tup = await _manager.CreateListForViewCreateClient();
            return View(tup);
        }

        [HttpPost]
        public async Task<ActionResult> Create(CreateOrUpdateClientRequest request) {
            try {
                await _manager.AddClient(request);
                return RedirectToAction(nameof(ShowClients));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new client", call = nameof(Client) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateClient(int id) {
            try {
                var entity = await _manager.GetClientById(id);
                var tmp = await _manager.CreateListForViewCreateClient();
                var tup = (entity, tmp);
                return View(tup);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find client with this id", call = nameof(Client) });
            }
        }
        [HttpPost]
        public async  Task<ActionResult> Update(int id, CreateOrUpdateClientRequest request) {
            try {
                await _manager.UpdateClient(id, request);
                return RedirectToAction(nameof(ShowClients));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update client", call = nameof(Client) });
            }

        }
        [HttpGet]
        public async  Task<ActionResult> DeleteClient(int id) {
            try {
                await _manager.DeleteClient(id);
                return RedirectToAction(nameof(ShowClients));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete client", call = nameof(Client) });
            }
        }
    }
}