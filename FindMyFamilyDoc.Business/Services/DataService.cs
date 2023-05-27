using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Services
{
	public class DataService : IDataService
	{
		private readonly RoleManager<IdentityRole> _roleManager;
		private readonly DatabaseContext _dbContext;

		public DataService(RoleManager<IdentityRole> roleManager, DatabaseContext dbContext)
		{
			_roleManager = roleManager;
			_dbContext = dbContext;
		}

		public async Task<Result<IEnumerable<string>>> GetRoles()
		{
			try
			{
				var roles = await _roleManager.Roles.Select(r => r.Name).ToListAsync();

				if (roles == null)
				{
					return new Result<IEnumerable<string>>(ApiErrorCode.DataNotFound.ToString(), "Roles not found");
				}

				return new Result<IEnumerable<string>>(roles!);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<string>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<IEnumerable<State>>> GetStates()
		{
			try
			{
				var states = await _dbContext.States.ToListAsync();

				if (states == null)
				{
					return new Result<IEnumerable<State>>(ApiErrorCode.DataNotFound.ToString(), "States not found");
				}

				return new Result<IEnumerable<State>>(states);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<State>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<IEnumerable<object>>> GetStatesWithCities()
		{
			try
			{
				var statesWithCities = await _dbContext.States
					.Select(s => new
					{
						s.Id,
						s.Name,
						Cities = _dbContext.Cities.Where(c => c.StateId == s.Id).Select(c => new { c.Id, c.Name }).ToList()
					})
					.ToListAsync();

				if (statesWithCities == null)
				{
					return new Result<IEnumerable<object>>(ApiErrorCode.DataNotFound.ToString(), "States not found");
				}

				return new Result<IEnumerable<object>>(statesWithCities);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<object>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<IEnumerable<City>>> GetCitiesByState(int stateId)
		{
			try
			{
				var cities = await _dbContext.Cities.Where(c => c.StateId == stateId).ToListAsync();

				if (cities == null)
				{
					return new Result<IEnumerable<City>>(ApiErrorCode.DataNotFound.ToString(), "Cities not found");
				}

				return new Result<IEnumerable<City>>(cities);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<City>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}
	}
}