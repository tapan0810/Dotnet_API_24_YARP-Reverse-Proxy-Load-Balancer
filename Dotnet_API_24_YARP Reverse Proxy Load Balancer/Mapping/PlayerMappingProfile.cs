using AutoMapper;
using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Dtos;
using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Models;

namespace Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Mapping
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
