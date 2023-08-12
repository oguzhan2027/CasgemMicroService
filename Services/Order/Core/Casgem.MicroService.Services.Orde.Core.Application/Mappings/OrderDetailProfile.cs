using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Dtos.AddressDtos;

using Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDetailsDtos;
using CasgemMicroService.Services.Order.Core.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Mappings
{
    public class OrderDetailProfile : Profile
    {
        public OrderDetailProfile()
        {
            CreateMap<ResultOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<CreateOrderDetailDto, OrderDetail>().ReverseMap();
            CreateMap<UpdateOrderDetailDto, OrderDetail>().ReverseMap();
        }
    }
}
