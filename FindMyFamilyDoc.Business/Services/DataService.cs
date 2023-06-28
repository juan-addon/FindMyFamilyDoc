using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.ViewModels;
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

        public async Task<Result<IEnumerable<dynamic>>> GetRoles()
        {
            try
            {
                var roles = await _roleManager.Roles
                    .Where(r => r.Name != UserRoles.DoctorUnderReview.ToString())
                    .Select(r => new
                    {
                        RoleName = r.Name,
                        RoleDescription = EnumExtensions.GetDescription(Enum.Parse<UserRoles>(r.Name!))
                    })
                    .ToListAsync();

                if (!roles.Any())
                {
                    return new Result<IEnumerable<dynamic>>(ApiErrorCode.DataNotFound.ToString(), "Roles not found");
                }

                return new Result<IEnumerable<dynamic>>(roles!);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<dynamic>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
            }
        }

        public async Task<Result<IEnumerable<StateViewModel>>> GetStates()
		{
			try
			{
				var states = await _dbContext.States
                    .Select(m => new StateViewModel
                    {
                        StateId = m.Id,
                        StateName = m.Name
                    })
                    .ToListAsync();

				if (states == null)
				{
					return new Result<IEnumerable<StateViewModel>>(ApiErrorCode.DataNotFound.ToString(), "States not found");
				}

				return new Result<IEnumerable<StateViewModel>>(states);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<StateViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
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

		public async Task<Result<IEnumerable<CityViewModel>>> GetCitiesByState(int stateId)
		{
			try
			{
				var cities = await _dbContext.Cities.Where(c => c.StateId == stateId)
                     .Select(m => new CityViewModel
                     {
                         CityId = m.Id,
                         CityName = m.Name,
						 StateId = m.StateId
                     })
                    .ToListAsync();

				if (cities == null)
				{
					return new Result<IEnumerable<CityViewModel>>(ApiErrorCode.DataNotFound.ToString(), "Cities not found");
				}

				return new Result<IEnumerable<CityViewModel>>(cities);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<CityViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

        public async Task<Result<IEnumerable<CityViewModel>>> GetCities()
        {
            try
            {
                var cities = await _dbContext.Cities
                     .Select(m => new CityViewModel
                     {
                         CityId = m.Id,
                         CityName = m.Name,
                         StateId = m.StateId
                     })
                    .ToListAsync();

                if (cities == null)
                {
                    return new Result<IEnumerable<CityViewModel>>(ApiErrorCode.DataNotFound.ToString(), "Cities not found");
                }

                return new Result<IEnumerable<CityViewModel>>(cities);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<CityViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
            }
        }

        public async Task<Result<IEnumerable<SpecialtyViewModel>>> GetSpecialties()
		{
			try
			{
				var specialties = await _dbContext.Specialties
					.Select(m => new SpecialtyViewModel
                    {
						SpecialtyId = m.Id,
                        SpecialtyName = m.Name
					})
					.ToListAsync();

				if (specialties == null || !specialties.Any())
				{
					return new Result<IEnumerable<SpecialtyViewModel>>(ApiErrorCode.DataNotFound.ToString(), "Specialties not found");
				}

				return new Result<IEnumerable<SpecialtyViewModel>>(specialties);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<SpecialtyViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

		public async Task<Result<IEnumerable<LanguageViewModel>>> GetLanguages()
		{
			try
			{
				var languages = await _dbContext.Languages
                     .Select(m => new LanguageViewModel
                     {
                          LanguageId = m.Id,
                          LanguageName = m.Name
                      })
                    .ToListAsync();

				if (languages == null || !languages.Any())
				{
					return new Result<IEnumerable<LanguageViewModel>>(ApiErrorCode.DataNotFound.ToString(), "Languages not found");
				}

				return new Result<IEnumerable<LanguageViewModel>>(languages);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<LanguageViewModel>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
			}
		}

        public Result<IEnumerable<dynamic>> GetGenders()
        {
            try
            {
                var genders = Enum.GetValues(typeof(Gender))
                    .Cast<Gender>()
                    .Select(g => new
                    {
                        value = g.ToString(),
                        description = g.GetDescription()
                    })
                    .ToList();

                return new Result<IEnumerable<dynamic>>(genders);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<dynamic>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
            }
        }

        public Result<IEnumerable<dynamic>> GetMaritalStatuses()
        {
            try
            {
                var maritalStatuses = Enum.GetValues(typeof(MaritalStatus))
                    .Cast<MaritalStatus>()
                    .Select(ms => new
                    {
                        value = ms.ToString(),
                        description = ms.GetDescription()
                    })
                    .ToList();

                return new Result<IEnumerable<dynamic>>(maritalStatuses);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<dynamic>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
            }
        }

        public Result<IEnumerable<dynamic>> GetWeekDays()
        {
            try
            {
                var weekDays = Enum.GetValues(typeof(WeekDay))
                    .Cast<WeekDay>()
                    .Select(ms => new
                    {
                        value = ms.ToString()
                    })
                    .ToList();

                return new Result<IEnumerable<dynamic>>(weekDays);
            }
            catch (Exception ex)
            {
                return new Result<IEnumerable<dynamic>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred: {ex.Message}");
            }
        }
    }
}