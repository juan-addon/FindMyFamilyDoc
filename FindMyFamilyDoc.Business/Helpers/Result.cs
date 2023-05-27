namespace FindMyFamilyDoc.Business.Helpers
{
    public class Result<T>
    {
        public T? Data { get; }
        public bool Success { get; }
        public string? ErrorCode { get; }
        public IDictionary<string, string[]>? Errors { get; }

        public Result(T data)
        {
            Data = data;
            Success = true;
        }

        public Result(string errorCode, IDictionary<string, string[]> errors = null!)
        {
            ErrorCode = errorCode;
            Errors = errors;
            Success = false;
        }

		public Result(string errorCode, string errorMessage)
		{
			ErrorCode = errorCode;
			Errors = new Dictionary<string, string[]>
		    {
			    { "error", new string[] { errorMessage } }
		    };
			Success = false;
		}
	}
}