using Proxy_API_2.Entities.Dtos;
using Proxy_API_2.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Proxy_API_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController(IPlayerService _service) : ControllerBase
    {
        [HttpGet("GetAllPlayers")]
        public async Task<ActionResult<List<GetAllPlayerDto>>> GetAllPlayer(int pageNumber, int pageSize)
        {
            var player = await _service.GetAllPlayers(pageNumber, pageSize);

            if (player == null)
            {
                return BadRequest("No Player exists !");
            }


            return Ok(new
            {
                Server = "Proxy_Server-2",
                Data = player

            });
        }

        [HttpGet("{id:int}", Name = "GetPlayerById")]
        public async Task<ActionResult<GetPlayerByIdDto?>> GetPlayerById(int id)
        {
            var palyer = await _service.GetPlayerById(id);
            if (palyer == null)
            {
                return BadRequest("No Player exist with this Id");
            }

            return Ok(palyer);
        }

        [HttpPost("CreateNewPlayer")]
        public async Task<ActionResult<GetPlayerByIdDto?>> CreatePlayer(CreatePlayerDto dto)
        {
            var player = await _service.CreatePlayer(dto);
            if (player is null) return BadRequest("Invalid Player Data Entered");

            return CreatedAtAction(nameof(GetPlayerById), new { id = player.PlayerId }, player);
        }

        [HttpPut("{id:int}", Name = "UpdatePlayerById")]
        public async Task<ActionResult<bool>> UpdatePlayer(int id, UpdatePlayerDto dto)
        {
            var player = await _service.UpdatePlayer(id, dto);

            if (player == false)
            {
                return BadRequest("Not able to Update");
            }

            return Ok(new
            {
                message = "Player Udated Successfully",
                data = player
            });
        }

        [HttpDelete("id:int", Name = "DeleteStudentById")]
        public async Task<ActionResult<bool>> DeleteStudent(int id)
        {
            var player = await _service.DeletePlayer(id);

            if (player == false)
            {
                return BadRequest("Player with this Id not Found");
            }
            return Ok(new
            {
                message = "Player Deleted Successfully !",
                data = player
            });
        }
    }
}
