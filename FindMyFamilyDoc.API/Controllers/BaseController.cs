using FindMyFamilyDoc.Business.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IActionResult Success<T>(T data) where T : class
        {
            return Ok(ApiResponse<T>.SuccessResponse(data));
        }

        protected IActionResult Error(IEnumerable<string> errors)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(errors));
        }

        protected IActionResult Error(string error)
        {
            return BadRequest(ApiResponse<object>.ErrorResponse(error));
        }

        protected IActionResult Error(IEnumerable<IdentityError> errors)
        {
            var errorMessages = errors.Select(e => e.Description).ToList();
            return BadRequest(ApiResponse<object>.ErrorResponse(errorMessages));
        }

        protected IActionResult UnauthorizedError()
        {
            return Unauthorized(ApiResponse<object>.ErrorResponse(new List<string> { "Unauthorized" }));
        }
    }

}
