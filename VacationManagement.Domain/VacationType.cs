using System;
using VacationManagement.Domain.Common;

namespace VacationManagement.Domain
{
    public class VacationType : BaseDomainEntity
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}