using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VacationManagement.Application.Features.VacationRequests.Requests.Commands;
using VacationManagement.Application.Persistence.Contracts;

namespace VacationManagement.Application.Features.VacationRequests.Handler.Commands
{
    public class UpdateVacationRequestCommandHandler : IRequestHandler<UpdateVacationRequestCommand, Unit>
    {
        private readonly IVacationRequestRepository _vacationRequestRepository;
        private readonly IMapper _mapper;

        public UpdateVacationRequestCommandHandler(IVacationRequestRepository vacationRequestRepository, IMapper mapper)
        {
            _vacationRequestRepository = vacationRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateVacationRequestCommand request, CancellationToken cancellationToken)
        {
            var vacationRequest = await _vacationRequestRepository.Get(request.Id);

            if (request.VacationTypeDto != null)
            {
                _mapper.Map(request.VacationTypeDto, vacationRequest);

                await _vacationRequestRepository.Update(vacationRequest);
            }
            else if (request.changeVacationRequsetApprovalDto != null)
            {
                await _vacationRequestRepository.ChangeApprovalStatus(vacationRequest, request.changeVacationRequsetApprovalDto.Approval);
            }

            return Unit.Value;
        }
    }
}