using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDtos;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries;
using Casgem.MicroService.Services.Orde.Core.Application.Interfaces;

using CasgemMicroService.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
    public class GetOrderingByUserIdCommandHandler : IRequestHandler<GetOrderingByUserIdQuery, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetOrderingByUserIdCommandHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        async Task<List<ResultOrderingDto>> IRequestHandler<GetOrderingByUserIdQuery, List<ResultOrderingDto>>.Handle(GetOrderingByUserIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetOrdersById(x => x.UserID == request.Id);
            return _mapper.Map<List<ResultOrderingDto>>(value);
        }
    }
}