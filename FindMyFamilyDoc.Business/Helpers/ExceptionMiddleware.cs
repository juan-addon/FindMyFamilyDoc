using FindMyFamilyDoc.Shared.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace FindMyFamilyDoc.Business.Helpers
{
    public class ExceptionMiddleware
    {
        private RequestDelegate Next { get; }

        public ExceptionMiddleware(RequestDelegate next)
        {
            Next = next;
        }

		protected Result<T> Error<T>(ApiErrorCode errorCode, string errorMessage)
		{
			var errors = new Dictionary<string, string[]>
			{
				{ "errors", new string[] { errorMessage } }
			};
			return new Result<T>(errorCode.ToString(), errors);
		}

		public async Task Invoke(HttpContext context)
        {
            try
            {
                await Next(context);
            }
            catch (Exception ex)
            {
				context.Response.ContentType = "application/problem+json";
				context.Response.StatusCode = StatusCodes.Status500InternalServerError;

				var errorResult = Error<ProblemDetails>(
					ApiErrorCode.InternalServerError,
					"Internal Server Error - Something went wrong"
				);

				var problemDetailJson = JsonSerializer.Serialize(errorResult);
				await context.Response.WriteAsync(problemDetailJson);
			}
        }
    }
}
