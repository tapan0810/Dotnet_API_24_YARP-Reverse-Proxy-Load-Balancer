using AutoMapper;
using Proxy_API_2.Entities.Dtos;
using Proxy_API_2.Entities.Models;

namespace Proxy_API_2.Mapping
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
