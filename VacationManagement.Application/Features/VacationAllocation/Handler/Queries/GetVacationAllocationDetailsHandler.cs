using AutoMapper;
using MediatR;
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
    public class GetVacationRequestsDetailsHandler : IRequestHandler<GetVacationAllocationDetailsRequest, VacationAllocationDto>
    {
        private readonly IVacationAllocationRepository _vacationAllocationRepository;
        private readonly IMapper _mapper;

        public GetVacationRequestsDetailsHandler(IVacationAllocationRepository vacationAllocationRepository, IMapper mapper)
        {
            _vacationAllocationRepository = vacationAllocationRepository;
            _mapper = mapper;
        }

        public async Task<VacationAllocationDto> Handle(GetVacationAllocationDetailsRequest request, CancellationToken cancellationToken)
        {
            var vacationType = await _vacationAllocationRepository.GetVacationAllocationWithDetails(request.Id);
            return _mapper.Map<VacationAllocationDto>(vacationType);
        }
    }
}