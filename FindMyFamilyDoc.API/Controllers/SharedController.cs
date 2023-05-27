using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[ServiceFilter(typeof(ApiKeyAuthFilter))]
	public class SharedController : BaseController
	{
		private readonly IDataService _dataService;
		public SharedController(IDataService dataService)
		{
			_dataService = dataService;
		}

		[HttpGet("roles")]
		public async Task<IActionResult> GetRoles()
		{
			var result = await _dataService.GetRoles();
			return Result(result);
		}

		[HttpGet("states")]
		public async Task<IActionResult> GetStates()
		{
			var result = await _dataService.GetStates();
			return Result(result);
		}

		[HttpGet("states-with-cities")]
		public async Task<IActionResult> GetStatesWithCities()
		{
			var result = await _dataService.GetStatesWithCities();
			return Result(result);
		}

		[HttpGet("cities")]
		public async Task<IActionResult> GetCitiesByState(int stateId)
		{
			var result = await _dataService.GetCitiesByState(stateId);
			return Result(result);
		}
	}
}
