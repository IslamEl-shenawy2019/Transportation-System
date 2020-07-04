using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transportation_System.Core.Domain;

namespace Transportation_System.Models
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<Passenger, RegisterViewModel>();
            CreateMap<RegisterViewModel, Passenger>();
            CreateMap<Passenger, LoginViewModel>();
            CreateMap<LoginViewModel, Passenger>();
        }
    }
}
