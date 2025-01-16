using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymManagement.Contracts.Subscriptions;

namespace GymManagement.Domain.Subscriptions
{
    public class Subscription
    {
        public Guid Id { get; private set; }

        public SubscriptionType SubscriptionType { get; private set; }

        private readonly Guid _adminId;


        public Subscription(
            SubscriptionType subscriptionType,
            Guid adminId,
            Guid? id=null)
        {
            SubscriptionType = subscriptionType;
            _adminId = adminId;
            Id = id ?? Guid.NewGuid();
        }

        private Subscription()
        {

        }

    }
}
