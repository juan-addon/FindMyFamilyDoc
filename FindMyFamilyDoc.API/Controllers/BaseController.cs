using FindMyFamilyDoc.Business.Helpers;
using FindMyFamilyDoc.Shared.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FindMyFamilyDoc.API.Controllers
{
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected Result<T> Success<T>(T data)
        {
            return new Result<T>(data);
        }

		protected Result<T> Error<T>(ApiErrorCode errorCode, ModelStateDictionary modelState = null)
		{
			IDictionary<string, string[]> errors = null!;
			if (modelState != null && !modelState.IsValid)
			{
				errors = modelState
					.Where(m => m.Value!.Errors.Count > 0)
					.ToDictionary(
						kvp => kvp.Key,
						kvp => kvp.Value!.Errors.Select(e => e.ErrorMessage).ToArray()
					);
			}
			return new Result<T>(errorCode.ToString(), errors!);
		}

		protected Result<T> Error<T>(ApiErrorCode errorCode, IEnumerable<string> errorList)
        {
            var errors = new Dictionary<string, string[]>
            {
                { "errors", errorList.ToArray() }
            };
            return new Result<T>(errorCode.ToString(), errors);
        }

		protected Result<T> Error<T>(ApiErrorCode errorCode, string error)
		{
			var errors = new Dictionary<string, string[]>
			{
				{ "errors", new string[] { error } }
			};
			return new Result<T>(errorCode.ToString(), errors);
		}

		protected IActionResult Result<T>(Result<T> result)
        {
            if (result.Success)
                return Ok(result);

            return BadRequest(result); // Or return different HTTP status code based on ErrorCode
        }
    }

}
