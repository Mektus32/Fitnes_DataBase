using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Subscriptions {
    public interface ISubscriptionManager {
        public Task<IReadOnlyCollection<Subscription>> GetAll();
        public Task<Subscription> GetSubscriptionById(int id);
        public Task AddSubscription(CreateOrUpdateSubscriptionRequest request);
        public Task UpdateSubscription(int id, CreateOrUpdateSubscriptionRequest request);
        public Task DeleteSubscription(int id);
        public List<Subscription> SearchSubscription(string text, int term);
    }
}
