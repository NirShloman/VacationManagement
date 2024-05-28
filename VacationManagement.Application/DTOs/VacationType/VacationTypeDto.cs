using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;

namespace VacationManagement.Application.DTOs.VacationType
{
    public class VacationTypeDto : BaseDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}