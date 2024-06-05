using System;
using System.Collections.Generic;
using System.Text;

namespace VacationManagement.Application.DTOs.VacationType
{
    public class CreateVacationTypeDto : VacationTypeDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}