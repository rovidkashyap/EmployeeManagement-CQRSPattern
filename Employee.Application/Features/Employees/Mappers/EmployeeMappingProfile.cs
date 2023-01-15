using AutoMapper;
using Employee.Application.Features.Employees.Commands;
using Employee.Application.Features.Employees.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Features.Employees.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Core.Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Core.Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
