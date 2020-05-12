using Fitnes.Storage;
using Fitnes.Storage.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Subscriptions {
    public class SubscriptionManager : ISubscriptionManager {
        private readonly FitnesDbContext context;
        public SubscriptionManager(FitnesDbContext fitnesDbContext) {
            context = fitnesDbContext;
        }
        public async Task AddSubscription(CreateOrUpdateSubscriptionRequest request) {
            var sub = new Subscription {
                Name = request.Name,
                Price = request.Price,
                Time = request.Time
            };
            await context.Subscriptions.AddAsync(sub);
            await context.SaveChangesAsync();
        }

        public async Task DeleteSubscription(int id) {
            context.Clients.Where(c => c.SubscriptionId == id).ToList().ForEach(elem => elem.SubscriptionId = null);
            context.Subscriptions.Remove(context.Subscriptions.Find(id));
            await context.SaveChangesAsync();
        }

        public async Task<IReadOnlyCollection<Subscription>> GetAll() {
            return await context.Subscriptions.Include(c => c).ToListAsync();
        }

        public async Task<Subscription> GetSubscriptionById(int id) {
            var entity = await context.Subscriptions.FindAsync(id);
            if (entity == null)
                throw new ArgumentNullException();
            return entity;
        }
        public async Task UpdateSubscription(int id, CreateOrUpdateSubscriptionRequest request) {
            var sub = await context.Subscriptions.FindAsync(id);
            sub.Name = request.Name;
            sub.Price = request.Price;
            sub.Time = request.Time;
            await context.SaveChangesAsync();
        }
    }
}
