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
    public class DeleteVacationRequestCommandHandler : IRequestHandler<DeleteVacationRequestCommand>
    {
        private readonly IVacationRequestRepository _vacationRequestRepository;
        private readonly IMapper _mapper;

        public DeleteVacationRequestCommandHandler(IVacationRequestRepository vacationRequestRepository, IMapper mapper)
        {
            _vacationRequestRepository = vacationRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(DeleteVacationRequestCommand request, CancellationToken cancellationToken)
        {
            var vacationRequest = await _vacationRequestRepository.Get(request.Id);

            await _vacationRequestRepository.Delete(vacationRequest);
            return Unit.Value;
        }
    }
}