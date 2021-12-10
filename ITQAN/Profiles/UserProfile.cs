using AutoMapper;
using SQLProvider.DTO;
using SQLProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITQAN.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<TicketMapper, Ticket>();
        }
    }
}
