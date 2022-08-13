using AutoMapper;
using SellPoint.Data.DTOs.Entidades;
using SellPoint.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SellPoint.Presentation.WebAPI.MappingProfiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Entidades, UserCredentialsDTO>()
                .ForMember(u => u.UserName, m => m.MapFrom(e => e.UserNameEntidad))
                .ForMember(u => u.Password, m => m.MapFrom(e => e.PassworEntidad))
                .ReverseMap();
            CreateMap<Entidades, EntidadesGetDTO>().ReverseMap();
            CreateMap<Entidades, EntidadesPostDTO>().ReverseMap();
            CreateMap<Entidades, EntidadesPutDTO>().ReverseMap();
        }
    }
}
