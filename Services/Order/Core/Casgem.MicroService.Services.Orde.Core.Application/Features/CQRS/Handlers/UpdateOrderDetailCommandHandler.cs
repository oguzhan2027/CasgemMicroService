﻿using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
using Casgem.MicroService.Services.Orde.Core.Application.Interfaces;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Handlers
{
    public class UpdateOrderDetailCommandHandler : IRequest<UpdateOrderDetailCommandRequest>
    {
        private readonly IRepository<OrderDetail> _repository;

        public UpdateOrderDetailCommandHandler(IRepository<OrderDetail> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateOrderDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.OrderDetailID);
            
            values.ProductID=request.ProductID;
            values.ProductName=request.ProductName;
            values.ProductPrice=request.ProductPrice;
            values.ProductAmount=request.ProductAmount;
            values.OrderingID=request.OrderingID;
            await _repository.UpdateGetAsync(values);
        }
    }
}
