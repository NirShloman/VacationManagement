using MediatR;
using VacationManagement.Application.DTOs.VacationRequset;
using VacationManagement.Application.DTOs.VacationType;

namespace VacationManagement.Application.Features.VacationRequests.Requests.Commands
{
    public class UpdateVacationRequestCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public VacationTypeDto VacationTypeDto { get; set; }
        public ChangeVacationRequsetApprovalDto changeVacationRequsetApprovalDto { get; set; }
    }
}