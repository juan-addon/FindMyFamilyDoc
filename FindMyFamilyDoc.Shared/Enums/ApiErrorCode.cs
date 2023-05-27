namespace FindMyFamilyDoc.Shared.Enums
{
	public enum ApiErrorCode
	{
		// General errors
		InternalServerError,
		BadRequest,
		Unauthorized,
		Forbidden,
		NotFound,

		// Validation errors
		ValidationError,
		InvalidEmailFormat,
		InvalidPasswordFormat,
		PasswordsDoNotMatch,
		EmailAlreadyRegistered,
		UsernameAlreadyRegistered,
		UserNotActivated,
		UserLocked,

		// Authentication errors
		InvalidCredentials,
		SessionExpired,
		TokenInvalid,
		TokenExpired,
		UserNotAuthenticated,
		UserNotFound,

		// Rate limiting
		TooManyRequests,

		//GeneralError
		RequestError,
		DataNotFound
	}

}
