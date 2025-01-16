﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorOr;
using GymManagement.Domain.Subscriptions;
using MediatR;
using GymManagement.Application.Common.Interfaces;
using GymManagement.Contracts.Subscriptions;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription
{
    public class CreateSubscriptionCommandHandler : IRequestHandler<CreateSubscriptionCommand, ErrorOr<Subscription>>
    {
        private readonly ISubscriptionsRepository _subscriptionsRepository;

        private readonly IUnitOfWork _unitOfWork;

        public CreateSubscriptionCommandHandler(ISubscriptionsRepository subscriptionsRepository, IUnitOfWork unitOfWork)
        {
            _subscriptionsRepository = subscriptionsRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<ErrorOr<Subscription>> Handle(CreateSubscriptionCommand request, CancellationToken cancellationToken)
        {
            var subscription = new Subscription
            {
                Id = Guid.NewGuid(),
                SubscriptionType = request.SubscriptionType,
            };

            await _subscriptionsRepository.AddSubscriptionAsync(subscription);
            await _unitOfWork.CommitChangesAsync();

            return subscription;
        }
    }
}
