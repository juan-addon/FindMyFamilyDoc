using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Models;

namespace FindMyFamilyDoc.Business.Interfaces
{
	public interface IDataService
	{
		Task<Result<IEnumerable<string>>> GetRoles();
		Task<Result<IEnumerable<State>>> GetStates();
		Task<Result<IEnumerable<City>>> GetCitiesByState(int stateId);
		Task<Result<IEnumerable<object>>> GetStatesWithCities();
	}
}
