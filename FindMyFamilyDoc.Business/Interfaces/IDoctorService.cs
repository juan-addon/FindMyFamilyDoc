using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Models;

namespace FindMyFamilyDoc.Business.Interfaces
{
	public interface IDoctorService
	{
		Task<Result<IEnumerable<Doctor>>> GetDoctors();
		Task<Result<Doctor>> GetDoctorById(int id);
		Task<Result<Doctor>> CreateDoctor(Doctor doctor);
		Task<Result<Doctor>> UpdateDoctor(Doctor doctor);
		Task<Result<bool>> DeleteDoctor(int id);
	}

}
