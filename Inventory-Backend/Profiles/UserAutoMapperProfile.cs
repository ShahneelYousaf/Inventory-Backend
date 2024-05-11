using AutoMapper;
using Inventory_Backend.Database.Entities.User;
using Inventory_Backend.Models.User;

namespace Inventory_Backend.Profiles
{
    public class UserAutoMapperProfile : Profile
    {
        public UserAutoMapperProfile()
        {
            CreateMap<UserModel, Users>();
            CreateMap<Users, UserDto>();
        }
    }
}
