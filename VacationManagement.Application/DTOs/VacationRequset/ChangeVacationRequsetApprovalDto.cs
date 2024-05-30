using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using VacationManagement.Application.DTOs.Common;

namespace VacationManagement.Application.DTOs.VacationRequset
{
    public class ChangeVacationRequsetApprovalDto : BaseDto
    {
        public bool? Approval { get; set; }
    }
}