using Entities.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebUI.ValidationRules.RegisterationRules
{
    public class RegisterationValidator : AbstractValidator<UserRegisterationDto>
    {
        public RegisterationValidator()
        {
            RuleFor(x=> x.Email).NotEmpty();
            RuleFor(x=> x.Password).NotEmpty();
            RuleFor(x=>x.PhoneNumber).NotEmpty();
            RuleFor(x=>x.ConfirmPassword).NotEmpty();
        }
    }
}
