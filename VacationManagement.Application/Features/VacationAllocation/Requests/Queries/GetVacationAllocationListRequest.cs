using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.VacationAllocation;

namespace VacationManagement.Application.Features.VacationAllocation.Requests.Queries
{
    public class GetVacationAllocationListRequest : IRequest<List<VacationAllocationDto>>
    {
    }
}