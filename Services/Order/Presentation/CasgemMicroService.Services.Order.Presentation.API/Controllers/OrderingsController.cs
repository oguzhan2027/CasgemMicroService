using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Qeries;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroService.Services.Order.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> OrderingList()
        {
            var values = await _mediator.Send(new GetAllOrderingQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderingGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdOrderingQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> OrderingCreate(CreateOrderingCommandRequest createOrderingCommandRequest)
        {
            await _mediator.Send(createOrderingCommandRequest);
            return Ok("Order Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderingUpdate(UpdateAddresCommandRequest updateAddresCommandRequest)
        {
            await _mediator.Send(updateAddresCommandRequest);
            return Ok("Order Güncelendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderingDelete(int id)
        {
            await _mediator.Send(new RemoveOrderingCommandRequest(id));
            return Ok("Order Silindi");
        }
    }
}
