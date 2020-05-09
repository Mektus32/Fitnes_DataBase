using Fitnes.Storage.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitnes.Manager.Subscriptions {
    interface ISubscriptionManager {
        Task<Subscription> AddSubscription(CreateOrUpdateSubscriptionRequest request);
        Task<IReadOnlyCollection<Subscription>> GetAll();
        Task<Subscription> UpdateSubscription(Guid id, CreateOrUpdateSubscriptionRequest request);
        Task<Subscription> GetById(Guid id);
    }
}
