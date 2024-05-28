using AutoMapper;
using MediatR;
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
    public class GetVacationAllocationDetailsHandler : IRequestHandler<GetVacationAllocationDetailsRequest, VacationTypeDto>
    {
        private readonly IVacationTypeRepository _vacationTypeRepository;
        private readonly IMapper _mapper;

        public GetVacationAllocationDetailsHandler(IVacationTypeRepository vacationTypeRepository, IMapper mapper)
        {
            _vacationTypeRepository = vacationTypeRepository;
            _mapper = mapper;
        }

        public async Task<VacationTypeDto> Handle(GetVacationAllocationDetailsRequest request, CancellationToken cancellationToken)
        {
            var vacationType = _vacationTypeRepository.GetVacationTypeWithDetails(request.Id);
            return _mapper.Map<VacationTypeDto>(vacationType);
        }
    }
}