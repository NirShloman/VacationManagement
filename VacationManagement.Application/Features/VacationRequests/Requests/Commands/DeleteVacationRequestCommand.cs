using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace VacationManagement.Application.Features.VacationRequests.Requests.Commands
{
    public class DeleteVacationRequestCommand : IRequest
    {
        public int Id { get; set; }
    }
}