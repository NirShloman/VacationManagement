using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VacationManagement.Application.DTOs.VacationType.Validators
{
    public class CreateVacationTypeDtoValidator : AbstractValidator<VacationTypeDto>
    {
        public CreateVacationTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is {required.}")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 charcters.");

            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} is {required.}")
                .GreaterThan(0).WithMessage("{PropertyName} must be least 1.}")
                .LessThan(100).WithMessage("{PropertyName} must be less than 100.");
        }
    }
}