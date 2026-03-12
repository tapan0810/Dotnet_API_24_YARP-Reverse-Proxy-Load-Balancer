using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Dtos;

namespace Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Service
{
    public interface IPlayerService
    {
        public Task<List<GetAllPlayerDto>> GetAllPlayers(int pageNumber, int pageSize);

        public Task<GetPlayerByIdDto?> GetPlayerById(int id);

        public Task<GetPlayerByIdDto?> CreatePlayer(CreatePlayerDto dto);

        public Task<bool> UpdatePlayer(int id,UpdatePlayerDto dto);

        public Task<bool> DeletePlayer(int id);
    }
}
