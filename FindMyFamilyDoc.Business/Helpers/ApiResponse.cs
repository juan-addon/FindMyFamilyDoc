namespace FindMyFamilyDoc.Business.Helpers
{
    public class ApiResponse<T>
    {
        public bool Result { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Errors { get; set; }

        public ApiResponse(bool result, T data, IEnumerable<string> errors)
        {
            Result = result;
            Data = data;
            Errors = errors;
        }

        public static ApiResponse<T> SuccessResponse(T data)
        {
            return new ApiResponse<T>(true, data, null!);
        }

        public static ApiResponse<T> ErrorResponse(IEnumerable<string> errors)
        {
            return new ApiResponse<T>(false, default(T)!, errors);
        }

        public static ApiResponse<T> ErrorResponse(string error)
        {
            return new ApiResponse<T>(false, default(T)!, new List<string> { error });
        }
    }
}
