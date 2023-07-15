using AutoMapper;
using RoomRoost.DtoLayer.Dto.RoomDto;
using RoomRoost.EntityLayer.Concrete;

namespace RoomRoost.WebApi.Mapping
{
    public class AutoMapperConfig: Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<RoomAddDto, Room>();
            CreateMap<Room, RoomAddDto>();
            CreateMap<UpdateRoomDto, Room>().ReverseMap();//Makes reverse mapping, namely Room,UpdateRoomDto

                
        }
    }
}
