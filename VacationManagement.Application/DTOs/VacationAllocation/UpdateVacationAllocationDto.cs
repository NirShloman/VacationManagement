using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;

namespace VacationManagement.Application.DTOs.VacationAllocation
{
    public class UpdateVacationAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public int VacationTypeId { get; set; }
        public int Period { get; set; }
    }
}