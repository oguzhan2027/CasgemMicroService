﻿using Casgem.MicroService.Services.Orde.Core.Application.Dtos.AddressDtos;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroService.Services.Order.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddresesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddresesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> AddressList()
        {
            var values = await _mediator.Send(new GetAllAddressQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> AddressGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdAddressQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> AddressCreate(CreateAddressCommandRequest createAddressCommandRequest)
        {
            await _mediator.Send(createAddressCommandRequest);
            return Ok("Adres Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> AddressUpdate(UpdateAddresCommandRequest updateAddresCommandRequest)
        {
            await _mediator.Send(updateAddresCommandRequest);
            return Ok("Adres Güncelendi");
        }
        [HttpDelete]
        public async Task<IActionResult> AddressDelete(int id)
        {
            await _mediator.Send(new RemoveAddressCommandRequest(id));
            return Ok("Adres Silindi");
        }
    }
}
