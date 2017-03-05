using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using JTimev2.Models;
using JTimev2.DTO;

namespace JTimev2.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            Mapper.CreateMap<Timesheet, TimesheetDto>();
            Mapper.CreateMap<Weekending, WeekendingDto>();
            Mapper.CreateMap<Timesheet, Timesheet>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<TimesheetDto, Timesheet>().ForMember(m => m.Id, opt => opt.Ignore());
            Mapper.CreateMap<WeekendingDto, Weekending>().ForMember(c => c.Id, opt => opt.Ignore());
        }
        

    }
}