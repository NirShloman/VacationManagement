using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.DTOs.VacationAllocation;
using VacationManagement.Application.Features.VacationAllocation.Requests.Queries;
using VacationManagement.Application.Persistence.Contracts;

namespace VacationManagement.Application.Features.VacationAllocation.Handler.Queries
{
    public class GetVacationRequestsListRequestHandler : IRequestHandler<GetVacationAllocationListRequest, List<VacationAllocationDto>>
    {
        private readonly IVacationAllocationRepository _vacationAllocationRepository;
        private readonly IMapper _mapper;

        public GetVacationRequestsListRequestHandler(IVacationAllocationRepository vacationAllocationRepository, IMapper mapper)
        {
            _vacationAllocationRepository = vacationAllocationRepository;
            _mapper = mapper;
        }

        public async Task<List<VacationAllocationDto>> Handle(GetVacationAllocationListRequest request, CancellationToken cancellationToken)
        {
            var vacationType = await _vacationAllocationRepository.GetVacationAllocationWithDetails();
            return _mapper.Map<List<VacationAllocationDto>>(vacationType);
        }
    }
}