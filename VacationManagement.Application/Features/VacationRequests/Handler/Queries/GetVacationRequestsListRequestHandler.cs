using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
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
    public class GetVacationRequestsListRequestHandler : IRequestHandler<GetVacationRequestsListRequest, List<VacationRequestDto>>
    {
        private readonly IVacationRequestRepository _vacationRequestRepository;
        private readonly IMapper _mapper;

        public GetVacationRequestsListRequestHandler(IVacationRequestRepository vacationAllocationRepository, IMapper mapper)
        {
            _vacationRequestRepository = vacationAllocationRepository;
            _mapper = mapper;
        }

        public async Task<List<VacationRequestDto>> Handle(GetVacationRequestsListRequest request, CancellationToken cancellationToken)
        {
            var vacationType = await _vacationRequestRepository.GetVacationRequsetWithDetails();
            return _mapper.Map<List<VacationRequestDto>>(vacationType);
        }
    }
}