using Proxy_API_1.Entities.Dtos;

namespace Proxy_API_1.Service
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
