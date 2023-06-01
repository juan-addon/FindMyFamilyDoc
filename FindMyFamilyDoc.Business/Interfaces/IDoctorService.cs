using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Models;
using FindMyFamilyDoc.Shared.ViewModels;

namespace FindMyFamilyDoc.Business.Interfaces
{
	public interface IDoctorService
	{
		Task<Result<IEnumerable<Doctor>>> GetDoctors();
		Task<Result<Doctor>> GetDoctorById(int id);
		Task<Result<Doctor>> CreateDoctor(DoctorViewModel model);
	}
}
