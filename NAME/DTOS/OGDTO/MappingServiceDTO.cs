using AutoMapper;
using Crud_Level_1.NAME.DTOS;
using Crud_Level_1.NAME.RepositoryLayer;
using CrudLevel1.NAME.Models;

namespace Crud_Level_1.NAME.DTOS.OGDTO
{
    public class MappingServiceDTO : Profile
    {

        public MappingServiceDTO() 
        {

            CreateMap<Person, ResponcePersonDTOS>();

            CreateMap<RequestPersonDTOS, Person>();

        }
    }
}
