using AutoMapper;
using Casgem.MicroService.Services.Orde.Core.Application.Dtos.AddressDtos;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Mappings
{
    public class AddressProfile:Profile
    {
        public AddressProfile()
        {
            CreateMap<ResultAddressDto,Address>().ReverseMap();
            CreateMap<CreateAddressDto,Address>().ReverseMap();
            CreateMap<UpdateAddressDto,Address>().ReverseMap();
        }
    }
}
