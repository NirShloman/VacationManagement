using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace VacationManagement.Application.DTOs.VacationRequset.Validators
{
    public class CreateVacationRequestDtoValidator : AbstractValidator<CreateVacationRequsetDto>
    {
        public CreateVacationRequestDtoValidator()
        {
            RuleFor(p => p.EndDate)
                .NotEmpty().WithMessage("")
                .NotNull()
                .GreaterThan(p => p.StartDate).WithMessage("");

            RuleFor(p => p.StartDate)
                .NotEmpty().WithMessage("")
                .NotEmpty()
                .LessThan(p => p.EndDate);
        }
    }
}