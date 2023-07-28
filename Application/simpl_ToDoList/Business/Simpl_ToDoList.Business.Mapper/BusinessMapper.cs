using AutoMapper;
using simpl_ToDoList.Data.Entity;
using Simpl_ToDoList.Business.Models.Taches;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simpl_ToDoList.Business.Mapper
{
    public class BusinessMapper : Profile
    {
        public BusinessMapper()
        {


            CreateMap<Tache, CreateTachesDTO>()
                .ForMember(dest => dest.title, src => src.MapFrom(x => x.title))
                .ForMember(dest => dest.DesTache, src => src.MapFrom(x => x.DesTache))
                .ForMember(dest => dest.CreatedDatetache, src => src.MapFrom(x => x.CreatedDatetache))
                .ForMember(dest => dest.DueDatetache, src => src.MapFrom(x => x.DueDatetache))
                .ForMember(dest => dest.idStatus, src => src.MapFrom(x => x.idStatus))
                .ForMember(dest => dest.idUser, src => src.MapFrom(x => x.idUser))
                .ReverseMap();

            CreateMap<Tache, ReadTachesDTO>()
                .ForMember(dest => dest.Id, src => src.MapFrom(x => x.IdTache))
                .IncludeBase<Tache, CreateTachesDTO>()
                .ReverseMap();

        }
    }
}
