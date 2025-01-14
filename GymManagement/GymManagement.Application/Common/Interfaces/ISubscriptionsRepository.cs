using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces
{
    public interface ISubscriptionsRepository
    {
        Task AddSubscriptionAsync(Subscription subscription);
        Task<Subscription?> GetByIdAsync(Guid subscriptionId);

    }
}
