using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.VacationType;

namespace VacationManagement.Application.Features.VacationTypes.Requests.Queries
{
    public class GetVacationAllocationDetailsRequest : IRequest<VacationTypeDto>
    {
        public int Id { get; set; }
    }
}