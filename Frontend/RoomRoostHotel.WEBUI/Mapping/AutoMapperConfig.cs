using AutoMapper;
using RoomRoost.EntityLayer.Concrete;
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

        }
    }
}
