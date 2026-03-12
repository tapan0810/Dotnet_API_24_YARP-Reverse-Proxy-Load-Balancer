using AutoMapper;
using Proxy_API_1.Entities.Dtos;
using Proxy_API_1.Entities.Models;

namespace Proxy_API_1.Mapping
{
    public class PlayerMappingProfile:Profile
    {
        public PlayerMappingProfile()
        {
            CreateMap<Player, GetAllPlayerDto>();

            CreateMap<Player, GetPlayerByIdDto>();

            CreateMap<UpdatePlayerDto, Player>();

            CreateMap<CreatePlayerDto, Player>(); 

        }
    }
}
