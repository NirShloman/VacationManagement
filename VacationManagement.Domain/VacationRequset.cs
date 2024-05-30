using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Domain.Common;

namespace VacationManagement.Domain
{
    public class VacationRequset : BaseDomainEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public VacationType VacationType { get; set; }
        public int VacationTypeId { get; set; }
        public DateTime DateRequested { get; set; }
        public string RequestComments { get; set; }
        public DateTime? DateActioned { get; set; }
        public bool? Approved { get; set; }
        public bool Cancelled { get; set; }
        public string RequestingEmployeeId { get; set; }
    }
}