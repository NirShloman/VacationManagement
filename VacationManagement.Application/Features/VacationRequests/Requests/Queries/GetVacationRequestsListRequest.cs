using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs;
using VacationManagement.Application.DTOs.VacationRequset;

namespace VacationManagement.Application.Features.VacationRequests.Requests.Queries
{
    public class GetVacationRequestsListRequest : IRequest<List<VacationRequestDto>>
    {
    }
}