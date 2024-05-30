using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Domain;

namespace VacationManagement.Application.DTOs.VacationRequset
{
    public class VacationRequsetListDto : BaseDto
    {
        public VacationTypeDto VacationType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }
    }
}