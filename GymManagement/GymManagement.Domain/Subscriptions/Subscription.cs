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
        public Guid Id { get; set; }

        // TODO: Check if Contracts project is being referenced here.
        public string SubscriptionType { get; set; } = "Free";
    }
}
