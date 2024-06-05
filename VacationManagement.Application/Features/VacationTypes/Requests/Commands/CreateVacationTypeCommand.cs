using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.VacationType;

namespace VacationManagement.Application.Features.VacationTypes.Requests.Commands
{
    public class CreateVacationTypeCommand : IRequest<int>
    {
        public VacationTypeDto? VacationTypeDto { get; set; }
    }
}