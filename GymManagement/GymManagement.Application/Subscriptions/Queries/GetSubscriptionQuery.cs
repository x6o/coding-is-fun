﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;

namespace GymManagement.Application.Subscriptions.Queries
{
    public record GetSubscriptionQuery(Guid subscriptionId) : IRequest<ErrorOr<Subscription>>;
}
