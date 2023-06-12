using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
	public interface IDataService
	{
		Task<Result<IEnumerable<dynamic>>> GetRoles();
		Task<Result<IEnumerable<StateViewModel>>> GetStates();
		Task<Result<IEnumerable<CityViewModel>>> GetCitiesByState(int stateId);
		Task<Result<IEnumerable<CityViewModel>>> GetCities();
        Task<Result<IEnumerable<object>>> GetStatesWithCities();
		Task<Result<IEnumerable<SpecialtyViewModel>>> GetSpecialties();
		Task<Result<IEnumerable<LanguageViewModel>>> GetLanguages();
        Result<IEnumerable<dynamic>> GetGenders();
        Result<IEnumerable<dynamic>> GetMaritalStatuses();
    }
}
