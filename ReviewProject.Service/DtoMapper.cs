using AutoMapper;
using ReviewProject.Core.DTOs;
using ReviewProject.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewProject.Service
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        { 
            CreateMap<UserAppDto, UserApp>().ReverseMap();
        }
    }
}
