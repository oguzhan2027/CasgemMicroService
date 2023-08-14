using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
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
    public class CreateOrderingCommandHandler : IRequestHandler<CreateOrderingCommandRequest>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public CreateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Task Handle(CreateOrderingCommandRequest request, CancellationToken cancellationToken)
        {
            var values = new Ordering
            {
               UserID = request.UserID,
               OrderDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
               TotalPrice = request.TotalPrice,

            };
            return _repository.CreateGetAsync(values);
        }
    }
    
}
