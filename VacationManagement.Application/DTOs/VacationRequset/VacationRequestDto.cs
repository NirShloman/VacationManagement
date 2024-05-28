using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Domain;

namespace VacationManagement.Application.DTOs.VacationRequset
{
    public class VacationRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public VacationTypeDto LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string RequestingEmployeeId { get; set; }
    }
}