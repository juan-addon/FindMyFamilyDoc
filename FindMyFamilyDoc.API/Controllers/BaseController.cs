using FindMyFamilyDoc.API.Helpers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FindMyFamilyDoc.API.Controllers
{
    public class BaseController : ControllerBase
    {
        protected IActionResult Success<T>(T data)
        {
            return Ok(new ApiResponse<T>(true, data, null!));
        }

        protected IActionResult Error(IEnumerable<string> errors)
        {
            return BadRequest(new ApiResponse<object>(false, null!, errors));
        }

        protected IActionResult Error(string error)
        {
            return BadRequest(new ApiResponse<object>(false, null!, new List<string> { error }));
        }

        protected IActionResult Error(IEnumerable<IdentityError> errors)
        {
            var errorMessages = errors.Select(e => e.Description).ToList();
            return BadRequest(new ApiResponse<object>(false, null!, errorMessages));
        }

        protected IActionResult UnauthorizedError()
        {
            return Unauthorized(new ApiResponse<object>(false, null!, new List<string> { "Unauthorized" }));
        }
    }
}
