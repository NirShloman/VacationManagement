using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.Features.VacationRequests.Requests.Commands;
using VacationManagement.Application.Persistence.Contracts;
using VacationManagement.Domain;

namespace VacationManagement.Application.Features.VacationRequests.Handler.Commands
{
    public class CreateVacationRequestCommandHandler : IRequestHandler<CreateVacationRequestCommand, int>
    {
        private readonly IVacationRequestRepository _vacationRequestRepository;
        private readonly IMapper _mapper;

        public async Task<int> Handle(CreateVacationRequestCommand request, CancellationToken cancellationToken)
        {
            var vactionType = _mapper.Map<VacationRequset>(request.VacationRequestsDto);

            vactionType = await _vacationRequestRepository.Add(vactionType);

            return vactionType.Id;
        }
    }
}