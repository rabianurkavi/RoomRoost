using AutoMapper;
using RoomRoost.EntityLayer.Concrete;
using RoomRoostHotel.WEBUI.Dtos.AboutDto;
using RoomRoostHotel.WEBUI.Dtos.LoginDto;
using RoomRoostHotel.WEBUI.Dtos.RegisterDto;
using RoomRoostHotel.WEBUI.Dtos.ServiceDto;

namespace RoomRoostHotel.WEBUI.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<ResultServiceDto, Service>().ReverseMap();
            CreateMap<UpdateServiceDto, Service>().ReverseMap();
            CreateMap<CreateServiceDto, Service>().ReverseMap();

            CreateMap<CreateAppUserDto, AppUser>().ReverseMap();
            CreateMap<LoginUserDto, AppUser>().ReverseMap();

            CreateMap<ResultAboutDto, About>().ReverseMap();
            CreateMap<UpdateAboutDto, About>().ReverseMap();

        }
    }
}
