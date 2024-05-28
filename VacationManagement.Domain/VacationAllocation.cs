using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Domain.Common;

namespace VacationManagement.Domain
{
    public class VacationAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public VacationType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }
    }
}