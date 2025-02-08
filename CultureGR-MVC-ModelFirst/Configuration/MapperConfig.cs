using AutoMapper;
using CultureGR_MVC_ModelFirst.Data;
using CultureGR_MVC_ModelFirst.DTO;

namespace CultureGR_MVC_ModelFirst.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<SubscriberSignupDTO, Subscriber>().ToString();
            CreateMap<RecordBaseDTO, Record>().ToString();
            CreateMap<UserBaseDTO, User>().ToString();
            CreateMap<UserUpdateDTO, Record>().ReverseMap();
            CreateMap<UserReadDTO, Record>().ReverseMap();
            CreateMap<UserUpdateDTO, User>().ReverseMap();
            CreateMap<UserReadDTO, User>().ReverseMap();
        }
    }
}
