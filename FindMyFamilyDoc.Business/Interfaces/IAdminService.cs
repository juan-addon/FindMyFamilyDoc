using FindMyFamilyDoc.Business.Helpers;

namespace FindMyFamilyDoc.Business.Interfaces
{
    public interface IAdminService
    {
        Task<Result<dynamic>> ApproveDoctor(string userId);
    }
}