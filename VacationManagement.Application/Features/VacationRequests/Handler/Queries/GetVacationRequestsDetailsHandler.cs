using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.DTOs;
using VacationManagement.Application.DTOs.VacationRequset;
using VacationManagement.Application.Features.VacationRequests.Requests.Queries;
using VacationManagement.Application.Persistence.Contracts;

namespace VacationManagement.Application.Features.VacationRequests.Handler.Queries
{
    public class GetVacationRequestsDetailsHandler : IRequestHandler<GetVacationRequestsDetailsRequest, VacationRequestDto>
    {
        private readonly IVacationRequestRepository _vacationRequestRepository;
        private readonly IMapper _mapper;

        public GetVacationRequestsDetailsHandler(IVacationRequestRepository vacationAllocationRepository, IMapper mapper)
        {
            _vacationRequestRepository = vacationAllocationRepository;
            _mapper = mapper;
        }

        public async Task<VacationRequestDto> Handle(GetVacationRequestsDetailsRequest request, CancellationToken cancellationToken)
        {
            var vacationType = await _vacationRequestRepository.GetVacationRequsetWithDetails(request.Id);
            return _mapper.Map<VacationRequestDto>(vacationType);
        }
    }
}