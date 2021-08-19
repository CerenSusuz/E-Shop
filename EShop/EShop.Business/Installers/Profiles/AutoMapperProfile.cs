using AutoMapper;
using EShop.Business.Models;
using EShop.DataAccess.Entities;

namespace EShop.Business.Installers.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Gender, GendersDto>();
            CreateMap<Gender, GenderDto>().ReverseMap();

            CreateMap<UserGroup, UserGroupsDto>();
            CreateMap<UserGroup, UserGroupDto>().ReverseMap();

        }
    }
}