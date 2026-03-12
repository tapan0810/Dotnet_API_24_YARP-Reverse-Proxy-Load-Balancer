using AutoMapper;
using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Data;
using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Dtos;
using Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Dotnet_API_24_YARP_Reverse_Proxy_Load_Balancer.Service
{
    public class PlayerService(PlayerDbContext _context,IMapper _mapper) : IPlayerService
    {
        public async Task<GetPlayerByIdDto?> CreatePlayer(CreatePlayerDto dto)
        {
            var player = _mapper.Map<Player>(dto);

            _context.Players.Add(player);
            await _context.SaveChangesAsync();

            return _mapper.Map<GetPlayerByIdDto?>(player);
        }

        public async Task<bool> DeletePlayer(int id)
        {
            var player = await _context.Players.FirstOrDefaultAsync(x =>x.PlayerId == id);

            if (player == null) return false;

            _context.Players.Remove(player);

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<GetAllPlayerDto>> GetAllPlayers(int pageNumber, int pageSize)
        {
            var players = await _context.Players
                .Skip((pageNumber-1)* pageSize)
                .Take(pageSize)
                .ToListAsync();

            if (players is null || players.Count == 0)
                return null;

            return _mapper.Map<List<GetAllPlayerDto>>(players);

        }

        public async Task<GetPlayerByIdDto?> GetPlayerById(int id)
        {
            var player = await _context.Players.FirstOrDefaultAsync(x => x.PlayerId == id);

            if (player is null) return null;

            return _mapper.Map<GetPlayerByIdDto?>(player);
        }

        public async Task<bool> UpdatePlayer(int id, UpdatePlayerDto dto)
        {
           var player = await _context.Players.FirstOrDefaultAsync(x =>x.PlayerId == id);

            if (player is null) return false;

            _mapper.Map(dto, player);
            await _context.SaveChangesAsync();

            return true;
        }
    }
}
