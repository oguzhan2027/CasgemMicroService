using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDetailsDtos;
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

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Handlers
{
    public class GetByIdOrderDetailQueryHandler : IRequestHandler<GetByIdOrderDetailQueryRequest, ResultOrderDetailDto>
    {
        private readonly IRepository<Ordering> _repository;
        private readonly IMapper _mapper;

        public GetByIdOrderDetailQueryHandler(IRepository<Ordering> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ResultOrderDetailDto> Handle(GetByIdOrderDetailQueryRequest request, CancellationToken cancellationToken)
        {
            var result = await _repository.GetByIdAsync(request.Id);
            return _mapper.Map<ResultOrderDetailDto>(result);
        }
    }
}
