using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Application.Features.VacationTypes.Requests.Queries;
using VacationManagement.Application.Persistence.Contracts;

namespace VacationManagement.Application.Features.VacationTypes.Handler.Queries
{
    public class GetVacationAllocationListRequestHandler : IRequestHandler<GetVacationAllocationListRequest, List<VacationTypeDto>>
    {
        private readonly IVacationTypeRepository _vacationAllocationRepository;
        private readonly IMapper _mapper;

        public GetVacationAllocationListRequestHandler(IVacationTypeRepository vacationTypeRepository, IMapper mapper)
        {
            _vacationAllocationRepository = vacationTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<VacationTypeDto>> Handle(GetVacationAllocationListRequest request, CancellationToken cancellationToken)
        {
            var vacationType = await _vacationAllocationRepository.GetVacationTypeWithDetails();
            return _mapper.Map<List<VacationTypeDto>>(vacationType);
        }
    }
}