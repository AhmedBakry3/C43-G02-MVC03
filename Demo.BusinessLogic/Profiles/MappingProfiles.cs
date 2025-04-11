﻿using AutoMapper;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.BusinessLogic.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<Employee, EmployeeDto>()
                  .ForMember(Dest => Dest.EmpGender, Options => Options.MapFrom(Src => Src.Gender))
                  .ForMember(Dest => Dest.EmpType, Options => Options.MapFrom(Src => Src.EmployeeType))
                  .ForMember(Dest => Dest.Department, Options => Options.MapFrom(Src => Src.Department != null ? Src.Department.Name : null));

            CreateMap<Employee, EmployeeDetailsDto>()
                  .ForMember(Dest => Dest.Gender, Options => Options.MapFrom(Src => Src.Gender))
                  .ForMember(Dest => Dest.EmployeeType, Options => Options.MapFrom(Src => Src.EmployeeType))
                  .ForMember(Dest => Dest.HiringDate, Options => Options.MapFrom(Src => DateOnly.FromDateTime(Src.HiringDate)))
                  .ForMember(Dest => Dest.Department, Options => Options.MapFrom(Src => Src.Department != null ? Src.Department.Name : null))
                  .ForMember(Dest => Dest.Image, Options => Options.MapFrom(Src => Src.ImageName));


            CreateMap<CreatedEmployeeDto, Employee>()
                  .ForMember(Dest => Dest.HiringDate, Options => Options.MapFrom(Src => Src.HiringDate.ToDateTime(TimeOnly.MinValue)));

            CreateMap<UpdatedEmployeeDto, Employee>()
                   .ForMember(Dest => Dest.HiringDate, Options => Options.MapFrom(Src => Src.HiringDate.ToDateTime(TimeOnly.MinValue)));

        }
    }
}
