using System.ComponentModel.DataAnnotations;

namespace Web.Api.Service.Attributes
{
    public class CheckEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var email = value as string;

            if (email.Contains("@gmail.com") || email.Contains("@yandex.ru"))
                return ValidationResult.Success;

            return new ValidationResult("Please enter only gmail or yandex email!");
        }
    }
}
