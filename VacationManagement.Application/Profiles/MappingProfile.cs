using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using VacationManagement.Application.DTOs.VacationAllocation;
using VacationManagement.Application.DTOs.VacationRequset;
using VacationManagement.Application.DTOs.VacationType;
using VacationManagement.Domain;

namespace VacationManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<VacationRequset, VacationRequestDto>().ReverseMap();
            CreateMap<VacationRequset, VacationRequsetListDto>().ReverseMap();
            CreateMap<VacationType, VacationTypeDto>().ReverseMap();
            CreateMap<VacationAllocation, VacationAllocationDto>().ReverseMap();
        }
    }
}