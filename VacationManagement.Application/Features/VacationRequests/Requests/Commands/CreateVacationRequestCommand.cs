using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.VacationRequset;

namespace VacationManagement.Application.Features.VacationRequests.Requests.Commands
{
    public class CreateVacationRequestCommand : IRequest<int>
    {
        public VacationRequestDto VacationRequestsDto { get; set; }
    }
}