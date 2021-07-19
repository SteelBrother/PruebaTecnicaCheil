using AutoMapper;
using PruebaTecnicaCheil.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaTecnicaCheil.WebApi.DTOs
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<HotelDTO, Hotel>();
            CreateMap<QualificationDTO, Qualification>();
            CreateMap<PhotoDTO, Photos>();
        }
    }
}
