using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Domain;

namespace VacationManagement.Application.DTOs.VacationAllocation
{
    public class VacationAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }
        public VacationTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
    }
}