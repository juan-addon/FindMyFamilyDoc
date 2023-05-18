using Ganss.Xss;
using System.ComponentModel.DataAnnotations;

namespace FindMyFamilyDoc.Business.Helpers
{
    public class SanitizeAttribute : ValidationAttribute
    {
        private readonly HtmlSanitizer _sanitizer;

        public SanitizeAttribute()
        {
            _sanitizer = new HtmlSanitizer();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue)
            {
                var sanitizedValue = _sanitizer.Sanitize(stringValue);
                validationContext.ObjectType.GetProperty(validationContext.MemberName).SetValue(validationContext.ObjectInstance, sanitizedValue);
            }

            return ValidationResult.Success;
        }
    }
}
