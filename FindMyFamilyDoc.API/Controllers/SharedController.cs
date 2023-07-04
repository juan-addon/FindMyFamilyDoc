using FindMyFamilyDoc.API.Authentication;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[ServiceFilter(typeof(ApiKeyAuthFilter))]
	public class SharedController : BaseController
	{
		private readonly IDataService _dataService;
        private readonly IDoctorService _doctorService;

        public SharedController(IDataService dataService, IDoctorService doctorService)
		{
			_dataService = dataService;
            _doctorService = doctorService;
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

		[HttpGet("cities-by-state")]
		public async Task<IActionResult> GetCitiesByState(int stateId)
		{
			var result = await _dataService.GetCitiesByState(stateId);
			return Result(result);
		}

        [HttpGet("cities")]
        public async Task<IActionResult> GetCities()
        {
            var result = await _dataService.GetCities();
            return Result(result);
        }

        [HttpGet("specialties")]
		public async Task<IActionResult> GetSpecialties()
		{
			var result = await _dataService.GetSpecialties();
			return Result(result);
		}

		[HttpGet("languages")]
		public async Task<IActionResult> GetLanguages()
		{
			var result = await _dataService.GetLanguages();
			return Result(result);
		}

        [HttpGet("genders")]
        public IActionResult GetGenders()
        {
            var result = _dataService.GetGenders();
            return Result(result);
        }

        [HttpGet("maritalstatuses")]
        public IActionResult GetMaritalStatuses()
        {
            var result = _dataService.GetMaritalStatuses();
            return Result(result);
        }

        [HttpGet("weekdays")]
        public IActionResult GetWeekDays()
        {
            var result = _dataService.GetWeekDays();
            return Result(result);
        }

        [HttpGet("get-doctors")]
        public async Task<IActionResult> GetDoctors([FromQuery] DoctorSearchViewModel searchModel)
        {
            var result = await _doctorService.SearchDoctor(searchModel);
            return Result(result);
        }
    }
}