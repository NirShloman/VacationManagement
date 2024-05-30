using System;
using System.Collections.Generic;
using System.Text;

namespace VacationManagement.Application.DTOs.VacationRequset
{
    public class CreateVacationRequsetDto
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int VacationTypeId { get; set; }
        public string? RequestCommends { get; set; }
    }
}