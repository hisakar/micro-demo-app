using Business.Handlers.Auth.Commands;
using FluentValidation;

namespace Business.Handlers.Auth.ValidationRules
{
    public class RegisterUserValidator : AbstractValidator<RegisterUserCommand>
    {
        public RegisterUserValidator()
        {
            RuleFor(p => p.Password).Password();
        }
    }
}