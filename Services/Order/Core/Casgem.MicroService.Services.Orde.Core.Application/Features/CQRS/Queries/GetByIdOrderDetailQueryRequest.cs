using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDetailsDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries
{
    public class GetByIdOrderDetailQueryRequest : IRequest<ResultOrderDetailDto>
    {
        

        public int Id { get; set; }
        public GetByIdOrderDetailQueryRequest(int ıd)
        {
            Id = ıd;
        }

    }
}
