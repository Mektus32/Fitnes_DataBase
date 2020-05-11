using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Storage.Manager.Subscriptions {
    public interface ISubscriptionManager {
        public Task<IReadOnlyCollection<Subscription>> GetAll();
        public Task<Subscription> GetSubscriptionById(int id);
        public void AddSubscription(CreateOrUpdateSubscriptionRequest request);
        public void UpdateSubscription(int id, CreateOrUpdateSubscriptionRequest request);
        public void DeleteSubscription(int id);
    }
}
