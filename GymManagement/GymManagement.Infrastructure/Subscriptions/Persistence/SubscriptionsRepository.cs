using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;

namespace GymManagement.Infrastructure.Subscriptions.Persistence
{
    public class SubscriptionsRepository : ISubscriptionsRepository
    {
        // In-memory for now..
        private readonly static List<Subscription> _subscriptions = new();

        public Task AddSubscriptionAsync(Subscription subscription)
        {
            _subscriptions.Add(subscription);

            return Task.CompletedTask;
        }

        public Task<Subscription?> GetByIdAsync(Guid subscriptionId)
        {
            var subscription = _subscriptions.FirstOrDefault(s => s.Id == subscriptionId);

            return Task.FromResult(subscription);
        }
    }
}
