using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fitnes.Storage.Manager.Subscriptions;
using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fitnes.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly FitnesDbContext _context;
        private readonly ISubscriptionManager _manager;
        public SubscriptionController(FitnesDbContext context, ISubscriptionManager manager) {
            _manager = manager;
            _context = context;
        }
        public async Task<ViewResult> ShowSubscriptions() {
            var entitys = await _manager.GetAll();
            return View(entitys);
        }
        public ViewResult CreateSubscription() => View();

        [HttpPost]
        public ActionResult Create(CreateOrUpdateSubscriptionRequest request) {
            try {
                _manager.AddSubscription(request);
                return RedirectToAction(nameof(ShowSubscriptions));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not add new subscription", call = nameof(Subscription) });
            }
        }
        [HttpGet]
        public async Task<ActionResult> UpdateSubscription(int id) {
            try {
                var entity = await _manager.GetSubscriptionById(id);
                return View(entity);
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not find subscription with this id", call = nameof(Subscription) });
            }
        }
        [HttpPost]
        public ActionResult Update(int id, CreateOrUpdateSubscriptionRequest request) {
            try {
                _manager.UpdateSubscription(id, request);
                return RedirectToAction(nameof(ShowSubscriptions));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not update subscription", call = nameof(Subscription) });
            }

        }
        [HttpGet]
        public ActionResult DeleteSubscription(int id) {
            try {
                _manager.DeleteSubscription(id);
                return RedirectToAction(nameof(ShowSubscriptions));
            }
            catch (ArgumentNullException) {
                return RedirectToAction("ErrorPage", nameof(Main), new { message = "Error: can not delete subscription", call = nameof(Subscription) });
            }
        }
    }
}