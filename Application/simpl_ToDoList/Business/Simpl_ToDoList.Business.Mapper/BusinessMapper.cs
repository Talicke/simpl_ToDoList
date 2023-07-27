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
    public class BusinessMapper:Profile
    {
        public BusinessMapper()
        {
            CreateMap<Tache, ReadTachesDTO>()
                .IncludeBase<Tache, CreateTachesDTO>()
                .ReverseMap();

            CreateMap<Tache, CreateTachesDTO>()
               .ReverseMap();
        }
    }
}
