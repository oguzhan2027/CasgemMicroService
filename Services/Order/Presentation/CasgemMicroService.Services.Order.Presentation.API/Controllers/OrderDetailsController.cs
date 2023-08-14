using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroService.Services.Order.Presentation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderDetailsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> OrderDetailList()
        {
            var values = await _mediator.Send(new GetAllOrderDetailQueryRequest());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> OrderDetailGetById(int id)
        {
            var value = await _mediator.Send(new GetByIdOrderDetailQueryRequest(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> OrderDetailCreate(CreateOrderDetailCommandRequest createOrderDetailCommandRequest)
        {
            await _mediator.Send(createOrderDetailCommandRequest);
            return Ok("Adres Eklendi");
        }
        [HttpPut]
        public async Task<IActionResult> OrderDetailUpdate(UpdateAddresCommandRequest updateAddresCommandRequest)
        {
            await _mediator.Send(updateAddresCommandRequest);
            return Ok("Adres Güncelendi");
        }
        [HttpDelete]
        public async Task<IActionResult> OrderDetailDelete(int id)
        {
            await _mediator.Send(new RemoveOrderDetailCommandRequest(id));
            return Ok("Adres Silindi");
        }
    }
}
