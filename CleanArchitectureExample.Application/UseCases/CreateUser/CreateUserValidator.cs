using FluentValidation;

namespace CleanArchitectureExample.Application.UseCases.CreateUser
{
    public sealed class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserValidator() { 
            RuleFor(x=> x.Email).NotEmpty().MaximumLength(500);
        }
    }
}
