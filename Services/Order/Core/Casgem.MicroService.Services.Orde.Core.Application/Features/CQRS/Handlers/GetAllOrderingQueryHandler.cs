using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDtos;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Qeries;
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
    public class GetAllOrderingQueryHandler : IRequestHandler<GetAllOrderingQueryRequest, List<ResultOrderingDto>>
    {
        private readonly IRepository<Ordering> _repository;

        public GetAllOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        private readonly IMapper _mapper;
        public async Task<List<ResultOrderingDto>> Handle(GetAllOrderingQueryRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return _mapper.Map<List<ResultOrderingDto>>(values);
        }
    }
}
