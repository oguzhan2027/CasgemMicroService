using CasgemMicroService.Services.Cargo.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CasgemMicroService.Services.Cargo.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CargoDetailsController : ControllerBase
	{
		private readonly ICargoDetailService _cargoDetailService;

		public CargoDetailsController(ICargoDetailService cargoDetailService)
		{
			_cargoDetailService = cargoDetailService;
		}
		[HttpGet]
		public IActionResult CargoDetailList()
		{
			var values = _cargoDetailService.GetAll();
			return Ok(values);
		}
		[HttpGet("{id}")]
		public IActionResult CargoDetailGet(int id)
		{
			var value = 
		}
	}
}

