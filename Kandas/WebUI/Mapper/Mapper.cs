using AutoMapper;
using Entities.Models;
using WebUI.Dtos.AdminDto;

namespace WebUI.Mapper
{
    public class Mapper : Profile
    {
        public Mapper()
        {
            CreateMap<AdminCityDto,City>().ReverseMap();
        }
    }
}
