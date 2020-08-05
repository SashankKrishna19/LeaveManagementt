using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LeaveManagementt.DTO;
using LeaveManagementt.Models;

namespace LeaveManagementt.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Employee, EmployeeDto>();
            Mapper.CreateMap<EmployeeDto, Employee>();
        }
    }
}