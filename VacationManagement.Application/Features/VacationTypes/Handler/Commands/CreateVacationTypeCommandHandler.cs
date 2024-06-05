using AutoMapper;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Application.DTOs.VacationType.Validators;
using VacationManagement.Application.Features.VacationTypes.Requests.Commands;
using VacationManagement.Application.Persistence.Contracts;
using VacationManagement.Domain;
using VacationManagement.Domain.Common;

namespace VacationManagement.Application.Features.VacationTypes.Handler.Commands
{
    public class CreateVacationTypeCommandHandler : IRequestHandler<CreateVacationTypeCommand, int>
    {
        private readonly IVacationTypeRepository _vacationTypeRepository;
        private readonly IMapper _mapper;

        public CreateVacationTypeCommandHandler(IVacationTypeRepository vacationTypeRepository, IMapper mapper)
        {
            _vacationTypeRepository = vacationTypeRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateVacationTypeCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateVacationTypeDtoValidator();
            var validationResult = await validator.ValidateAsync(request.VacationTypeDto);

            if (validationResult.IsValid == false)
            {
                throw new Exception();
            }

            var vacationType = _mapper.Map<VacationType>(request.VacationTypeDto);

            vacationType = await _vacationTypeRepository.Add(vacationType);
            return vacationType.Id;
        }
    }
}