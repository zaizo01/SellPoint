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
            CreateMap<Entidades, EntidadesGetDTO>().ReverseMap();
            CreateMap<Entidades, EntidadesPostDTO>().ReverseMap();
        }
    }
}
