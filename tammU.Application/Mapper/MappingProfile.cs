using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tammU.Application.ViewModels;
using tammU.Domain.Models;

namespace tammU.Application.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserViewModel, User>().ReverseMap();
        }
    }
}
