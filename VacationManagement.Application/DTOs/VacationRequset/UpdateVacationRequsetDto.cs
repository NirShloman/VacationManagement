using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;

namespace VacationManagement.Application.DTOs.VacationRequset
{
    public class UpdateVacationRequsetDto : BaseDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VacationTypeId { get; set; }
        public string RequestCommends { get; set; }
        public bool Cancelled { get; set; }
    }
}