using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.VacationAllocation;

namespace VacationManagement.Application.Features.VacationAllocation.Requests.Commands
{
    public class CreateVacationAllocationCommand : IRequest<int>
    {
        public VacationAllocationDto VacationAllocationDto { get; set; }
    }
}