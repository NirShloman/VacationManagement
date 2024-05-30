using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.DTOs.VacationAllocation;
using VacationManagement.Application.Features.VacationAllocation.Requests.Commands;
using VacationManagement.Application.Persistence.Contracts;
using VacationManagement.Domain;

namespace VacationManagement.Application.Features.VacationAllocation.Handler.Commands
{
    public class CreateVacationAllocationCommandHandler : IRequestHandler<CreateVacationAllocationCommand, int>
    {
        private readonly IVacationAllocationRepository _vacationAllocationRepository;
        private readonly IMapper _mapper;

        public CreateVacationAllocationCommandHandler(IVacationAllocationRepository vacationAllocationRepository, IMapper mapper)
        {
            _vacationAllocationRepository = vacationAllocationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateVacationAllocationCommand request, CancellationToken cancellationToken)
        {
            var vacationType = _mapper.Map<Domain.VacationAllocation>(request.VacationAllocationDto);

            vacationType = await _vacationAllocationRepository.Add(vacationType);

            return vacationType.Id;
        }
    }
}