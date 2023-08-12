﻿using Casgem.MicroService.Services.Orde.Core.Application.Dtos.AddressDtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries
{
    public class GetByIdAddressQueryRequest : IRequest<ResultAddressDto>
    {
        public GetByIdAddressQueryRequest(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
      
    }
}
