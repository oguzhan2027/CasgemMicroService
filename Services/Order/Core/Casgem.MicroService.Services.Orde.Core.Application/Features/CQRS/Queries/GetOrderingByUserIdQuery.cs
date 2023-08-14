using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries
{
    public class GetOrderingByUserIdQuery : IRequest<List<ResultOrderingDto>>
    {
        public string Id { get; set; }
    }
}
