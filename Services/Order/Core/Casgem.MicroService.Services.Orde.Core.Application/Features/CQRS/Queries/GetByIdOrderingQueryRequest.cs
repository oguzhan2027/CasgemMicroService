using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderingQueryRequest : IRequest<ResultOrderingDto>
    {
        public int Id { get; set; }

        public GetByIdOrderingQueryRequest(int ıd)
        {
            Id = ıd;
        }
    }
}
