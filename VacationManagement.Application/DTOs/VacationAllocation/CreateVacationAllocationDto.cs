﻿using System;
using System.Collections.Generic;
using System.Text;
using VacationManagement.Application.DTOs.Common;

namespace VacationManagement.Application.DTOs.VacationAllocation
{
    public class CreateVacationAllocationDto
    {
        public string Name { get; set; }
        public int DefaultDays { get; set; }
    }
}