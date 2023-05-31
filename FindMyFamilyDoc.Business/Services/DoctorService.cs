using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Business.Interfaces;
using FindMyFamilyDoc.Shared.Enums;
using FindMyFamilyDoc.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace FindMyFamilyDoc.Business.Services
{
	public class DoctorService : IDoctorService
	{
		private readonly DatabaseContext _dbContext;

		public DoctorService(DatabaseContext dbContext)
		{
			_dbContext = dbContext;
		}

		public async Task<Result<IEnumerable<Doctor>>> GetDoctors()
		{
			try
			{
				var doctors = await _dbContext.Doctors.ToListAsync();
				return new Result<IEnumerable<Doctor>>(doctors);
			}
			catch (Exception ex)
			{
				return new Result<IEnumerable<Doctor>>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving doctors: {ex.Message}");
			}
		}

		public async Task<Result<Doctor>> GetDoctorById(int id)
		{
			try
			{
				var doctor = await _dbContext.Doctors.FindAsync(id);
				if (doctor != null)
					return new Result<Doctor>(doctor);
				else
					return new Result<Doctor>(ApiErrorCode.DataNotFound.ToString(), $"Doctor with ID {id} not found.");
			}
			catch (Exception ex)
			{
				return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while retrieving the doctor: {ex.Message}");
			}
		}

		public async Task<Result<Doctor>> CreateDoctor(Doctor doctor)
		{
			try
			{
				_dbContext.Doctors.Add(doctor);
				await _dbContext.SaveChangesAsync();
				return new Result<Doctor>(doctor);
			}
			catch (Exception ex)
			{
				return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while creating the doctor: {ex.Message}");
			}
		}

		public async Task<Result<Doctor>> UpdateDoctor(Doctor doctor)
		{
			try
			{
				_dbContext.Entry(doctor).State = EntityState.Modified;
				await _dbContext.SaveChangesAsync();
				return new Result<Doctor>(doctor);
			}
			catch (Exception ex)
			{
				return new Result<Doctor>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while updating the doctor: {ex.Message}");
			}
		}

		public async Task<Result<bool>> DeleteDoctor(int id)
		{
			try
			{
				var doctor = await _dbContext.Doctors.FindAsync(id);
				if (doctor != null)
				{
					_dbContext.Doctors.Remove(doctor);
					await _dbContext.SaveChangesAsync();
					return new Result<bool>(true);
				}
				else
				{
					return new Result<bool>(ApiErrorCode.DataNotFound.ToString(), $"Doctor with ID {id} not found.");
				}
			}
			catch (Exception ex)
			{
				return new Result<bool>(ApiErrorCode.InternalServerError.ToString(), $"An error occurred while deleting the doctor: {ex.Message}");
			}
		}
	}
}